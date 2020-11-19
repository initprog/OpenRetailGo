/**
 * Original work Copyright (C) 2017 Kamarudin (http://coding4ever.net/)
 * Modified work Copyright 2020 OpenRetailGo
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using OpenRetailGo.Repository.Api;
using Dapper;
using log4net;
using Npgsql;

namespace OpenRetailGo.Repository.Service
{    
    public class DapperContext : IDapperContext
    {
        private IDbConnection _db;
        private IDbTransaction _transaction;
        private readonly ILog _log = LogManager.GetLogger(typeof(DapperContext));

        private readonly string _providerName;
        private readonly string _connectionString;
        private string _dbError;
        public string DbError => _dbError;

        public DapperContext()
        {
            DbConnectionStringBuilder builder = new DbConnectionStringBuilder();
            builder.Add("Server", ConfigurationManager.AppSettings["server"]);
            builder.Add("Port", ConfigurationManager.AppSettings["port"]);
            builder.Add("User Id", "postgres");
            builder.Add("Passfile", ConfigurationManager.AppSettings["passfile"]);
            builder.Add("Database", ConfigurationManager.AppSettings["dbName"]);

            _providerName = "Npgsql";
            _connectionString = builder.ConnectionString;

            if (_db == null)
            {
                _db = GetOpenConnection(_providerName, _connectionString);
            }
        }        

		public bool IsOpenConnection()
        {
            var isConnected = false;

            try
            {
                using (var conn = GetOpenConnection(_providerName, _connectionString))
                {
                    isConnected = conn.State == ConnectionState.Open;
                }
            }
            catch
            {
            }

            return isConnected;
        }

        public bool ExecSQL(string sql)
        {
            var result = false;
            _dbError = string.Empty;

            try
            {
                _db.Execute(sql);
                result = true;
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        private IDbConnection GetOpenConnection(string providerName, string connectionString)
        {
            DbConnection conn = null;
            _dbError = string.Empty;

            try
            {
                DbProviderFactory provider = DbProviderFactories.GetFactory(providerName);
                conn = provider.CreateConnection();
                conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch(PostgresException pe)
            {
                if (pe.SqlState == "28P01")  // invalid credential
                {
                    _dbError = @"Tidak menemukan akun dengan username atau password yang anda masukkan.";
                    _log.Fatal(pe.Message);
                }
                else
                {
                    _dbError = pe.Message;
                    _log.Fatal(pe.Message);
                }
            } catch(Exception ex)
            {
                _dbError = ex.Message;
                _log.Fatal(ex.Message);
            }

            return conn;
        }

        public IDbConnection db
        {
            get { return _db ?? (_db = GetOpenConnection(_providerName, _connectionString)); }
        }

		public IDbTransaction transaction
        {
            get { return _transaction; }
        }

        public void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted)
        {
            if (_transaction == null)
                _transaction = _db.BeginTransaction(isolationLevel);
        }

        public void Commit()
        {
            if (_transaction != null)
            {
                _transaction.Commit();
                _transaction = null;
            }            
        }

        public void Rollback()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }            
        }

        private int GetGeneratorIDByTable(string tableName, IDbTransaction transaction = null)
        {
            int result = 0;

            try
            {
                var generatorName = tableName + "_" + tableName.Substring(2) + "_id_seq";

                var strSql = String.Format("SELECT NEXTVAL('{0}')", generatorName);
				result = _db.QuerySingleOrDefault<int>(strSql, transaction);
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        public string GetLastNota(string tableName, IDbTransaction transaction = null)
        {
            var lastId = GetGeneratorIDByTable(tableName, transaction);
            var lastNota = string.Format("{0}{1:00}{2:00}{3:0000}", DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, lastId);

            return lastNota;
        }

		public string GetGUID()
        {
            var result = string.Empty;

            try
            {
                result = Guid.NewGuid().ToString();
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return result;
        }

        public int GetPagesCount(string sql, int pageSize, object param = null)
        {
            var pagesCount = 0;

            try
            {
                var recordCount = _db.QuerySingleOrDefault<int>(sql, param);
                pagesCount = (int)Math.Ceiling(recordCount / (decimal)pageSize);
            }
            catch (Exception ex)
            {
                _log.Error("Error:", ex);
            }

            return pagesCount;
        }

        public void Dispose()
        {
            if (_db != null)
            {
                try
                {
                    if (_db.State != ConnectionState.Closed)
                    {
                        if (_transaction != null)
                        {
                            _transaction.Rollback();
                        }

                        _db.Close();
                    }                        
                }
                finally
                {
                    _db.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }        
    }
}

﻿/**
 * Original work Copyright (C) 2017 Kamarudin (http://coding4ever.net/)
 * Modified work copyright 2020 OpenRetailGo
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

using System.IO;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Reporting.WinForms;

namespace OpenRetailGo.Helper
{
    public class ReportViewerPrintHelper
    {
        private string _reportNameSpace = @"OpenRetailGo.Report.{0}.rdlc";
        private Assembly _assemblyReport;
        private Stream _stream;
        private string _printerName;
        private ReportDataSource _reportDataSource;
        IEnumerable<ReportParameter> _parameters;

        public ReportViewerPrintHelper()
        {
            _assemblyReport = Assembly.LoadFrom("OpenRetailGo.Report.dll");
        }

        public ReportViewerPrintHelper(string reportName, ReportDataSource reportDataSource, IEnumerable<ReportParameter> parameters = null, string printerName = null)
            : this()
        {
            reportName = string.Format(_reportNameSpace, reportName);
            _stream = _assemblyReport.GetManifestResourceStream(reportName);
            _reportDataSource = reportDataSource;
            _parameters = parameters;
            _printerName = printerName;
        }

        public void Print()
        {
            var report = new LocalReport();
            report.DataSources.Clear();
            report.DataSources.Add(_reportDataSource);
            report.LoadReportDefinition(_stream);

            if (_parameters != null)
                report.SetParameters(_parameters);

            using (var printer = new ReportPrintHelper())
            {
                printer.PrintToPrinter(report, _printerName);
            } 
        }
    }
}

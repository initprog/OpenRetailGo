/**
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

using System;
using System.Collections.Generic;
using System.Globalization;

namespace OpenRetailGo.Helper
{
    public static class DayMonthHelper
    {
        /// <summary>
        /// Untuk mengecek tanggal minimal
        /// </summary>
        /// <param name="tanggal"></param>
        /// <returns></returns>
        public static bool IsMinDate(DateTime tanggal)
        {
            try
            {
                return (tanggal == DateTime.MinValue || tanggal == new DateTime(1753, 1, 1));
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Untuk mendapatkan index hari
        /// </summary>
        /// <param name="tanggal">Tanggal yang ingin dicari index harinya</param>
        /// <returns></returns>
        private static int Weekday(DateTime tanggal)
        {
            DayOfWeek startOfWeek = DayOfWeek.Sunday;
            return (tanggal.DayOfWeek - startOfWeek + 7) % 7;
        }

        /// <summary>
        /// Untuk mendapatkan nama hari berdasarkan tanggal
        /// </summary>
        /// <param name="tanggal">Tanggal yang ingin dicari harinya</param>
        /// <returns></returns>
        public static string GetHariIndonesia(DateTime tanggal)
        {
            DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("id-ID").DateTimeFormat;
            string[] hari = dtfi.DayNames;
            
            return hari[Weekday(tanggal)];
        }

        /// <summary>
        /// Untuk mendapatkan nama bulan dalam format huruf berdasarkan angka bulan
        /// </summary>
        /// <param name="bulan">Diisi dengan angka bulan [1-12]</param>
        /// <param nama="shortName">Singkat nama bulan</param>
        /// <returns>Nama bulan [Januari - Desember]</returns>
        public static string GetBulanIndonesia(int bulan, bool shortName = false)
        {
            DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("id-ID").DateTimeFormat;
            shortName = true;
            if (shortName)
            {
                string[] daftarBulan = dtfi.AbbreviatedMonthNames;
                return daftarBulan[--bulan];
            }
            return dtfi.GetMonthName(bulan);
        }

        /// <summary>
        /// Untuk mendapatkan index bulan berdasarkan nama bulan
        /// </summary>
        /// <param name="bulan">Diisi dengan nama bulan. Misal Januari</param>
        /// <returns>Angka bulan [1-12]</returns>
        public static int GetBulanAngka(string bulan)
        {
            DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo("id-ID").DateTimeFormat;
            string[] daftarBulan = dtfi.MonthNames;

            // idx start dari 0 (Januari)
            int idx = Array.FindIndex<string>(daftarBulan, hari => bulan.Equals(hari, StringComparison.OrdinalIgnoreCase));
            
            return ++idx;
        }

        /// <summary>
        /// Untuk mendapatkan informasi daftar bulan dan tahun
        /// </summary>
        /// <param name="tahunMulai">Diisi dengan tahun mulai, nilai default 2011</param>
        /// <param name="isBulanOnly">Diisi dengan nilai true atau false, nilai default false</param>
        /// <returns></returns>
        public static List<string> GetListBulan(int tahunMulai = 2011, bool isBulanOnly = false)
        {
            var listBulan = new List<string>();

            for (int tahun = tahunMulai; tahun <= DateTime.Today.Year; tahun++)
            {
                for (int bulan = 1; bulan < 13; bulan++)
                {
                    if (isBulanOnly)
                    {
                        listBulan.Add(GetBulanIndonesia(bulan));
                    }
                    else
                    {
                        listBulan.Add(GetBulanIndonesia(bulan) + " " + tahun);
                    }
                }
            }

            return listBulan;
        }
    }
}

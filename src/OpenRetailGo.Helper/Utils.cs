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

using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace OpenRetailGo.Helper
{
    public static class Utils
    {
        /// <summary>
        /// Untuk mengecek apakah aplikasi dijalankan dari IDE atau tidak
        /// </summary>
        /// <returns></returns>
        public static bool IsRunningUnderIDE()
        {
            return System.Diagnostics.Debugger.IsAttached;
        }

        /// <summary>
        /// Untuk mendapatkan folder instalasi
        /// </summary>
        /// <returns></returns>
        public static string GetAppPath()
        {
            return Directory.GetCurrentDirectory();
        }


        /// <summary>
        /// Untuk mendapatkan versi aplikasi dengan format : Major.Minor.Revision
        /// </summary>
        /// <param name="appExe">Assembly name</param>
        /// <returns></returns>
        public static string GetCurrentVersion()
        {
            var fvi = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
            var version = fvi.ProductMajorPart + "." + fvi.ProductMinorPart + "." + fvi.ProductBuildPart;

            return version;
        }
    }
}

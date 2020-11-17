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

using System;
using System.Windows.Forms;

namespace OpenRetailGo.Helper.UI.Template
{
    /// <summary>
    /// Base class form untuk entry data
    /// </summary>
    public partial class FrmDialogInfo : BaseFrmLookup
    {
        public FrmDialogInfo()
        {
            InitializeComponent();
            ColorManagerHelper.SetTheme(this, this);            
        }
        
        protected override void SetHeader(string header)
        {
            this.Text = header;
            this.lblHeader.Text = header;
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            Batal();
        }

        private void FrmDialogInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (KeyPressHelper.IsEsc(e))
                Batal();
        }        
    }
}

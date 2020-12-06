/**
 * Copyright (C) 2020 OpenRetailGo
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

using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;
using OpenRetailGo.Helper.UI.Template;
using OpenRetailGo.Helper;
using ConceptCave.WaitCursor;

namespace OpenRetailGo.Referensi
{
    public partial class FrmEntryGrupCustomer : FrmEntryStandard
    {
        private IGrupCustomerBll _bll = null; // deklarasi objek business logic layer 
        private GrupCustomer _grupCustomer = null;
        private bool _isNewData = false;

        public IListener Listener { private get; set; }

        public FrmEntryGrupCustomer(string header, IGrupCustomerBll bll)
            : base()
        {
            InitializeComponent();
            ColorManagerHelper.SetTheme(this, this);

            base.SetHeader(header);
            this._bll = bll;

            this._isNewData = true;
        }

        public FrmEntryGrupCustomer(string header, GrupCustomer grupCustomer, IGrupCustomerBll bll)
            : base()
        {
            InitializeComponent();
            ColorManagerHelper.SetTheme(this, this);

            base.SetHeader(header);
            base.SetButtonSelesaiToBatal();
            this._bll = bll;
            this._grupCustomer = grupCustomer;

            txtNamaGrup.Text = this._grupCustomer.nama_grup;
            txtDeskripsi.Text = this._grupCustomer.deskripsi;
        }

        protected override void Simpan()
        {
            if (_isNewData)
                _grupCustomer = new GrupCustomer();

            _grupCustomer.nama_grup = txtNamaGrup.Text;
            _grupCustomer.deskripsi = txtDeskripsi.Text;

            var result = 0;
            var validationError = new ValidationError();

            using (new StCursor(Cursors.WaitCursor, new TimeSpan(0, 0, 0, 0)))
            {
                if (_isNewData)
                    result = _bll.Save(_grupCustomer, ref validationError);
                else
                    result = _bll.Update(_grupCustomer, ref validationError);

                if (result > 0)
                {
                    Listener.Ok(this, _isNewData, _grupCustomer);

                    if (_isNewData)
                    {
                        base.ResetForm(this);
                        txtNamaGrup.Focus();

                    }
                    else
                        this.Close();

                }
                else
                {
                    if (validationError.Message.NullToString().Length > 0)
                    {
                        MsgHelper.MsgWarning(validationError.Message);
                        base.SetFocusObject(validationError.PropertyName, this);
                    }
                    else
                        MsgHelper.MsgUpdateError();
                }
            }                            
        }
    }
}

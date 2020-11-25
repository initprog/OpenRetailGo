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

using System.Windows.Forms;

using OpenRetailGo.Model;
using OpenRetailGo.Bll.Api;
using OpenRetailGo.Bll.Service;
using OpenRetailGo.Helper.UI.Template;
using OpenRetailGo.Helper;
using System.Drawing;
using System.IO;

namespace OpenRetailGo.Pengaturan
{
    public partial class FrmProfilPerusahaan : FrmEntryStandard
    {
        private Profil _profil = null;
        enum LogoChanged { No, YesAdd, YesDelete }
        private LogoChanged logoStatus = LogoChanged.No;
        private string logoPath = $"{Application.CommonAppDataPath}/logo.png";

        public IListener Listener { private get; set; }

        public FrmProfilPerusahaan(string header, Profil profil)
            : base()
        {
            InitializeComponent();
            ColorManagerHelper.SetTheme(this, this);

            base.SetHeader(header);
            base.SetButtonSelesaiToBatal();
            this._profil = profil;

            if (this._profil != null)
            {
                txtNamaPerusahaan.Text = this._profil.nama_profil;
                txtAlamat.Text = this._profil.alamat;
                txtKota.Text = this._profil.kota;
                txtTelepon.Text = this._profil.telepon;
                txtEmail.Text = this._profil.email;
                txtWebsite.Text = this._profil.website;

                if (File.Exists(logoPath))
                {
                    pbLogo.Image = new Bitmap(logoPath);
                }
                else
                {
                    pbLogo.Image = Properties.Resources.nologo;
                }
            }            
        }

        protected override void Simpan()
        {
            if (this._profil == null)
                this._profil = new Profil();

            _profil.nama_profil = txtNamaPerusahaan.Text;
            _profil.alamat = txtAlamat.Text;
            _profil.kota = txtKota.Text;
            _profil.telepon = txtTelepon.Text;
            _profil.email = txtEmail.Text;
            _profil.website = txtWebsite.Text;

            var result = 0;
            var validationError = new ValidationError();

            IProfilBll bll = new ProfilBll(MainProgram.log);
            result = bll.Save(_profil, ref validationError);

            if(logoStatus == LogoChanged.YesAdd)
            {
                Bitmap logo = new Bitmap(ofdLogo.FileName);
                // Save company logo in PNG format with default filename "logo.png"
                if (Path.GetExtension(ofdLogo.FileName).ToLower() != ".png")
                {
                    logo.Save(logoPath, System.Drawing.Imaging.ImageFormat.Png);
                }
            } else if (logoStatus == LogoChanged.YesDelete)
            {
                File.Delete(logoPath);
            }

            if (result > 0) 
            {
                Listener.Ok(this, _profil);
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

        private void txtWebsite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (KeyPressHelper.IsEnter(e))
                Simpan();
        }

        private void btnAddLogo_Click(object sender, System.EventArgs e)
        {
            if(ofdLogo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbLogo.Image = new Bitmap(ofdLogo.FileName);
                    logoStatus = LogoChanged.YesAdd;                    
                }
                catch(FileNotFoundException exf)
                {

                }
            }
        }

        private void btnDelLogo_Click(object sender, System.EventArgs e)
        {
            // Need to dispose the bitmap to release file lock
            // so that we can delete them on Save.
            if (File.Exists(logoPath)) pbLogo.Image.Dispose();

            pbLogo.Image = Properties.Resources.nologo;

            logoStatus = File.Exists(logoPath) ? LogoChanged.YesDelete : LogoChanged.No;
        }
    }
}

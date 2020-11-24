namespace OpenRetailGo.Pengaturan
{
    partial class FrmProfilPerusahaan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaPerusahaan = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.txtAlamat = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.txtKota = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.txtTelepon = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.txtWebsite = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnAddLogo = new System.Windows.Forms.Button();
            this.btnDelLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelesai.Location = new System.Drawing.Point(527, 439);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(380, 439);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Perusahaan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kota";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telepon";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNamaPerusahaan
            // 
            this.txtNamaPerusahaan.AutoEnter = true;
            this.txtNamaPerusahaan.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtNamaPerusahaan.EnterFocusColor = System.Drawing.Color.White;
            this.txtNamaPerusahaan.LeaveFocusColor = System.Drawing.Color.White;
            this.txtNamaPerusahaan.LetterOnly = false;
            this.txtNamaPerusahaan.Location = new System.Drawing.Point(38, 54);
            this.txtNamaPerusahaan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamaPerusahaan.Name = "txtNamaPerusahaan";
            this.txtNamaPerusahaan.NumericOnly = false;
            this.txtNamaPerusahaan.SelectionText = false;
            this.txtNamaPerusahaan.Size = new System.Drawing.Size(338, 27);
            this.txtNamaPerusahaan.TabIndex = 0;
            this.txtNamaPerusahaan.Tag = "nama_profil";
            this.txtNamaPerusahaan.ThousandSeparator = false;
            // 
            // txtAlamat
            // 
            this.txtAlamat.AutoEnter = true;
            this.txtAlamat.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtAlamat.EnterFocusColor = System.Drawing.Color.White;
            this.txtAlamat.LeaveFocusColor = System.Drawing.Color.White;
            this.txtAlamat.LetterOnly = false;
            this.txtAlamat.Location = new System.Drawing.Point(38, 118);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.NumericOnly = false;
            this.txtAlamat.SelectionText = false;
            this.txtAlamat.Size = new System.Drawing.Size(338, 27);
            this.txtAlamat.TabIndex = 1;
            this.txtAlamat.Tag = "alamat";
            this.txtAlamat.ThousandSeparator = false;
            // 
            // txtKota
            // 
            this.txtKota.AutoEnter = true;
            this.txtKota.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtKota.EnterFocusColor = System.Drawing.Color.White;
            this.txtKota.LeaveFocusColor = System.Drawing.Color.White;
            this.txtKota.LetterOnly = false;
            this.txtKota.Location = new System.Drawing.Point(38, 184);
            this.txtKota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKota.Name = "txtKota";
            this.txtKota.NumericOnly = false;
            this.txtKota.SelectionText = false;
            this.txtKota.Size = new System.Drawing.Size(338, 27);
            this.txtKota.TabIndex = 2;
            this.txtKota.Tag = "kota";
            this.txtKota.ThousandSeparator = false;
            // 
            // txtTelepon
            // 
            this.txtTelepon.AutoEnter = true;
            this.txtTelepon.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtTelepon.EnterFocusColor = System.Drawing.Color.White;
            this.txtTelepon.LeaveFocusColor = System.Drawing.Color.White;
            this.txtTelepon.LetterOnly = false;
            this.txtTelepon.Location = new System.Drawing.Point(38, 244);
            this.txtTelepon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.NumericOnly = false;
            this.txtTelepon.SelectionText = false;
            this.txtTelepon.Size = new System.Drawing.Size(163, 27);
            this.txtTelepon.TabIndex = 3;
            this.txtTelepon.Tag = "telepon";
            this.txtTelepon.ThousandSeparator = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Website";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoEnter = true;
            this.txtEmail.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtEmail.EnterFocusColor = System.Drawing.Color.White;
            this.txtEmail.LeaveFocusColor = System.Drawing.Color.White;
            this.txtEmail.LetterOnly = false;
            this.txtEmail.Location = new System.Drawing.Point(38, 309);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.NumericOnly = false;
            this.txtEmail.SelectionText = false;
            this.txtEmail.Size = new System.Drawing.Size(338, 27);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Tag = "email";
            this.txtEmail.ThousandSeparator = false;
            // 
            // txtWebsite
            // 
            this.txtWebsite.AutoEnter = false;
            this.txtWebsite.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtWebsite.EnterFocusColor = System.Drawing.Color.White;
            this.txtWebsite.LeaveFocusColor = System.Drawing.Color.White;
            this.txtWebsite.LetterOnly = false;
            this.txtWebsite.Location = new System.Drawing.Point(38, 375);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.NumericOnly = false;
            this.txtWebsite.SelectionText = false;
            this.txtWebsite.Size = new System.Drawing.Size(338, 27);
            this.txtWebsite.TabIndex = 5;
            this.txtWebsite.Tag = "website";
            this.txtWebsite.ThousandSeparator = false;
            this.txtWebsite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWebsite_KeyPress);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::OpenRetailGo.Properties.Resources.nologo;
            this.pbLogo.Location = new System.Drawing.Point(425, 54);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 200);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.btnAddLogo_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(421, 29);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(44, 20);
            this.lblLogo.TabIndex = 7;
            this.lblLogo.Text = "Logo";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddLogo
            // 
            this.btnAddLogo.Image = global::OpenRetailGo.Properties.Resources.Add_16x;
            this.btnAddLogo.Location = new System.Drawing.Point(424, 265);
            this.btnAddLogo.Name = "btnAddLogo";
            this.btnAddLogo.Size = new System.Drawing.Size(41, 37);
            this.btnAddLogo.TabIndex = 8;
            this.btnAddLogo.UseVisualStyleBackColor = true;
            this.btnAddLogo.Click += new System.EventHandler(this.btnAddLogo_Click);
            // 
            // btnDelLogo
            // 
            this.btnDelLogo.Image = global::OpenRetailGo.Properties.Resources.Close_16x;
            this.btnDelLogo.Location = new System.Drawing.Point(476, 265);
            this.btnDelLogo.Name = "btnDelLogo";
            this.btnDelLogo.Size = new System.Drawing.Size(41, 37);
            this.btnDelLogo.TabIndex = 9;
            this.btnDelLogo.UseVisualStyleBackColor = true;
            this.btnDelLogo.Click += new System.EventHandler(this.btnDelLogo_Click);
            // 
            // FrmProfilPerusahaan
            // 
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSelesai;
            this.ClientSize = new System.Drawing.Size(669, 509);
            this.Controls.Add(this.btnDelLogo);
            this.Controls.Add(this.btnAddLogo);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.txtNamaPerusahaan);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProfilPerusahaan";
            this.Text = "FrmProfilPerusahaan";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtTelepon, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnSimpan, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnSelesai, 0);
            this.Controls.SetChildIndex(this.txtWebsite, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtKota, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtAlamat, 0);
            this.Controls.SetChildIndex(this.txtNamaPerusahaan, 0);
            this.Controls.SetChildIndex(this.pbLogo, 0);
            this.Controls.SetChildIndex(this.lblLogo, 0);
            this.Controls.SetChildIndex(this.btnAddLogo, 0);
            this.Controls.SetChildIndex(this.btnDelLogo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtNamaPerusahaan;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtAlamat;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtKota;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtTelepon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Helper.UserControl.AdvancedTextbox txtEmail;
        private Helper.UserControl.AdvancedTextbox txtWebsite;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnAddLogo;
        private System.Windows.Forms.Button btnDelLogo;
    }
}
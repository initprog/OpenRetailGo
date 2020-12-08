namespace OpenRetailGo.Referensi
{
    partial class FrmEntryGrupCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntryGrupCustomer));
            this.lblNamaGrup = new System.Windows.Forms.Label();
            this.txtDeskripsi = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtNamaGrup = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.lblReq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelesai.Location = new System.Drawing.Point(228, 137);
            this.btnSelesai.Size = new System.Drawing.Size(88, 38);
            this.btnSelesai.TabIndex = 3;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(109, 137);
            this.btnSimpan.Size = new System.Drawing.Size(88, 38);
            this.btnSimpan.TabIndex = 2;
            // 
            // lblNamaGrup
            // 
            this.lblNamaGrup.AutoSize = true;
            this.lblNamaGrup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaGrup.Location = new System.Drawing.Point(33, 15);
            this.lblNamaGrup.Name = "lblNamaGrup";
            this.lblNamaGrup.Size = new System.Drawing.Size(130, 15);
            this.lblNamaGrup.TabIndex = 0;
            this.lblNamaGrup.Text = "Nama Grup Pelanggan";
            this.lblNamaGrup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.AutoEnter = true;
            this.txtDeskripsi.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtDeskripsi.EnterFocusColor = System.Drawing.Color.White;
            this.txtDeskripsi.LeaveFocusColor = System.Drawing.Color.White;
            this.txtDeskripsi.LetterOnly = false;
            this.txtDeskripsi.Location = new System.Drawing.Point(36, 83);
            this.txtDeskripsi.MaxLength = 80;
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.NumericOnly = false;
            this.txtDeskripsi.SelectionText = false;
            this.txtDeskripsi.Size = new System.Drawing.Size(280, 23);
            this.txtDeskripsi.TabIndex = 1;
            this.txtDeskripsi.ThousandSeparator = false;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskripsi.Location = new System.Drawing.Point(33, 65);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(58, 15);
            this.lblDeskripsi.TabIndex = 2;
            this.lblDeskripsi.Text = "Deskripsi";
            this.lblDeskripsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNamaGrup
            // 
            this.txtNamaGrup.AutoEnter = true;
            this.txtNamaGrup.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtNamaGrup.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNamaGrup.LeaveFocusColor = System.Drawing.Color.White;
            this.txtNamaGrup.LetterOnly = false;
            this.txtNamaGrup.Location = new System.Drawing.Point(36, 33);
            this.txtNamaGrup.MaxLength = 30;
            this.txtNamaGrup.Name = "txtNamaGrup";
            this.txtNamaGrup.NumericOnly = false;
            this.txtNamaGrup.SelectionText = false;
            this.txtNamaGrup.Size = new System.Drawing.Size(280, 23);
            this.txtNamaGrup.TabIndex = 0;
            this.txtNamaGrup.Tag = "nama_grupCustomer";
            this.txtNamaGrup.ThousandSeparator = false;
            // 
            // lblReq
            // 
            this.lblReq.ForeColor = System.Drawing.Color.Red;
            this.lblReq.Location = new System.Drawing.Point(161, 15);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(10, 15);
            this.lblReq.TabIndex = 5;
            this.lblReq.Text = "*";
            this.lblReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmEntryGrupCustomer
            // 
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSelesai;
            this.ClientSize = new System.Drawing.Size(346, 184);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.txtNamaGrup);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.lblNamaGrup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEntryGrupCustomer";
            this.Text = "FrmEntryGrupCustomer";
            this.Controls.SetChildIndex(this.lblNamaGrup, 0);
            this.Controls.SetChildIndex(this.lblDeskripsi, 0);
            this.Controls.SetChildIndex(this.btnSimpan, 0);
            this.Controls.SetChildIndex(this.btnSelesai, 0);
            this.Controls.SetChildIndex(this.txtDeskripsi, 0);
            this.Controls.SetChildIndex(this.txtNamaGrup, 0);
            this.Controls.SetChildIndex(this.lblReq, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNamaGrup;
        private Helper.UserControl.AdvancedTextbox txtDeskripsi;
        private System.Windows.Forms.Label lblDeskripsi;
        private Helper.UserControl.AdvancedTextbox txtNamaGrup;
        private System.Windows.Forms.Label lblReq;
    }
}
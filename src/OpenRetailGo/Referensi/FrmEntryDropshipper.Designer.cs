namespace OpenRetailGo.Referensi
{
    partial class FrmEntryDropshipper
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
            this.lblDropshipper = new System.Windows.Forms.Label();
            this.txtDropshipper = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.txtAlamat = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.txtTelepon = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.lblReq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelesai.Location = new System.Drawing.Point(346, 264);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelesai.Size = new System.Drawing.Size(101, 51);
            this.btnSelesai.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(208, 264);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Size = new System.Drawing.Size(101, 51);
            this.btnSimpan.TabIndex = 3;
            // 
            // lblDropshipper
            // 
            this.lblDropshipper.AutoSize = true;
            this.lblDropshipper.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDropshipper.Location = new System.Drawing.Point(32, 28);
            this.lblDropshipper.Name = "lblDropshipper";
            this.lblDropshipper.Size = new System.Drawing.Size(96, 20);
            this.lblDropshipper.TabIndex = 0;
            this.lblDropshipper.Text = "Dropshipper";
            this.lblDropshipper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDropshipper
            // 
            this.txtDropshipper.AutoEnter = true;
            this.txtDropshipper.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtDropshipper.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDropshipper.LeaveFocusColor = System.Drawing.Color.White;
            this.txtDropshipper.LetterOnly = false;
            this.txtDropshipper.Location = new System.Drawing.Point(35, 52);
            this.txtDropshipper.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDropshipper.Name = "txtDropshipper";
            this.txtDropshipper.NumericOnly = false;
            this.txtDropshipper.SelectionText = false;
            this.txtDropshipper.Size = new System.Drawing.Size(411, 27);
            this.txtDropshipper.TabIndex = 0;
            this.txtDropshipper.Tag = "nama_supplier";
            this.txtDropshipper.ThousandSeparator = false;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlamat.Location = new System.Drawing.Point(32, 97);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(60, 20);
            this.lblAlamat.TabIndex = 1;
            this.lblAlamat.Text = "Alamat";
            this.lblAlamat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelepon.Location = new System.Drawing.Point(32, 169);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(64, 20);
            this.lblTelepon.TabIndex = 1;
            this.lblTelepon.Text = "Telepon";
            this.lblTelepon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAlamat
            // 
            this.txtAlamat.AutoEnter = true;
            this.txtAlamat.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtAlamat.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAlamat.LeaveFocusColor = System.Drawing.Color.White;
            this.txtAlamat.LetterOnly = false;
            this.txtAlamat.Location = new System.Drawing.Point(35, 121);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.NumericOnly = false;
            this.txtAlamat.SelectionText = false;
            this.txtAlamat.Size = new System.Drawing.Size(411, 27);
            this.txtAlamat.TabIndex = 1;
            this.txtAlamat.Tag = "alamat";
            this.txtAlamat.ThousandSeparator = false;
            // 
            // txtTelepon
            // 
            this.txtTelepon.AutoEnter = false;
            this.txtTelepon.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtTelepon.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTelepon.LeaveFocusColor = System.Drawing.Color.White;
            this.txtTelepon.LetterOnly = false;
            this.txtTelepon.Location = new System.Drawing.Point(35, 193);
            this.txtTelepon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.NumericOnly = false;
            this.txtTelepon.SelectionText = false;
            this.txtTelepon.Size = new System.Drawing.Size(411, 27);
            this.txtTelepon.TabIndex = 2;
            this.txtTelepon.Tag = "telepon";
            this.txtTelepon.ThousandSeparator = false;
            this.txtTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelepon_KeyPress);
            // 
            // lblReq
            // 
            this.lblReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReq.ForeColor = System.Drawing.Color.Red;
            this.lblReq.Location = new System.Drawing.Point(119, 27);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(11, 20);
            this.lblReq.TabIndex = 3;
            this.lblReq.Text = "*";
            this.lblReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmEntryDropshipper
            // 
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSelesai;
            this.ClientSize = new System.Drawing.Size(481, 344);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.txtDropshipper);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.lblDropshipper);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblTelepon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEntryDropshipper";
            this.Text = "FrmEntryDropshipper";
            this.Controls.SetChildIndex(this.btnSimpan, 0);
            this.Controls.SetChildIndex(this.lblTelepon, 0);
            this.Controls.SetChildIndex(this.btnSelesai, 0);
            this.Controls.SetChildIndex(this.lblAlamat, 0);
            this.Controls.SetChildIndex(this.txtTelepon, 0);
            this.Controls.SetChildIndex(this.lblDropshipper, 0);
            this.Controls.SetChildIndex(this.txtAlamat, 0);
            this.Controls.SetChildIndex(this.txtDropshipper, 0);
            this.Controls.SetChildIndex(this.lblReq, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDropshipper;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtDropshipper;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblTelepon;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtAlamat;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtTelepon;
        private System.Windows.Forms.Label lblReq;
    }
}
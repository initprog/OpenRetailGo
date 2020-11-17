namespace OpenRetailGo.Referensi
{
    partial class FrmEntryJabatan
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
            this.txtJabatan = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeterangan = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.lblReq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelesai.Location = new System.Drawing.Point(263, 209);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelesai.Size = new System.Drawing.Size(101, 51);
            this.btnSelesai.TabIndex = 3;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(128, 209);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Size = new System.Drawing.Size(101, 51);
            this.btnSimpan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jabatan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtJabatan
            // 
            this.txtJabatan.AutoEnter = true;
            this.txtJabatan.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtJabatan.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtJabatan.LeaveFocusColor = System.Drawing.Color.White;
            this.txtJabatan.LetterOnly = false;
            this.txtJabatan.Location = new System.Drawing.Point(37, 55);
            this.txtJabatan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.NumericOnly = false;
            this.txtJabatan.SelectionText = false;
            this.txtJabatan.Size = new System.Drawing.Size(325, 27);
            this.txtJabatan.TabIndex = 0;
            this.txtJabatan.Tag = "nama_jabatan";
            this.txtJabatan.ThousandSeparator = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keterangan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.AutoEnter = false;
            this.txtKeterangan.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtKeterangan.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKeterangan.LeaveFocusColor = System.Drawing.Color.White;
            this.txtKeterangan.LetterOnly = false;
            this.txtKeterangan.Location = new System.Drawing.Point(37, 133);
            this.txtKeterangan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.NumericOnly = false;
            this.txtKeterangan.SelectionText = false;
            this.txtKeterangan.Size = new System.Drawing.Size(325, 27);
            this.txtKeterangan.TabIndex = 1;
            this.txtKeterangan.Tag = "keterangan";
            this.txtKeterangan.ThousandSeparator = false;
            this.txtKeterangan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeterangan_KeyPress);
            // 
            // lblReq
            // 
            this.lblReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReq.ForeColor = System.Drawing.Color.Red;
            this.lblReq.Location = new System.Drawing.Point(89, 31);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(11, 20);
            this.lblReq.TabIndex = 4;
            this.lblReq.Text = "*";
            this.lblReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmEntryJabatan
            // 
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSelesai;
            this.ClientSize = new System.Drawing.Size(403, 292);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJabatan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKeterangan);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEntryJabatan";
            this.Text = "FrmEntryJabatan";
            this.Controls.SetChildIndex(this.btnSimpan, 0);
            this.Controls.SetChildIndex(this.txtKeterangan, 0);
            this.Controls.SetChildIndex(this.btnSelesai, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtJabatan, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblReq, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtJabatan;
        private System.Windows.Forms.Label label2;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtKeterangan;
        private System.Windows.Forms.Label lblReq;
    }
}
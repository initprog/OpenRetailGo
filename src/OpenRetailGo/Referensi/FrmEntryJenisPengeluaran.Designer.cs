namespace OpenRetailGo.Referensi
{
    partial class FrmEntryJenisPengeluaran
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
            this.txtJenisPengeluaran = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.lblReq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelesai.Location = new System.Drawing.Point(334, 128);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelesai.Size = new System.Drawing.Size(101, 51);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(202, 128);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Size = new System.Drawing.Size(101, 51);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Pengeluaran";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtJenisPengeluaran
            // 
            this.txtJenisPengeluaran.AutoEnter = false;
            this.txtJenisPengeluaran.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtJenisPengeluaran.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtJenisPengeluaran.LeaveFocusColor = System.Drawing.Color.White;
            this.txtJenisPengeluaran.LetterOnly = false;
            this.txtJenisPengeluaran.Location = new System.Drawing.Point(31, 56);
            this.txtJenisPengeluaran.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJenisPengeluaran.Name = "txtJenisPengeluaran";
            this.txtJenisPengeluaran.NumericOnly = false;
            this.txtJenisPengeluaran.SelectionText = false;
            this.txtJenisPengeluaran.Size = new System.Drawing.Size(403, 27);
            this.txtJenisPengeluaran.TabIndex = 0;
            this.txtJenisPengeluaran.Tag = "nama_jenis_pengeluaran";
            this.txtJenisPengeluaran.ThousandSeparator = false;
            this.txtJenisPengeluaran.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJenisPengeluaran_KeyPress);
            // 
            // lblReq
            // 
            this.lblReq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReq.ForeColor = System.Drawing.Color.Red;
            this.lblReq.Location = new System.Drawing.Point(149, 32);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(11, 20);
            this.lblReq.TabIndex = 4;
            this.lblReq.Text = "*";
            this.lblReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmEntryJenisPengeluaran
            // 
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSelesai;
            this.ClientSize = new System.Drawing.Size(467, 195);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJenisPengeluaran);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEntryJenisPengeluaran";
            this.Text = "FrmEntryJenisPengeluaran";
            this.Controls.SetChildIndex(this.btnSimpan, 0);
            this.Controls.SetChildIndex(this.btnSelesai, 0);
            this.Controls.SetChildIndex(this.txtJenisPengeluaran, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblReq, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtJenisPengeluaran;
        private System.Windows.Forms.Label lblReq;
    }
}
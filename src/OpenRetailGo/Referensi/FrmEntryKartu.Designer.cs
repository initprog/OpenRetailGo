namespace OpenRetailGo.Referensi
{
    partial class FrmEntryKartu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntryKartu));
            this.lblNamaKartu = new System.Windows.Forms.Label();
            this.txtNamaKartu = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.lblJenisKartu = new System.Windows.Forms.Label();
            this.rdoKartuDebit = new System.Windows.Forms.RadioButton();
            this.rdoKartuKredit = new System.Windows.Forms.RadioButton();
            this.lblReq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelesai.Location = new System.Drawing.Point(216, 148);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelesai.Size = new System.Drawing.Size(88, 38);
            this.btnSelesai.TabIndex = 5;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(102, 148);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimpan.Size = new System.Drawing.Size(88, 38);
            this.btnSimpan.TabIndex = 4;
            // 
            // lblNamaKartu
            // 
            this.lblNamaKartu.AutoSize = true;
            this.lblNamaKartu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaKartu.Location = new System.Drawing.Point(25, 17);
            this.lblNamaKartu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamaKartu.Name = "lblNamaKartu";
            this.lblNamaKartu.Size = new System.Drawing.Size(73, 15);
            this.lblNamaKartu.TabIndex = 0;
            this.lblNamaKartu.Text = "Nama Kartu";
            this.lblNamaKartu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNamaKartu
            // 
            this.txtNamaKartu.AutoEnter = true;
            this.txtNamaKartu.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtNamaKartu.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNamaKartu.LeaveFocusColor = System.Drawing.Color.White;
            this.txtNamaKartu.LetterOnly = false;
            this.txtNamaKartu.Location = new System.Drawing.Point(28, 36);
            this.txtNamaKartu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamaKartu.Name = "txtNamaKartu";
            this.txtNamaKartu.NumericOnly = false;
            this.txtNamaKartu.SelectionText = false;
            this.txtNamaKartu.Size = new System.Drawing.Size(276, 23);
            this.txtNamaKartu.TabIndex = 1;
            this.txtNamaKartu.Tag = "nama_golongan";
            this.txtNamaKartu.ThousandSeparator = false;
            // 
            // lblJenisKartu
            // 
            this.lblJenisKartu.AutoSize = true;
            this.lblJenisKartu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisKartu.Location = new System.Drawing.Point(25, 81);
            this.lblJenisKartu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJenisKartu.Name = "lblJenisKartu";
            this.lblJenisKartu.Size = new System.Drawing.Size(34, 15);
            this.lblJenisKartu.TabIndex = 1;
            this.lblJenisKartu.Text = "Jenis";
            this.lblJenisKartu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoKartuDebit
            // 
            this.rdoKartuDebit.AutoSize = true;
            this.rdoKartuDebit.Checked = true;
            this.rdoKartuDebit.Location = new System.Drawing.Point(28, 100);
            this.rdoKartuDebit.Margin = new System.Windows.Forms.Padding(4);
            this.rdoKartuDebit.Name = "rdoKartuDebit";
            this.rdoKartuDebit.Size = new System.Drawing.Size(84, 19);
            this.rdoKartuDebit.TabIndex = 2;
            this.rdoKartuDebit.TabStop = true;
            this.rdoKartuDebit.Text = "Kartu Debit";
            this.rdoKartuDebit.UseVisualStyleBackColor = true;
            // 
            // rdoKartuKredit
            // 
            this.rdoKartuKredit.AutoSize = true;
            this.rdoKartuKredit.Location = new System.Drawing.Point(141, 100);
            this.rdoKartuKredit.Margin = new System.Windows.Forms.Padding(4);
            this.rdoKartuKredit.Name = "rdoKartuKredit";
            this.rdoKartuKredit.Size = new System.Drawing.Size(87, 19);
            this.rdoKartuKredit.TabIndex = 3;
            this.rdoKartuKredit.Text = "Kartu Kredit";
            this.rdoKartuKredit.UseVisualStyleBackColor = true;
            // 
            // lblReq
            // 
            this.lblReq.ForeColor = System.Drawing.Color.Red;
            this.lblReq.Location = new System.Drawing.Point(96, 17);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(10, 15);
            this.lblReq.TabIndex = 2;
            this.lblReq.Text = "*";
            this.lblReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmEntryKartu
            // 
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSelesai;
            this.ClientSize = new System.Drawing.Size(340, 207);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.txtNamaKartu);
            this.Controls.Add(this.lblNamaKartu);
            this.Controls.Add(this.rdoKartuKredit);
            this.Controls.Add(this.rdoKartuDebit);
            this.Controls.Add(this.lblJenisKartu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEntryKartu";
            this.Text = "FrmEntryKartu";
            this.Controls.SetChildIndex(this.btnSimpan, 0);
            this.Controls.SetChildIndex(this.lblJenisKartu, 0);
            this.Controls.SetChildIndex(this.btnSelesai, 0);
            this.Controls.SetChildIndex(this.rdoKartuDebit, 0);
            this.Controls.SetChildIndex(this.rdoKartuKredit, 0);
            this.Controls.SetChildIndex(this.lblNamaKartu, 0);
            this.Controls.SetChildIndex(this.txtNamaKartu, 0);
            this.Controls.SetChildIndex(this.lblReq, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNamaKartu;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtNamaKartu;
        private System.Windows.Forms.Label lblJenisKartu;
        private System.Windows.Forms.RadioButton rdoKartuDebit;
        private System.Windows.Forms.RadioButton rdoKartuKredit;
        private System.Windows.Forms.Label lblReq;
    }
}
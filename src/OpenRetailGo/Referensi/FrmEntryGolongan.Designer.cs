namespace OpenRetailGo.Referensi
{
    partial class FrmEntryGolongan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntryGolongan));
            this.lblGolongan = new System.Windows.Forms.Label();
            this.txtDiskon = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.txtKeuntungan = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.lblKeuntungan = new System.Windows.Forms.Label();
            this.lblDiskon = new System.Windows.Forms.Label();
            this.txtGolongan = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.lblReq = new System.Windows.Forms.Label();
            this.lblTipe = new System.Windows.Forms.Label();
            this.rbBarang = new System.Windows.Forms.RadioButton();
            this.rbJasa = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelesai.Location = new System.Drawing.Point(261, 287);
            this.btnSelesai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelesai.Size = new System.Drawing.Size(101, 51);
            this.btnSelesai.TabIndex = 4;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(125, 287);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Size = new System.Drawing.Size(101, 51);
            this.btnSimpan.TabIndex = 3;
            // 
            // lblGolongan
            // 
            this.lblGolongan.AutoSize = true;
            this.lblGolongan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolongan.Location = new System.Drawing.Point(38, 82);
            this.lblGolongan.Name = "lblGolongan";
            this.lblGolongan.Size = new System.Drawing.Size(77, 20);
            this.lblGolongan.TabIndex = 0;
            this.lblGolongan.Text = "Golongan";
            this.lblGolongan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiskon
            // 
            this.txtDiskon.AutoEnter = false;
            this.txtDiskon.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtDiskon.EnterFocusColor = System.Drawing.Color.White;
            this.txtDiskon.LeaveFocusColor = System.Drawing.Color.White;
            this.txtDiskon.LetterOnly = false;
            this.txtDiskon.Location = new System.Drawing.Point(41, 240);
            this.txtDiskon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiskon.MaxLength = 5;
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.NumericOnly = true;
            this.txtDiskon.SelectionText = false;
            this.txtDiskon.Size = new System.Drawing.Size(68, 27);
            this.txtDiskon.TabIndex = 2;
            this.txtDiskon.Text = "0";
            this.txtDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiskon.ThousandSeparator = false;
            this.txtDiskon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiskon_KeyPress);
            // 
            // txtKeuntungan
            // 
            this.txtKeuntungan.AutoEnter = true;
            this.txtKeuntungan.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtKeuntungan.EnterFocusColor = System.Drawing.Color.White;
            this.txtKeuntungan.LeaveFocusColor = System.Drawing.Color.White;
            this.txtKeuntungan.LetterOnly = false;
            this.txtKeuntungan.Location = new System.Drawing.Point(41, 174);
            this.txtKeuntungan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKeuntungan.MaxLength = 5;
            this.txtKeuntungan.Name = "txtKeuntungan";
            this.txtKeuntungan.NumericOnly = true;
            this.txtKeuntungan.SelectionText = false;
            this.txtKeuntungan.Size = new System.Drawing.Size(68, 27);
            this.txtKeuntungan.TabIndex = 1;
            this.txtKeuntungan.Text = "0";
            this.txtKeuntungan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKeuntungan.ThousandSeparator = false;
            // 
            // lblKeuntungan
            // 
            this.lblKeuntungan.AutoSize = true;
            this.lblKeuntungan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeuntungan.Location = new System.Drawing.Point(38, 150);
            this.lblKeuntungan.Name = "lblKeuntungan";
            this.lblKeuntungan.Size = new System.Drawing.Size(132, 20);
            this.lblKeuntungan.TabIndex = 2;
            this.lblKeuntungan.Text = "Keuntungan (%)  ";
            this.lblKeuntungan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiskon
            // 
            this.lblDiskon.AutoSize = true;
            this.lblDiskon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiskon.Location = new System.Drawing.Point(38, 216);
            this.lblDiskon.Name = "lblDiskon";
            this.lblDiskon.Size = new System.Drawing.Size(86, 20);
            this.lblDiskon.TabIndex = 1;
            this.lblDiskon.Text = "Diskon (%)";
            this.lblDiskon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGolongan
            // 
            this.txtGolongan.AutoEnter = true;
            this.txtGolongan.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtGolongan.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtGolongan.LeaveFocusColor = System.Drawing.Color.White;
            this.txtGolongan.LetterOnly = false;
            this.txtGolongan.Location = new System.Drawing.Point(41, 106);
            this.txtGolongan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGolongan.Name = "txtGolongan";
            this.txtGolongan.NumericOnly = false;
            this.txtGolongan.SelectionText = false;
            this.txtGolongan.Size = new System.Drawing.Size(319, 27);
            this.txtGolongan.TabIndex = 0;
            this.txtGolongan.Tag = "nama_golongan";
            this.txtGolongan.ThousandSeparator = false;
            // 
            // lblReq
            // 
            this.lblReq.ForeColor = System.Drawing.Color.Red;
            this.lblReq.Location = new System.Drawing.Point(113, 82);
            this.lblReq.Name = "lblReq";
            this.lblReq.Size = new System.Drawing.Size(11, 20);
            this.lblReq.TabIndex = 5;
            this.lblReq.Text = "*";
            this.lblReq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipe
            // 
            this.lblTipe.AutoSize = true;
            this.lblTipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipe.Location = new System.Drawing.Point(39, 23);
            this.lblTipe.Name = "lblTipe";
            this.lblTipe.Size = new System.Drawing.Size(39, 20);
            this.lblTipe.TabIndex = 6;
            this.lblTipe.Text = "Tipe";
            this.lblTipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbBarang
            // 
            this.rbBarang.AutoSize = true;
            this.rbBarang.Checked = true;
            this.rbBarang.Location = new System.Drawing.Point(42, 46);
            this.rbBarang.Name = "rbBarang";
            this.rbBarang.Size = new System.Drawing.Size(77, 24);
            this.rbBarang.TabIndex = 7;
            this.rbBarang.TabStop = true;
            this.rbBarang.Text = "Barang";
            this.rbBarang.UseVisualStyleBackColor = true;
            this.rbBarang.CheckedChanged += new System.EventHandler(this.rbBarangJasa_CheckedChanged);
            // 
            // rbJasa
            // 
            this.rbJasa.AutoSize = true;
            this.rbJasa.Location = new System.Drawing.Point(139, 46);
            this.rbJasa.Name = "rbJasa";
            this.rbJasa.Size = new System.Drawing.Size(57, 24);
            this.rbJasa.TabIndex = 8;
            this.rbJasa.Text = "Jasa";
            this.rbJasa.UseVisualStyleBackColor = true;
            this.rbJasa.CheckedChanged += new System.EventHandler(this.rbBarangJasa_CheckedChanged);
            // 
            // FrmEntryGolongan
            // 
            this.AcceptButton = this.btnSimpan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSelesai;
            this.ClientSize = new System.Drawing.Size(395, 349);
            this.Controls.Add(this.rbJasa);
            this.Controls.Add(this.rbBarang);
            this.Controls.Add(this.lblTipe);
            this.Controls.Add(this.lblReq);
            this.Controls.Add(this.txtGolongan);
            this.Controls.Add(this.txtKeuntungan);
            this.Controls.Add(this.txtDiskon);
            this.Controls.Add(this.lblDiskon);
            this.Controls.Add(this.lblKeuntungan);
            this.Controls.Add(this.lblGolongan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEntryGolongan";
            this.Text = "FrmEntryGolongan";
            this.Controls.SetChildIndex(this.lblGolongan, 0);
            this.Controls.SetChildIndex(this.lblKeuntungan, 0);
            this.Controls.SetChildIndex(this.btnSimpan, 0);
            this.Controls.SetChildIndex(this.lblDiskon, 0);
            this.Controls.SetChildIndex(this.txtDiskon, 0);
            this.Controls.SetChildIndex(this.btnSelesai, 0);
            this.Controls.SetChildIndex(this.txtKeuntungan, 0);
            this.Controls.SetChildIndex(this.txtGolongan, 0);
            this.Controls.SetChildIndex(this.lblReq, 0);
            this.Controls.SetChildIndex(this.lblTipe, 0);
            this.Controls.SetChildIndex(this.rbBarang, 0);
            this.Controls.SetChildIndex(this.rbJasa, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGolongan;
        private Helper.UserControl.AdvancedTextbox txtDiskon;
        private Helper.UserControl.AdvancedTextbox txtKeuntungan;
        private System.Windows.Forms.Label lblKeuntungan;
        private System.Windows.Forms.Label lblDiskon;
        private Helper.UserControl.AdvancedTextbox txtGolongan;
        private System.Windows.Forms.Label lblReq;
        private System.Windows.Forms.Label lblTipe;
        private System.Windows.Forms.RadioButton rbBarang;
        private System.Windows.Forms.RadioButton rbJasa;
    }
}
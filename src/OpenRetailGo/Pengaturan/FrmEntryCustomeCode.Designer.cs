namespace OpenRetailGo.Pengaturan
{
    partial class FrmEntryCustomeCode
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomeCode = new OpenRetailGo.Helper.UserControl.AdvancedTextbox();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(275, 78);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(157, 78);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtCustomeCode, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 14);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(366, 40);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomeCode
            // 
            this.txtCustomeCode.AutoEnter = false;
            this.txtCustomeCode.Conversion = OpenRetailGo.Helper.UserControl.EConversion.Normal;
            this.txtCustomeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomeCode.EnterFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCustomeCode.LeaveFocusColor = System.Drawing.Color.White;
            this.txtCustomeCode.LetterOnly = false;
            this.txtCustomeCode.Location = new System.Drawing.Point(56, 5);
            this.txtCustomeCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomeCode.MaxLength = 50;
            this.txtCustomeCode.Name = "txtCustomeCode";
            this.txtCustomeCode.NumericOnly = false;
            this.txtCustomeCode.SelectionText = false;
            this.txtCustomeCode.Size = new System.Drawing.Size(306, 27);
            this.txtCustomeCode.TabIndex = 0;
            this.txtCustomeCode.Tag = "";
            this.txtCustomeCode.ThousandSeparator = false;
            // 
            // FrmEntryCustomeCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 124);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEntryCustomeCode";
            this.Text = "FrmEntryCustomeCode";
            this.Controls.SetChildIndex(this.btnSimpan, 0);
            this.Controls.SetChildIndex(this.btnSelesai, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private OpenRetailGo.Helper.UserControl.AdvancedTextbox txtCustomeCode;
    }
}
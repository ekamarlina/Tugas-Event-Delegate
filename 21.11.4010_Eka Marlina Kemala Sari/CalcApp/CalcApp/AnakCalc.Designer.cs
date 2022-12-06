namespace CalcApp
{
    partial class AnakCalc
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
            this.txtOp = new System.Windows.Forms.ComboBox();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOp
            // 
            this.txtOp.FormattingEnabled = true;
            this.txtOp.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.txtOp.Location = new System.Drawing.Point(76, 30);
            this.txtOp.Name = "txtOp";
            this.txtOp.Size = new System.Drawing.Size(164, 21);
            this.txtOp.TabIndex = 0;
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(76, 67);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiA.TabIndex = 1;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(76, 104);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nilai B";
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(177, 134);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 6;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // AnakCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 169);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.txtOp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnakCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtOp;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProses;
    }
}
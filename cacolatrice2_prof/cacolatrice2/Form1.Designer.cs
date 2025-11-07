namespace cacolatrice2
{
    partial class Form1
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
            this.bPlus = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bDivide = new System.Windows.Forms.Button();
            this.bMoltiply = new System.Windows.Forms.Button();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.lRis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bPlus
            // 
            this.bPlus.Location = new System.Drawing.Point(205, 42);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(75, 23);
            this.bPlus.TabIndex = 0;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMinus
            // 
            this.bMinus.Location = new System.Drawing.Point(205, 82);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(75, 23);
            this.bMinus.TabIndex = 1;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bDivide
            // 
            this.bDivide.Location = new System.Drawing.Point(205, 122);
            this.bDivide.Name = "bDivide";
            this.bDivide.Size = new System.Drawing.Size(75, 23);
            this.bDivide.TabIndex = 2;
            this.bDivide.Text = "/";
            this.bDivide.UseVisualStyleBackColor = true;
            this.bDivide.Click += new System.EventHandler(this.bDivide_Click);
            // 
            // bMoltiply
            // 
            this.bMoltiply.Location = new System.Drawing.Point(205, 166);
            this.bMoltiply.Name = "bMoltiply";
            this.bMoltiply.Size = new System.Drawing.Size(75, 23);
            this.bMoltiply.TabIndex = 3;
            this.bMoltiply.Text = "*";
            this.bMoltiply.UseVisualStyleBackColor = true;
            this.bMoltiply.Click += new System.EventHandler(this.bMoltiply_Click);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(79, 106);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 4;
            this.tbA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(311, 106);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 5;
            this.tbB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lRis
            // 
            this.lRis.AutoSize = true;
            this.lRis.Location = new System.Drawing.Point(480, 109);
            this.lRis.Name = "lRis";
            this.lRis.Size = new System.Drawing.Size(13, 13);
            this.lRis.TabIndex = 6;
            this.lRis.Text = "0";
            this.lRis.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 245);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lRis);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.bMoltiply);
            this.Controls.Add(this.bDivide);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bPlus);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bDivide;
        private System.Windows.Forms.Button bMoltiply;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label lRis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


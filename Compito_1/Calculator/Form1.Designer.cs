namespace Calculator
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btC = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btMoltiply = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btZero = new System.Windows.Forms.Button();
            this.btEqual = new System.Windows.Forms.Button();
            this.btDoubelZero = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.btParentesis = new System.Windows.Forms.Button();
            this.btPercentage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(68, 39);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(178, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(68, 65);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(178, 20);
            this.tbOutput.TabIndex = 1;
            this.tbOutput.TextChanged += new System.EventHandler(this.tbOutput_TextChanged);
            // 
            // btC
            // 
            this.btC.Location = new System.Drawing.Point(68, 104);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(39, 23);
            this.btC.TabIndex = 2;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btDivide
            // 
            this.btDivide.Location = new System.Drawing.Point(214, 104);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(32, 23);
            this.btDivide.TabIndex = 3;
            this.btDivide.Text = "/";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btMoltiply
            // 
            this.btMoltiply.Location = new System.Drawing.Point(214, 134);
            this.btMoltiply.Name = "btMoltiply";
            this.btMoltiply.Size = new System.Drawing.Size(32, 23);
            this.btMoltiply.TabIndex = 4;
            this.btMoltiply.Text = "x";
            this.btMoltiply.UseVisualStyleBackColor = true;
            this.btMoltiply.Click += new System.EventHandler(this.btMoltiply_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(214, 164);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(32, 23);
            this.btMinus.TabIndex = 5;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(214, 193);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(32, 23);
            this.btPlus.TabIndex = 6;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(68, 193);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(39, 23);
            this.bt1.TabIndex = 7;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(68, 164);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(39, 23);
            this.bt4.TabIndex = 8;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt7
            // 
            this.bt7.Location = new System.Drawing.Point(68, 133);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(39, 23);
            this.bt7.TabIndex = 9;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(112, 193);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(37, 23);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(156, 193);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(38, 23);
            this.bt3.TabIndex = 11;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(113, 163);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(36, 23);
            this.bt5.TabIndex = 12;
            this.bt5.TabStop = false;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Location = new System.Drawing.Point(157, 164);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(37, 23);
            this.bt6.TabIndex = 13;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt8
            // 
            this.bt8.Location = new System.Drawing.Point(113, 134);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(36, 23);
            this.bt8.TabIndex = 14;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Location = new System.Drawing.Point(156, 134);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(38, 23);
            this.bt9.TabIndex = 15;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btZero
            // 
            this.btZero.Location = new System.Drawing.Point(68, 223);
            this.btZero.Name = "btZero";
            this.btZero.Size = new System.Drawing.Size(39, 23);
            this.btZero.TabIndex = 16;
            this.btZero.Text = "0";
            this.btZero.UseVisualStyleBackColor = true;
            this.btZero.Click += new System.EventHandler(this.btZero_Click);
            // 
            // btEqual
            // 
            this.btEqual.Location = new System.Drawing.Point(214, 222);
            this.btEqual.Name = "btEqual";
            this.btEqual.Size = new System.Drawing.Size(32, 23);
            this.btEqual.TabIndex = 17;
            this.btEqual.Text = "=";
            this.btEqual.UseVisualStyleBackColor = true;
            this.btEqual.Click += new System.EventHandler(this.btEqual_Click);
            // 
            // btDoubelZero
            // 
            this.btDoubelZero.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDoubelZero.Location = new System.Drawing.Point(113, 223);
            this.btDoubelZero.Name = "btDoubelZero";
            this.btDoubelZero.Size = new System.Drawing.Size(36, 23);
            this.btDoubelZero.TabIndex = 18;
            this.btDoubelZero.Text = "00";
            this.btDoubelZero.UseVisualStyleBackColor = false;
            this.btDoubelZero.Click += new System.EventHandler(this.btDoubelZero_Click);
            // 
            // btDot
            // 
            this.btDot.Location = new System.Drawing.Point(157, 223);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(37, 23);
            this.btDot.TabIndex = 19;
            this.btDot.Text = ".";
            this.btDot.UseVisualStyleBackColor = true;
            this.btDot.Click += new System.EventHandler(this.btDot_Click);
            // 
            // btParentesis
            // 
            this.btParentesis.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btParentesis.Location = new System.Drawing.Point(114, 104);
            this.btParentesis.Name = "btParentesis";
            this.btParentesis.Size = new System.Drawing.Size(35, 23);
            this.btParentesis.TabIndex = 20;
            this.btParentesis.Text = "( )";
            this.btParentesis.UseVisualStyleBackColor = false;
            // 
            // btPercentage
            // 
            this.btPercentage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btPercentage.Location = new System.Drawing.Point(157, 104);
            this.btPercentage.Name = "btPercentage";
            this.btPercentage.Size = new System.Drawing.Size(37, 23);
            this.btPercentage.TabIndex = 21;
            this.btPercentage.Text = "%";
            this.btPercentage.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 315);
            this.Controls.Add(this.btPercentage);
            this.Controls.Add(this.btParentesis);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.btDoubelZero);
            this.Controls.Add(this.btEqual);
            this.Controls.Add(this.btZero);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btMoltiply);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btMoltiply;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btZero;
        private System.Windows.Forms.Button btEqual;
        private System.Windows.Forms.Button btDoubelZero;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.Button btParentesis;
        private System.Windows.Forms.Button btPercentage;
    }
}


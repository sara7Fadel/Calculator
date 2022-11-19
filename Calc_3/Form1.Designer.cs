namespace Calc_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonClearEntery = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(134, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 33);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonNum7
            // 
            this.buttonNum7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum7.Location = new System.Drawing.Point(69, 100);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(70, 70);
            this.buttonNum7.TabIndex = 1;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = false;
            this.buttonNum7.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum8.Location = new System.Drawing.Point(191, 100);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(70, 70);
            this.buttonNum8.TabIndex = 2;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = false;
            this.buttonNum8.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum9.Location = new System.Drawing.Point(324, 100);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(70, 70);
            this.buttonNum9.TabIndex = 3;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = false;
            this.buttonNum9.Click += new System.EventHandler(this.button_click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDivide.Location = new System.Drawing.Point(447, 100);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(70, 70);
            this.buttonDivide.TabIndex = 4;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.operator_button);
            // 
            // buttonClearEntery
            // 
            this.buttonClearEntery.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonClearEntery.Location = new System.Drawing.Point(556, 100);
            this.buttonClearEntery.Name = "buttonClearEntery";
            this.buttonClearEntery.Size = new System.Drawing.Size(70, 70);
            this.buttonClearEntery.TabIndex = 5;
            this.buttonClearEntery.Text = "CE";
            this.buttonClearEntery.UseVisualStyleBackColor = false;
            this.buttonClearEntery.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonClear.Location = new System.Drawing.Point(556, 192);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 70);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMultiply.Location = new System.Drawing.Point(447, 192);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(70, 70);
            this.buttonMultiply.TabIndex = 9;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.operator_button);
            // 
            // buttonNum6
            // 
            this.buttonNum6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum6.Location = new System.Drawing.Point(324, 192);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(70, 70);
            this.buttonNum6.TabIndex = 8;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = false;
            this.buttonNum6.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum5.Location = new System.Drawing.Point(191, 192);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(70, 70);
            this.buttonNum5.TabIndex = 7;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = false;
            this.buttonNum5.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum4.Location = new System.Drawing.Point(69, 192);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(70, 70);
            this.buttonNum4.TabIndex = 6;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = false;
            this.buttonNum4.Click += new System.EventHandler(this.button_click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMinus.Location = new System.Drawing.Point(447, 277);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(70, 70);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.operator_button);
            // 
            // buttonNum3
            // 
            this.buttonNum3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum3.Location = new System.Drawing.Point(324, 286);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(70, 70);
            this.buttonNum3.TabIndex = 13;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = false;
            this.buttonNum3.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum2.Location = new System.Drawing.Point(191, 286);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(70, 70);
            this.buttonNum2.TabIndex = 12;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = false;
            this.buttonNum2.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNum1
            // 
            this.buttonNum1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum1.Location = new System.Drawing.Point(69, 286);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(70, 70);
            this.buttonNum1.TabIndex = 11;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = false;
            this.buttonNum1.Click += new System.EventHandler(this.button_click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonEqual.Location = new System.Drawing.Point(556, 278);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(70, 160);
            this.buttonEqual.TabIndex = 20;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.End_button);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPlus.Location = new System.Drawing.Point(447, 368);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(70, 70);
            this.buttonPlus.TabIndex = 19;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.operator_button);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPoint.Location = new System.Drawing.Point(324, 368);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(70, 70);
            this.buttonPoint.TabIndex = 18;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.button_click);
            // 
            // buttonNum0
            // 
            this.buttonNum0.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNum0.Location = new System.Drawing.Point(69, 368);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(200, 70);
            this.buttonNum0.TabIndex = 16;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = false;
            this.buttonNum0.Click += new System.EventHandler(this.button_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEqual);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonNum0);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonNum3);
            this.Controls.Add(this.buttonNum2);
            this.Controls.Add(this.buttonNum1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonNum6);
            this.Controls.Add(this.buttonNum5);
            this.Controls.Add(this.buttonNum4);
            this.Controls.Add(this.buttonClearEntery);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonNum9);
            this.Controls.Add(this.buttonNum8);
            this.Controls.Add(this.buttonNum7);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculator";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonNum9;
        private TextBox textBox1;
        private Button buttonNum7;
        private Button buttonNum8;
        private Button buttonDivide;
        private Button buttonClearEntery;
        private Button buttonClear;
        private Button buttonMultiply;
        private Button buttonNum6;
        private Button buttonNum5;
        private Button buttonNum4;
        private Button buttonMinus;
        private Button buttonNum3;
        private Button buttonNum2;
        private Button buttonNum1;
        private Button buttonEqual;
        private Button buttonPlus;
        private Button buttonPoint;
        private Button buttonNum0;
        private Label label1;
    }
}
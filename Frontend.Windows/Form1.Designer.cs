namespace Frontend.Windows
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
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDot = new Button();
            btn0 = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnResult = new Button();
            btnCloseParenthesis = new Button();
            btnOpenParenthesis = new Button();
            btnpow = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(0, 64, 0);
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(30, 13);
            txtDisplay.Margin = new Padding(4);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(1868, 171);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(57, 237);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(208, 164);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(304, 237);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(208, 164);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(598, 237);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(208, 164);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(598, 456);
            btn6.Margin = new Padding(9);
            btn6.Name = "btn6";
            btn6.Size = new Size(208, 192);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(304, 456);
            btn5.Margin = new Padding(9);
            btn5.Name = "btn5";
            btn5.Size = new Size(208, 200);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(57, 464);
            btn4.Margin = new Padding(9);
            btn4.Name = "btn4";
            btn4.Size = new Size(208, 192);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button6_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(598, 706);
            btn3.Margin = new Padding(9);
            btn3.Name = "btn3";
            btn3.Size = new Size(208, 192);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(304, 706);
            btn2.Margin = new Padding(9);
            btn2.Name = "btn2";
            btn2.Size = new Size(208, 192);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(57, 706);
            btn1.Margin = new Padding(9);
            btn1.Name = "btn1";
            btn1.Size = new Size(208, 192);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(598, 929);
            btnDot.Margin = new Padding(9);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(208, 192);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += button10_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(59, 929);
            btn0.Margin = new Padding(9);
            btn0.Name = "btn0";
            btn0.Size = new Size(453, 192);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(1244, 460);
            btnMinus.Margin = new Padding(9);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(208, 192);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(954, 464);
            btnPlus.Margin = new Padding(9);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(208, 192);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiply.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(1244, 226);
            btnMultiply.Margin = new Padding(9);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(208, 164);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(954, 226);
            btnDivide.Margin = new Padding(4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(208, 164);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.FromArgb(255, 128, 0);
            btnResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(943, 929);
            btnResult.Margin = new Padding(9);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(955, 192);
            btnResult.TabIndex = 19;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCloseParenthesis.Location = new Point(1244, 706);
            btnCloseParenthesis.Margin = new Padding(9);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(217, 192);
            btnCloseParenthesis.TabIndex = 18;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += button17_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpenParenthesis.Location = new Point(954, 706);
            btnOpenParenthesis.Margin = new Padding(9);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(208, 192);
            btnOpenParenthesis.TabIndex = 17;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += button18_Click;
            // 
            // btnpow
            // 
            btnpow.BackColor = Color.FromArgb(255, 128, 0);
            btnpow.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpow.Location = new Point(1562, 706);
            btnpow.Margin = new Padding(4);
            btnpow.Name = "btnpow";
            btnpow.Size = new Size(336, 192);
            btnpow.TabIndex = 16;
            btnpow.Text = "^";
            btnpow.UseVisualStyleBackColor = false;
            btnpow.Click += button19_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1562, 456);
            btnClear.Margin = new Padding(9);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(336, 192);
            btnClear.TabIndex = 21;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1562, 226);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(336, 164);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1924, 1213);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnResult);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnpow);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "fuctions evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDot;
        private Button btn0;
        private Button btnMinus;
        private Button btnPlus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnResult;
        private Button btnCloseParenthesis;
        private Button btnOpenParenthesis;
        private Button btnpow;
        private Button btnClear;
        private Button btnDelete;
    }
}

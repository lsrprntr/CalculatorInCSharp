using System.Reflection.Emit;

namespace CalculatorInCSharp
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonEqu = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(62, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(113, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(11, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(62, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(113, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(11, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(62, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(113, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(12, 250);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(95, 45);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(113, 250);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(45, 45);
            this.buttonDot.TabIndex = 10;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSub.Location = new System.Drawing.Point(164, 148);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(45, 45);
            this.buttonSub.TabIndex = 11;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(164, 97);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(45, 45);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonMul
            // 
            this.buttonMul.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMul.Location = new System.Drawing.Point(164, 199);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(45, 45);
            this.buttonMul.TabIndex = 13;
            this.buttonMul.Text = "*";
            this.buttonMul.UseVisualStyleBackColor = true;
            this.buttonMul.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiv.Location = new System.Drawing.Point(164, 250);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(45, 45);
            this.buttonDiv.TabIndex = 14;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.operator_click);
            // 
            // buttonEqu
            // 
            this.buttonEqu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqu.Location = new System.Drawing.Point(215, 199);
            this.buttonEqu.Name = "buttonEqu";
            this.buttonEqu.Size = new System.Drawing.Size(45, 95);
            this.buttonEqu.TabIndex = 15;
            this.buttonEqu.Text = "=";
            this.buttonEqu.UseVisualStyleBackColor = true;
            this.buttonEqu.Click += new System.EventHandler(this.buttonEqu_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearEntry.Location = new System.Drawing.Point(215, 97);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(45, 45);
            this.buttonClearEntry.TabIndex = 16;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = true;
            this.buttonClearEntry.Click += new System.EventHandler(this.buttonClearEntry_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(215, 148);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(45, 45);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 49);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(273, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonEqu);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMul;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonEqu;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}


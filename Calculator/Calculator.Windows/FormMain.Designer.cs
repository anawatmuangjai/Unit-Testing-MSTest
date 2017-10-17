namespace Calculator.Windows
{
    partial class FormMain
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
            this.ButtonDevide = new System.Windows.Forms.Button();
            this.TextBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.TextBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonDevide
            // 
            this.ButtonDevide.Location = new System.Drawing.Point(119, 119);
            this.ButtonDevide.Name = "ButtonDevide";
            this.ButtonDevide.Size = new System.Drawing.Size(79, 26);
            this.ButtonDevide.TabIndex = 0;
            this.ButtonDevide.Text = "Devide";
            this.ButtonDevide.UseVisualStyleBackColor = true;
            this.ButtonDevide.Click += new System.EventHandler(this.ButtonDevide_Click);
            // 
            // TextBoxFirstNumber
            // 
            this.TextBoxFirstNumber.Location = new System.Drawing.Point(119, 20);
            this.TextBoxFirstNumber.Name = "TextBoxFirstNumber";
            this.TextBoxFirstNumber.Size = new System.Drawing.Size(79, 20);
            this.TextBoxFirstNumber.TabIndex = 1;
            // 
            // TextBoxSecondNumber
            // 
            this.TextBoxSecondNumber.Location = new System.Drawing.Point(119, 46);
            this.TextBoxSecondNumber.Name = "TextBoxSecondNumber";
            this.TextBoxSecondNumber.Size = new System.Drawing.Size(79, 20);
            this.TextBoxSecondNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Second Number";
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(25, 84);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(79, 26);
            this.ButtonPlus.TabIndex = 7;
            this.ButtonPlus.Text = "Plus";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(119, 84);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(79, 26);
            this.ButtonMinus.TabIndex = 8;
            this.ButtonMinus.Text = "Minus";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Location = new System.Drawing.Point(25, 119);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(79, 26);
            this.ButtonMultiply.TabIndex = 9;
            this.ButtonMultiply.Text = "Multiply";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Location = new System.Drawing.Point(119, 159);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.Size = new System.Drawing.Size(79, 20);
            this.TextBoxResult.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Calculated Result";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 202);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxSecondNumber);
            this.Controls.Add(this.TextBoxFirstNumber);
            this.Controls.Add(this.ButtonDevide);
            this.Name = "FormMain";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDevide;
        private System.Windows.Forms.TextBox TextBoxFirstNumber;
        private System.Windows.Forms.TextBox TextBoxSecondNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label label3;
    }
}


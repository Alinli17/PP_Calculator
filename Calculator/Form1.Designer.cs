namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.whole = new System.Windows.Forms.TextBox();
            this.numerator = new System.Windows.Forms.TextBox();
            this.denominator = new System.Windows.Forms.TextBox();
            this.rez = new System.Windows.Forms.RichTextBox();
            this.Amount = new System.Windows.Forms.Button();
            this.Difference = new System.Windows.Forms.Button();
            this.Composition = new System.Windows.Forms.Button();
            this.Private = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.TextBox();
            this.drob = new System.Windows.Forms.Label();
            this.headline = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.stepen = new System.Windows.Forms.Label();
            this.tseloye = new System.Windows.Forms.Label();
            this.Rezult = new System.Windows.Forms.GroupBox();
            this.Rezult.SuspendLayout();
            this.SuspendLayout();
            // 
            // whole
            // 
            this.whole.Location = new System.Drawing.Point(29, 84);
            this.whole.Name = "whole";
            this.whole.Size = new System.Drawing.Size(100, 22);
            this.whole.TabIndex = 0;
            this.whole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numerator
            // 
            this.numerator.Location = new System.Drawing.Point(136, 61);
            this.numerator.Name = "numerator";
            this.numerator.Size = new System.Drawing.Size(100, 22);
            this.numerator.TabIndex = 1;
            this.numerator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // denominator
            // 
            this.denominator.Location = new System.Drawing.Point(136, 105);
            this.denominator.Name = "denominator";
            this.denominator.Size = new System.Drawing.Size(100, 22);
            this.denominator.TabIndex = 2;
            this.denominator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rez
            // 
            this.rez.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rez.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rez.Location = new System.Drawing.Point(21, 29);
            this.rez.Name = "rez";
            this.rez.ReadOnly = true;
            this.rez.Size = new System.Drawing.Size(357, 252);
            this.rez.TabIndex = 3;
            this.rez.Text = "";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(439, 38);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(141, 38);
            this.Amount.TabIndex = 4;
            this.Amount.Text = "+";
            this.Amount.UseVisualStyleBackColor = true;
            this.Amount.Click += new System.EventHandler(this.Amount_Click);
            // 
            // Difference
            // 
            this.Difference.Location = new System.Drawing.Point(439, 84);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(141, 38);
            this.Difference.TabIndex = 5;
            this.Difference.Text = "-";
            this.Difference.UseVisualStyleBackColor = true;
            this.Difference.Click += new System.EventHandler(this.Difference_Click);
            // 
            // Composition
            // 
            this.Composition.Location = new System.Drawing.Point(439, 133);
            this.Composition.Name = "Composition";
            this.Composition.Size = new System.Drawing.Size(141, 38);
            this.Composition.TabIndex = 6;
            this.Composition.Text = "*";
            this.Composition.UseVisualStyleBackColor = true;
            this.Composition.Click += new System.EventHandler(this.Composition_Click);
            // 
            // Private
            // 
            this.Private.Location = new System.Drawing.Point(439, 181);
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(141, 38);
            this.Private.TabIndex = 7;
            this.Private.Text = "/";
            this.Private.UseVisualStyleBackColor = true;
            this.Private.Click += new System.EventHandler(this.Private_Click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(439, 232);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(141, 38);
            this.Sqrt.TabIndex = 8;
            this.Sqrt.Text = "√";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Sqrt_Click);
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(439, 280);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(141, 38);
            this.Power.TabIndex = 9;
            this.Power.Text = "^";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.Power_Click);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(439, 329);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(141, 38);
            this.Result.TabIndex = 10;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(440, 378);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(141, 38);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // pow
            // 
            this.pow.Enabled = false;
            this.pow.Location = new System.Drawing.Point(242, 39);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(97, 22);
            this.pow.TabIndex = 12;
            // 
            // drob
            // 
            this.drob.AutoSize = true;
            this.drob.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drob.Location = new System.Drawing.Point(156, 38);
            this.drob.Name = "drob";
            this.drob.Size = new System.Drawing.Size(57, 19);
            this.drob.TabIndex = 13;
            this.drob.Text = "Дробь";
            // 
            // headline
            // 
            this.headline.AutoSize = true;
            this.headline.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headline.Location = new System.Drawing.Point(25, 9);
            this.headline.Name = "headline";
            this.headline.Size = new System.Drawing.Size(314, 23);
            this.headline.TabIndex = 14;
            this.headline.Text = "Калькулятор для расчета дробей:";
            // 
            // line
            // 
            this.line.AutoSize = true;
            this.line.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.line.Location = new System.Drawing.Point(128, 62);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(120, 55);
            this.line.TabIndex = 15;
            this.line.Text = "––––";
            // 
            // stepen
            // 
            this.stepen.AutoSize = true;
            this.stepen.Location = new System.Drawing.Point(347, 42);
            this.stepen.Name = "stepen";
            this.stepen.Size = new System.Drawing.Size(73, 17);
            this.stepen.TabIndex = 16;
            this.stepen.Text = "(Степень)";
            // 
            // tseloye
            // 
            this.tseloye.AutoSize = true;
            this.tseloye.Location = new System.Drawing.Point(28, 61);
            this.tseloye.Name = "tseloye";
            this.tseloye.Size = new System.Drawing.Size(102, 17);
            this.tseloye.TabIndex = 17;
            this.tseloye.Text = "(Целая часть)";
            // 
            // Rezult
            // 
            this.Rezult.Controls.Add(this.rez);
            this.Rezult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rezult.Location = new System.Drawing.Point(29, 133);
            this.Rezult.Name = "Rezult";
            this.Rezult.Size = new System.Drawing.Size(384, 305);
            this.Rezult.TabIndex = 18;
            this.Rezult.TabStop = false;
            this.Rezult.Text = "Решение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.tseloye);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.Composition);
            this.Controls.Add(this.Private);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.stepen);
            this.Controls.Add(this.headline);
            this.Controls.Add(this.drob);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.denominator);
            this.Controls.Add(this.numerator);
            this.Controls.Add(this.whole);
            this.Controls.Add(this.line);
            this.Controls.Add(this.Rezult);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Rezult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox whole;
        private System.Windows.Forms.TextBox numerator;
        private System.Windows.Forms.TextBox denominator;
        private System.Windows.Forms.RichTextBox rez;
        private System.Windows.Forms.Button Amount;
        private System.Windows.Forms.Button Difference;
        private System.Windows.Forms.Button Composition;
        private System.Windows.Forms.Button Private;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox pow;
        private System.Windows.Forms.Label drob;
        private System.Windows.Forms.Label headline;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label stepen;
        private System.Windows.Forms.Label tseloye;
        private System.Windows.Forms.GroupBox Rezult;
    }
}


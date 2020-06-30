namespace lab4
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
            this.label = new System.Windows.Forms.Label();
            this.ss1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ss2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(82, 2);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(192, 54);
            this.label.TabIndex = 0;
            this.label.Text = "Перевод из";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ss1
            // 
            this.ss1.Location = new System.Drawing.Point(69, 59);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(52, 20);
            this.ss1.TabIndex = 1;
            this.ss1.TextChanged += new System.EventHandler(this.ss1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "- ной          в";
            // 
            // ss2
            // 
            this.ss2.Location = new System.Drawing.Point(213, 59);
            this.ss2.Name = "ss2";
            this.ss2.Size = new System.Drawing.Size(52, 20);
            this.ss2.TabIndex = 3;
            this.ss2.TextChanged += new System.EventHandler(this.ss2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "- ную";
            // 
            // inp
            // 
            this.inp.Location = new System.Drawing.Point(118, 101);
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(147, 20);
            this.inp.TabIndex = 5;
            this.inp.TextChanged += new System.EventHandler(this.inp_TextChanged);
            this.inp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inp_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ваше число: ";
            // 
            // outp
            // 
            this.outp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outp.Location = new System.Drawing.Point(120, 137);
            this.outp.Name = "outp";
            this.outp.ReadOnly = true;
            this.outp.Size = new System.Drawing.Size(144, 18);
            this.outp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(343, 177);
            this.Controls.Add(this.inp);
            this.Controls.Add(this.outp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ss2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ss1);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Системы счисления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox ss1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ss2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outp;
        private System.Windows.Forms.Label label4;
    }
}


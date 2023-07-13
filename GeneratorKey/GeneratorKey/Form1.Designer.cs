
namespace GeneratorKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Generic = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxParol = new System.Windows.Forms.CheckBox();
            this.checkBoxText = new System.Windows.Forms.CheckBox();
            this.succes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generic
            // 
            this.Generic.BackColor = System.Drawing.Color.MintCream;
            this.Generic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generic.Location = new System.Drawing.Point(41, 77);
            this.Generic.Name = "Generic";
            this.Generic.Size = new System.Drawing.Size(154, 40);
            this.Generic.TabIndex = 0;
            this.Generic.Text = "Генерировать";
            this.Generic.UseVisualStyleBackColor = false;
            this.Generic.Click += new System.EventHandler(this.Generic_Click);
            this.Generic.MouseEnter += new System.EventHandler(this.Generic_MouseEnter);
            this.Generic.MouseLeave += new System.EventHandler(this.Generic_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(235, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(553, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = global::GeneratorKey.Properties.Resources._1671773236_3_52;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес загрузки ключа:";
            // 
            // checkBoxParol
            // 
            this.checkBoxParol.AutoSize = true;
            this.checkBoxParol.BackgroundImage = global::GeneratorKey.Properties.Resources._1671773236_3_52;
            this.checkBoxParol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxParol.Location = new System.Drawing.Point(235, 65);
            this.checkBoxParol.Name = "checkBoxParol";
            this.checkBoxParol.Size = new System.Drawing.Size(145, 26);
            this.checkBoxParol.TabIndex = 4;
            this.checkBoxParol.Text = "Для паролей ";
            this.checkBoxParol.UseVisualStyleBackColor = true;
            this.checkBoxParol.CheckedChanged += new System.EventHandler(this.checkBoxParol_CheckedChanged);
            // 
            // checkBoxText
            // 
            this.checkBoxText.AutoSize = true;
            this.checkBoxText.BackgroundImage = global::GeneratorKey.Properties.Resources._1671773236_3_52;
            this.checkBoxText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxText.Location = new System.Drawing.Point(235, 97);
            this.checkBoxText.Name = "checkBoxText";
            this.checkBoxText.Size = new System.Drawing.Size(125, 26);
            this.checkBoxText.TabIndex = 5;
            this.checkBoxText.Text = "Для текста";
            this.checkBoxText.UseVisualStyleBackColor = true;
            this.checkBoxText.CheckedChanged += new System.EventHandler(this.checkBoxText_CheckedChanged);
            // 
            // succes
            // 
            this.succes.AutoSize = true;
            this.succes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.succes.Image = global::GeneratorKey.Properties.Resources._1671773236_3_52;
            this.succes.Location = new System.Drawing.Point(448, 86);
            this.succes.Name = "succes";
            this.succes.Size = new System.Drawing.Size(0, 22);
            this.succes.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(658, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Памятка!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeneratorKey.Properties.Resources._1671773236_3_52;
            this.ClientSize = new System.Drawing.Size(820, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.succes);
            this.Controls.Add(this.checkBoxText);
            this.Controls.Add(this.checkBoxParol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Generic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Генератор ключей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generic;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxParol;
        private System.Windows.Forms.CheckBox checkBoxText;
        private System.Windows.Forms.Label succes;
        private System.Windows.Forms.Button button1;
    }
}


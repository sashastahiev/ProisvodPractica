
namespace Shifrator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Kodirovka = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.words = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.symbol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Pouth = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kodirovka
            // 
            this.Kodirovka.BackColor = System.Drawing.Color.MintCream;
            this.Kodirovka.Cursor = System.Windows.Forms.Cursors.Default;
            this.Kodirovka.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Kodirovka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Kodirovka.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Kodirovka.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kodirovka.Location = new System.Drawing.Point(12, 58);
            this.Kodirovka.Name = "Kodirovka";
            this.Kodirovka.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Kodirovka.Size = new System.Drawing.Size(322, 39);
            this.Kodirovka.TabIndex = 2;
            this.Kodirovka.Text = "Шифровать/Расшифровать";
            this.Kodirovka.UseVisualStyleBackColor = false;
            this.Kodirovka.Click += new System.EventHandler(this.Kodirovka_Click);
            this.Kodirovka.MouseEnter += new System.EventHandler(this.Kodirovka_MouseEnter);
            this.Kodirovka.MouseLeave += new System.EventHandler(this.Kodirovka_MouseLeave);
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.Color.Azure;
            this.textbox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox1.Location = new System.Drawing.Point(12, 109);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textbox1.Size = new System.Drawing.Size(460, 453);
            this.textbox1.TabIndex = 5;
            this.textbox1.Text = "Box1";
            this.textbox1.Click += new System.EventHandler(this.textbox1_Click);
            // 
            // textbox2
            // 
            this.textbox2.BackColor = System.Drawing.Color.Azure;
            this.textbox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox2.Location = new System.Drawing.Point(564, 109);
            this.textbox2.Multiline = true;
            this.textbox2.Name = "textbox2";
            this.textbox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textbox2.Size = new System.Drawing.Size(460, 453);
            this.textbox2.TabIndex = 6;
            this.textbox2.Text = "Box2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MintCream;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(877, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "Очистить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(374, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Image = global::Shifrator.Properties.Resources._1671773236_3_52;
            this.label3.Location = new System.Drawing.Point(798, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Кол-во слов:";
            // 
            // words
            // 
            this.words.BackColor = System.Drawing.Color.Azure;
            this.words.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.words.Location = new System.Drawing.Point(930, 66);
            this.words.Multiline = true;
            this.words.Name = "words";
            this.words.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.words.Size = new System.Drawing.Size(94, 28);
            this.words.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Image = global::Shifrator.Properties.Resources._1671773236_3_52;
            this.label4.Location = new System.Drawing.Point(522, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Кол-во символов:";
            // 
            // symbol
            // 
            this.symbol.BackColor = System.Drawing.Color.Azure;
            this.symbol.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.symbol.Location = new System.Drawing.Point(698, 66);
            this.symbol.Multiline = true;
            this.symbol.Name = "symbol";
            this.symbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.symbol.Size = new System.Drawing.Size(94, 28);
            this.symbol.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Image = global::Shifrator.Properties.Resources._1671773236_3_52;
            this.label5.Location = new System.Drawing.Point(340, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Время:";
            // 
            // tim
            // 
            this.tim.BackColor = System.Drawing.Color.Azure;
            this.tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tim.Location = new System.Drawing.Point(416, 66);
            this.tim.Multiline = true;
            this.tim.Name = "tim";
            this.tim.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tim.Size = new System.Drawing.Size(94, 28);
            this.tim.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Image = global::Shifrator.Properties.Resources._1671773236_3_52;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Путь до ключа (адрес):";
            // 
            // Pouth
            // 
            this.Pouth.BackColor = System.Drawing.Color.Azure;
            this.Pouth.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pouth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Pouth.Location = new System.Drawing.Point(224, 21);
            this.Pouth.Multiline = true;
            this.Pouth.Name = "Pouth";
            this.Pouth.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Pouth.Size = new System.Drawing.Size(800, 28);
            this.Pouth.TabIndex = 21;
            this.Pouth.Click += new System.EventHandler(this.Pouth_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(444, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 22;
            this.button1.Text = "Памятка!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.MintCream;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(478, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 40);
            this.button4.TabIndex = 23;
            this.button4.Text = "< >";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shifrator.Properties.Resources._1671773236_3_52;
            this.ClientSize = new System.Drawing.Size(1036, 620);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pouth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.words);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.Kodirovka);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Шифратор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Kodirovka;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox words;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox symbol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Pouth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}


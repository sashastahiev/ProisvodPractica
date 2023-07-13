
namespace GeneratorParol
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pouth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldparol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newparol = new System.Windows.Forms.TextBox();
            this.Shifr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.succes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес ключа:";
            // 
            // Pouth
            // 
            this.Pouth.BackColor = System.Drawing.Color.Azure;
            this.Pouth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pouth.Location = new System.Drawing.Point(159, 33);
            this.Pouth.Name = "Pouth";
            this.Pouth.Size = new System.Drawing.Size(549, 30);
            this.Pouth.TabIndex = 1;
            this.Pouth.Click += new System.EventHandler(this.Pouth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(27, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новый/старый пароль:";
            // 
            // oldparol
            // 
            this.oldparol.BackColor = System.Drawing.Color.Azure;
            this.oldparol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldparol.Location = new System.Drawing.Point(254, 88);
            this.oldparol.Name = "oldparol";
            this.oldparol.Size = new System.Drawing.Size(187, 30);
            this.oldparol.TabIndex = 3;
            this.oldparol.Click += new System.EventHandler(this.oldparol_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(27, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Зашифрованный пароль:";
            // 
            // newparol
            // 
            this.newparol.BackColor = System.Drawing.Color.Azure;
            this.newparol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newparol.Location = new System.Drawing.Point(268, 140);
            this.newparol.Name = "newparol";
            this.newparol.Size = new System.Drawing.Size(187, 30);
            this.newparol.TabIndex = 5;
            // 
            // Shifr
            // 
            this.Shifr.BackColor = System.Drawing.Color.MintCream;
            this.Shifr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Shifr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shifr.Location = new System.Drawing.Point(539, 84);
            this.Shifr.Name = "Shifr";
            this.Shifr.Size = new System.Drawing.Size(169, 37);
            this.Shifr.TabIndex = 6;
            this.Shifr.Text = "Зашифровать!";
            this.Shifr.UseVisualStyleBackColor = false;
            this.Shifr.Click += new System.EventHandler(this.Shifr_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(567, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Памятка!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // succes
            // 
            this.succes.AutoSize = true;
            this.succes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.succes.Image = ((System.Drawing.Image)(resources.GetObject("succes.Image")));
            this.succes.Location = new System.Drawing.Point(461, 143);
            this.succes.Name = "succes";
            this.succes.Size = new System.Drawing.Size(0, 22);
            this.succes.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GeneratorParol.Properties.Resources._1671773236_3_52;
            this.ClientSize = new System.Drawing.Size(720, 198);
            this.Controls.Add(this.succes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Shifr);
            this.Controls.Add(this.newparol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oldparol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pouth);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Генератор паролей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pouth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldparol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newparol;
        private System.Windows.Forms.Button Shifr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label succes;
    }
}


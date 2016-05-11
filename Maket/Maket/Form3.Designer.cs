namespace Maket
{
     partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vegetables = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fruits = new System.Windows.Forms.ComboBox();
            this.meat = new System.Windows.Forms.ComboBox();
            this.milk = new System.Windows.Forms.ComboBox();
            this.other = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите категорию продуктов\r\n                и сам продукт";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Овощи",
            "Фрукты",
            "Мясо",
            "Молочка",
            "Другое"});
            this.comboBox1.Location = new System.Drawing.Point(21, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Категория";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // vegetables
            // 
            this.vegetables.FormattingEnabled = true;
            this.vegetables.Items.AddRange(new object[] {
            "Картофель",
            "Капуста",
            "Морковь",
            "Лук"});
            this.vegetables.Location = new System.Drawing.Point(21, 116);
            this.vegetables.Name = "vegetables";
            this.vegetables.Size = new System.Drawing.Size(121, 21);
            this.vegetables.TabIndex = 5;
            this.vegetables.Text = "Продукт";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(210, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "В холодильник";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Вы выбрали:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fruits
            // 
            this.fruits.FormattingEnabled = true;
            this.fruits.Items.AddRange(new object[] {
            "Яблоки",
            "Груши",
            "Апельсины",
            "Мандарины"});
            this.fruits.Location = new System.Drawing.Point(21, 116);
            this.fruits.Name = "fruits";
            this.fruits.Size = new System.Drawing.Size(121, 21);
            this.fruits.TabIndex = 9;
            this.fruits.Text = "Продукт";
            this.fruits.Visible = false;
            // 
            // meat
            // 
            this.meat.FormattingEnabled = true;
            this.meat.Items.AddRange(new object[] {
            "Мясо",
            "Рыба",
            "Человек"});
            this.meat.Location = new System.Drawing.Point(21, 116);
            this.meat.Name = "meat";
            this.meat.Size = new System.Drawing.Size(121, 21);
            this.meat.TabIndex = 10;
            this.meat.Text = "Продукт";
            this.meat.Visible = false;
            // 
            // milk
            // 
            this.milk.FormattingEnabled = true;
            this.milk.Items.AddRange(new object[] {
            "Молоко",
            "Кефир",
            "Сгущенка"});
            this.milk.Location = new System.Drawing.Point(21, 116);
            this.milk.Name = "milk";
            this.milk.Size = new System.Drawing.Size(121, 21);
            this.milk.TabIndex = 11;
            this.milk.Text = "Продукт";
            this.milk.Visible = false;
            // 
            // other
            // 
            this.other.FormattingEnabled = true;
            this.other.Items.AddRange(new object[] {
            "Яйца",
            "Грибы",
            "Слизь"});
            this.other.Location = new System.Drawing.Point(21, 116);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(121, 21);
            this.other.TabIndex = 12;
            this.other.Text = "Продукт";
            this.other.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(388, 308);
            this.Controls.Add(this.other);
            this.Controls.Add(this.milk);
            this.Controls.Add(this.meat);
            this.Controls.Add(this.fruits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vegetables);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.ComboBox comboBox1;
          private System.Windows.Forms.ComboBox vegetables;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.ComboBox fruits;
          private System.Windows.Forms.ComboBox meat;
          private System.Windows.Forms.ComboBox milk;
          private System.Windows.Forms.ComboBox other;
     }
}
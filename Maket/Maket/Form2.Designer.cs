﻿namespace Maket
{
     partial class Form2
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
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.listBox1 = new System.Windows.Forms.ListBox();
               this.button4 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.button1.Location = new System.Drawing.Point(680, 34);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(128, 40);
               this.button1.TabIndex = 1;
               this.button1.Text = "Добавить";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.button2.Location = new System.Drawing.Point(680, 124);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(128, 40);
               this.button2.TabIndex = 2;
               this.button2.Text = "Удалить";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.button3.Location = new System.Drawing.Point(655, 303);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(185, 40);
               this.button3.TabIndex = 3;
               this.button3.Text = "Подобрать рецепт";
               this.button3.UseVisualStyleBackColor = false;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // listBox1
               // 
               this.listBox1.BackColor = System.Drawing.Color.White;
               this.listBox1.FormattingEnabled = true;
               this.listBox1.Location = new System.Drawing.Point(344, 124);
               this.listBox1.Name = "listBox1";
               this.listBox1.Size = new System.Drawing.Size(225, 199);
               this.listBox1.TabIndex = 4;
               this.listBox1.Visible = false;
               this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
               // 
               // button4
               // 
               this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.button4.Location = new System.Drawing.Point(344, 32);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(99, 42);
               this.button4.TabIndex = 5;
               this.button4.Text = "Показать содержимое";
               this.button4.UseVisualStyleBackColor = false;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // button5
               // 
               this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.button5.Enabled = false;
               this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.button5.Location = new System.Drawing.Point(470, 32);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(99, 42);
               this.button5.TabIndex = 6;
               this.button5.Text = "Скрыть содержимое";
               this.button5.UseVisualStyleBackColor = false;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // Form2
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::Maket.Properties.Resources.foto2;
               this.ClientSize = new System.Drawing.Size(896, 403);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.listBox1);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Name = "Form2";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Содержимое холодильника";
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.ListBox listBox1;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button5;
     }
}
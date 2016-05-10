namespace Maket
{
     partial class Form1
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
               this.label1 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.button1.Location = new System.Drawing.Point(82, 206);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(128, 58);
               this.button1.TabIndex = 0;
               this.button1.Text = "Изменить содержимое";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.button2.Location = new System.Drawing.Point(232, 206);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(128, 58);
               this.button2.TabIndex = 1;
               this.button2.Text = "Вывести рецепт";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.label1.Location = new System.Drawing.Point(21, 134);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(399, 25);
               this.label1.TabIndex = 2;
               this.label1.Text = "Ну что, жиртрест, кушать захотелось?";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::Maket.Properties.Resources.dcd1;
               this.ClientSize = new System.Drawing.Size(711, 416);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Name = "Form1";
               this.Text = "Холодильник";
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Label label1;
     }
}


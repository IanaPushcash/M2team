namespace Maket
{
     partial class Form4
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
               this.button3 = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.label1.Location = new System.Drawing.Point(86, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(257, 50);
               this.label1.TabIndex = 4;
               this.label1.Text = "Вы можете приготовить \r\nследующие блюда:";
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
               this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
               this.button3.Location = new System.Drawing.Point(82, 301);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(252, 40);
               this.button3.TabIndex = 5;
               this.button3.Text = "Вернуться к холодильнику";
               this.button3.UseVisualStyleBackColor = false;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // Form4
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.ControlLightLight;
               this.ClientSize = new System.Drawing.Size(421, 353);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.label1);
               this.Name = "Form4";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Рецепты";
               this.Load += new System.EventHandler(this.Form4_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button button3;
     }
}
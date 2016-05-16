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
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(136, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Вернуться к холодильнику";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(107, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 84);
            this.label1.TabIndex = 6;
            this.label1.Text = "Из имеющихся продуктов \r\nвы можете приготовить:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tPanel1
            // 
            this.tPanel1.AutoScroll = true;
            this.tPanel1.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.tPanel1.AutoSize = true;
            this.tPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tPanel1.ColumnCount = 1;
            this.tPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tPanel1.Location = new System.Drawing.Point(45, 95);
            this.tPanel1.MaximumSize = new System.Drawing.Size(353, 254);
            this.tPanel1.Name = "tPanel1";
            this.tPanel1.RowCount = 1;
            this.tPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tPanel1.Size = new System.Drawing.Size(323, 254);
            this.tPanel1.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Maket.Properties.Resources.ghh;
            this.ClientSize = new System.Drawing.Size(657, 407);
            this.Controls.Add(this.tPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рецепты";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TableLayoutPanel tPanel1;
     }
}
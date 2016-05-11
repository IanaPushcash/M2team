using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maket
{
     public partial class Form3 : Form
     {
          public Form3()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {

               if (vegetables.Visible == true)
               {
                    if (vegetables.Text != "Продукт")
                         label2.Text = label2.Text + "\n" + vegetables.Text;
                    else MessageBox.Show("Выберите продукт!");
               }
               else if (fruits.Visible == true)
               {
                    if (fruits.Text != "Продукт")
                         label2.Text = label2.Text + "\n" + fruits.Text;
                    else MessageBox.Show("Выберите продукт!");
               }
               else if (meat.Visible == true)
               {
                    if (meat.Text != "Продукт")
                         label2.Text = label2.Text + "\n" + meat.Text;
                    else MessageBox.Show("Выберите продукт!");
               }
               else if (milk.Visible == true)
               {
                    if (milk.Text != "Продукт")
                         label2.Text = label2.Text + "\n" + milk.Text;
                    else MessageBox.Show("Выберите продукт!");
               }
               else if (other.Visible == true)
               {
                    if (other.Text != "Продукт")
                         label2.Text = label2.Text + "\n" + other.Text;
                    else MessageBox.Show("Выберите продукт!");
               }

          }

          private void button2_Click(object sender, EventArgs e)
          {
            


               this.Close();
          }

          private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
          {
               if (comboBox1.Text == "Овощи") {
                    other.Visible = false;
                    milk.Visible = false;
                    meat.Visible = false;
                    fruits.Visible = false;
                    vegetables.Visible = true;
               }
               else if (comboBox1.Text == "Фрукты")
               {
                    vegetables.Visible = false;
                    other.Visible = false;
                    milk.Visible = false;
                    meat.Visible = false;
                    fruits.Visible = true;
               }
               else if (comboBox1.Text == "Мясо")
               {
                    fruits.Visible = false;
                    vegetables.Visible = false;
                    other.Visible = false;
                    milk.Visible = false;
                    meat.Visible = true;
               }
               else if (comboBox1.Text == "Молочка")
               {
                    meat.Visible = false;
                    fruits.Visible = false;
                    vegetables.Visible = false;
                    other.Visible = false;
                    milk.Visible = true;
               }
               else if (comboBox1.Text == "Другое")
               {
                    milk.Visible = false;
                    meat.Visible = false;
                    fruits.Visible = false;
                    vegetables.Visible = false;
                    other.Visible = true;
               }

          }

          private void label2_Click(object sender, EventArgs e)
          {

          }
     }
}

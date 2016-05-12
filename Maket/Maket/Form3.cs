using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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
                    productNExists(vegetables.Text);
               }
               else if (fruits.Visible == true)
               {
                    productNExists(fruits.Text);
               }
               else if (meat.Visible == true)
               {
                    productNExists(meat.Text);
               }
               else if (milk.Visible == true)
               {
                    productNExists(milk.Text);
               }
               else if (other.Visible == true)
               {
                    productNExists(other.Text);
               }

          }

          private void productNExists(string str)
          {
              if (str != "Продукт")
              {
                  if (!label2.Text.Split('\n').Contains(str))
                      label2.Text = label2.Text + "\n" + str;
              }
              else MessageBox.Show("Выберите продукт!");
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

          private void Form3_FormClosing(object sender, FormClosingEventArgs e)
          {
              
              ArrayList pr_str = new ArrayList(label2.Text.Split('\n'));
              pr_str.RemoveAt(0);
              XDocument doc = XDocument.Load("C:\\Fridge1.0\\Products.xml");
              XElement Products = doc.Element("Products");
              foreach(Object s in pr_str)
              {
                  Products.Add(new XElement("Product", s));
              }
              doc.Save("C:\\Fridge1.0\\Products.xml");
          }
     }
}

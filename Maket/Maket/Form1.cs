﻿using System;
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
     public partial class Form1 : Form
     {
          Random g = new Random();

          

         

          public Form1()
          {
               int irnd = g.Next(3);
               InitializeComponent();
               if (irnd == 0) label1.Text="Ну что, покушать захотелось?";
               else if (irnd == 1) label1.Text = "Лучше бы ты бегал по утрам =)";
               else if (irnd == 2) label1.Text = "У меня лучшие рецепты, бро!";
              
          }

          private void button1_Click(object sender, EventArgs e)
          {
               Form2 f = new Form2();

               f.ShowDialog();



               //this.Close();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               Form4 f = new Form4();
               f.ShowDialog();



               //this.Hide();
          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }
     }

     
}

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
     public partial class Form2 : Form
     {
          public Form2()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               Form3 f = new Form3();
               f.ShowDialog();



               //this.Hide();
          }

          private void button3_Click(object sender, EventArgs e)
          {
               Form4 f = new Form4();
               f.ShowDialog();



              // this.Hide();
          }

          private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
          {

          }

          private void button4_Click(object sender, EventArgs e)
          {
               listBox1.Visible = true;
               button5.Enabled = true;
               button4.Enabled = false;
          }

          private void button5_Click(object sender, EventArgs e)
          {
               listBox1.Visible = false;
               button5.Enabled = false;
               button4.Enabled = true;
          }
     }
}

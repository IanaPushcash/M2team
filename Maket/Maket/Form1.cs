using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maket
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }

          private void button1_Click(object sender, EventArgs e)
          {
              
               Form2 f = new Form2();
               f.Show();



               this.Hide();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               Form4 f = new Form4();
               f.Show();



               this.Hide();
          }

          private void Form1_Load(object sender, EventArgs e)
          {
              CreateDatabase2();
          }

          public void CreateDatabase2()
          {
              File.Create(@"C:\myfridge.mdf");
              MyFridge db = new MyFridge(@"C:\myfridge.mdf");
              try
              {
                  if (db.DatabaseExists())
                  {
                      Console.WriteLine("Deleting old database...");
                      db.DeleteDatabase();
                  }
                  db.CreateDatabase();
              }
              catch (Exception e)
              {
                  MessageBox.Show(e.ToString());
              }
          }

     }
}

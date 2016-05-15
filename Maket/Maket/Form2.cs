using System;
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
               button4_Click(null, null);


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
              listBox1.Items.Clear();
              XmlDocument xmlDocument = new XmlDocument();
              xmlDocument.Load("C:\\Fridge1.0\\Products.xml");
              XmlElement xRoot = xmlDocument.DocumentElement;
              foreach (XmlNode node in xRoot)
              {
                  listBox1.Items.Add(node.InnerText);
              }
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

          private void button2_Click(object sender, EventArgs e)
          {
              XDocument xDoc = XDocument.Load("C:\\Fridge1.0\\Products.xml");
              foreach (XElement node in xDoc.Root.Nodes())
              {
                  try
                  {
                      if (listBox1.SelectedItem.Equals(node.Value))
                          node.Remove();
                  }
                  catch (Exception c) { }
              }
              xDoc.Save("C:\\Fridge1.0\\Products.xml");
              listBox1.Items.Remove(listBox1.SelectedItem);
               
          }

         
     }
}

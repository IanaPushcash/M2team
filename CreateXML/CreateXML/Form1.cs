using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CreateXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 5 && textBox2.Text.Length > 5 && textBox3.Text.Length > 5)
            {
                XDocument doc = XDocument.Load(f);
                XElement recs = doc.Element("Recipes");
                XElement name = new XElement("Name", textBox1.Text);
                XElement ingr = new XElement("Ingredients", textBox2.Text);
                XElement text = new XElement("Text", textBox3.Text);
                XElement rec = new XElement("Pecipe", name);
                rec.Add(ingr);
                rec.Add(text);
                recs.Add(rec);
                doc.Save(f);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else MessageBox.Show("Warning", "Too few simbols!");
            
        }
        string f;
        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    f = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
           
        }
    }
}

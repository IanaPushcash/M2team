using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Maket
{
     public partial class Form4 : Form
     {
          public Form4()
          {
               InitializeComponent();
          }

          private void button3_Click(object sender, EventArgs e)
          {



               this.Close();
          }

          private void panel1_Paint(object sender, PaintEventArgs e)
          {

          }

          private void Form4_Load(object sender, EventArgs e)
          {
              int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;

              tPanel1.Padding = new Padding(0, 0, vertScrollWidth, 0);
              ArrayList products = new ArrayList();
              XmlDocument xmlDocument1 = new XmlDocument();
              xmlDocument1.Load("C:\\Fridge1.0\\Products.xml");
              XmlElement xRoot = xmlDocument1.DocumentElement;
              foreach (XmlNode node in xRoot)
              {
                  products.Add(node.InnerText.ToLower());
              }
              XmlDocument xmlDocument = new XmlDocument();
              xmlDocument.Load("C:\\Fridge1.0\\BookOfRecipes.xml");
              XmlElement recipes = xmlDocument.DocumentElement;
              for (int i = 0; i < recipes.ChildNodes.Count; i++)
              {
                  XmlNode node = recipes.ChildNodes.Item(i);
                  bool write = true;
                  XmlNode ingredients = node.SelectSingleNode("Ingredients");
                  ArrayList ingr = new ArrayList(ingredients.InnerText.Replace(" ", "").Split(','));
                  if (products.Count >= ingr.Count)
                  {
                      foreach (string s in ingr)
                      {
                          if (!products.Contains(s.ToLower()))
                          {
                              write = false;
                              break;
                          }
                      }

                      if (write)
                      {
                          tPanel1.RowCount = tPanel1.RowCount + 3;
                          Label lb = new Label();
                          lb.Font = new System.Drawing.Font("Monotype Corsiva", 20, FontStyle.Italic);
                          lb.MaximumSize = new Size(320, 0);
                          lb.Name = "name" + i;
                          lb.Text = node.SelectSingleNode("Name").InnerText + "\n";
                          lb.AutoSize = true;
                          tPanel1.Controls.Add(lb, 0, tPanel1.RowCount - 3);

                          Label lb1 = new Label();
                          lb1.MaximumSize = new Size(320, 0);
                          lb1.Name = "ingr" + i;
                          lb1.Text = "Ингредиенты: " + node.SelectSingleNode("Ingredients").InnerText + "\n\n";
                          lb1.AutoSize = true;
                          tPanel1.Controls.Add(lb1, 0, tPanel1.RowCount - 2);

                          Label lb2 = new Label();
                          lb2.MaximumSize = new Size(320, 0);
                          lb2.Name = "text" + i;
                          lb2.Text = "Способ приготовления: " + node.SelectSingleNode("Text").InnerText + "\n\n";
                          lb2.AutoSize = true;
                          tPanel1.Controls.Add(lb2, 0, tPanel1.RowCount - 1);

                      }
                  }
              }

















          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void label1_Click_1(object sender, EventArgs e)
          {

          }
     }
}

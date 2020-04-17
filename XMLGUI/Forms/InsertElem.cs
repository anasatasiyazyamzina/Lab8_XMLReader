using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;

namespace XMLGUI.Forms
{
    public partial class InsertElem : Form
    {

        public InsertElem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
           
            if ((tAge.Text.Length == 0) | (tName.Text == "") | (tType.Text == "") |
                (tPrice.Text == "") | (tProvider.Text == "") | (tInStock.Text == "")
                | (tDataOfOrder.Text == ""))
            {
            DialogResult  result =   MessageBox.Show("Не заполнены некоторые ячейки!", "Error", buttons, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    Close();
                }
            }
            else
            {
                InsertEl(XMLViewer.doc,label9.Text, tName.Text, tType.Text,tPrice.Text,tAge.Text,tInStock.Text, tDataOfOrder.Text, tProvider.Text);
                Close();
            }
           
        }

        public void InsertEl(XDocument doc,string id, string name, string type, string price, string age, string stock, string dataord, string prov )
        {
          doc.Element("library").Add(
          new XElement("toy",
                      new XAttribute("id", id),
                      new XAttribute("name", name),
                      new XAttribute("type", type),
                      new XElement("price", price),
                      new XElement("age", age),
                      new XElement("instock", stock),
                      new XElement("dataoforder", dataord ),
                      new XElement("provider", prov)));

            Console.WriteLine(doc);
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using XMLGUI.EventsLib;
using XMLGUI.Forms;

namespace XMLGUI
{
    public partial class XMLViewer : Form
    {
       
        
        public IEnumerable<XElement> tracks;
        public static XDocument doc;
        public XMLViewer()
        {
            InitializeComponent();
            //задаем путь к нашему рабочему файлу XML
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы xml|*.xml";
            OPF.Multiselect = false;
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                doc = XDocument.Load(OPF.FileName);
            }
        }

        private void OnSetFilterClick(object sender, EventArgs e)
        {
            FilterProperties setFilterForm = new FilterProperties();
            setFilterForm.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(this.OnFilterChangeEvent);
            setFilterForm.Show();
        }

        public void OnFilterChangeEvent(object sender, FilterChangeEventArgs e)
        {
            //update this form, using information from e.Param
            //for example:
            // tableView.Text += e.Param;
            // Console.WriteLine(e.Name);
            // XDocument doc = XDocument.Load("base.xml");
            tracks = from t in doc.Root.Elements("toy")
                     orderby t.Attribute("id").Value
                     select t;

            if (e.Name == "btnAge")
            {
                tracks = doc.Root.Descendants("toy").Where(
                   t => t.Element("age").Value == e.Param).ToList();

                WriteText(tracks);
            }

            if (e.Name == "btnDateOfOrder")
            {
                tracks = doc.Root.Descendants("toy").Where(
                   t => t.Element("dataoforder").Value == e.Param).ToList();

                WriteText(tracks);
            }

            if (e.Name == "btnProvider")
            {
                tracks = doc.Root.Descendants("toy").Where(
                   t => t.Element("provider").Value == e.Param).ToList();
                WriteText(tracks);
            }
        }



        private void XMLViewer_Load(object sender, EventArgs e)
        {
          
            tracks = from t in doc.Descendants("toy")
                     select t;
            Console.WriteLine(tracks);
            WriteText(tracks);

        }


        public IEnumerable<XElement> WriteText(IEnumerable<XElement> lib)
        {
            tableView.Text = "";
            foreach (XElement el in lib)
            {
                tableView.Text += "";
                //Выводим имя элемента и значение аттрибута  
                tableView.Text += el.Name + " ";
                tableView.Text += el.Attribute("id").Value + Environment.NewLine;
                //tableView.Text += el.Attribute("id").Value;
                tableView.Text += "  Attributes:" + Environment.NewLine;
                //выводим в цикле все аттрибуты, заодно смотрим как они себя преобразуют в строку
                foreach (XAttribute attr in el.Attributes())
                {
                    tableView.Text += "     " + attr + Environment.NewLine;
                }
                tableView.AppendText("  Elements:");
                tableView.Text += Environment.NewLine;
                //выводим в цикле названия всех дочерних элементов и их значения
                foreach (XElement element in el.Elements())
                    tableView.Text += "      " + element.Name + ":" + element.Value + Environment.NewLine;
            }

            return lib;
        }
        public IEnumerable<XElement> Filter(IEnumerable<XElement> text, string how) {
            text = from t in text
                     orderby t.Attribute(Convert.ToString(how)).Value descending
                     select t;

            return text;
        }
        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tracks = Filter(tracks, "name");
            WriteText(tracks);
        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tracks = Filter(tracks, "id");
            WriteText(tracks);
        }

      

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteItems newDeleteItems = new DeleteItems();
            newDeleteItems.DeleteChangeEvent += new EventHandler<DeleteChangeEventArgs>(this.OnDeleteChangeEvent);
            newDeleteItems.Show();
        }
        public void OnDeleteChangeEvent(object sender, DeleteChangeEventArgs e)
        {


            if (e.Name == "btnName")
            {
                doc.Descendants("toy").Where(em => em.Attribute("name").Value == e.Param).Remove();
                Console.WriteLine(doc);
            }

            if (e.Name == "btnDateOfOrder")
            {
                doc.Descendants("toy").Where(em => em.Element("dataoforder").Value == e.Param).Remove();
                Console.WriteLine(doc);
            }

            if (e.Name == "btnId")
            {
                doc.Descendants("toy").Where(em => em.Attribute("id").Value == e.Param).Remove();
                Console.WriteLine(doc);
            }
            tracks = from t in doc.Descendants("toy")
                     select t;

            WriteText(tracks);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc.Save("testWrite6.xml");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            tracks = from t in doc.Descendants("toy")
                     select t;
            WriteText(tracks);
        }
        
        
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var albumGroups = doc.Root.Elements("toy").GroupBy(t => t.Attribute("id").Value);
            var max = albumGroups.Max(id => Convert.ToInt32(id.Key));
            Console.WriteLine(max);
            InsertElem newInsertedElems = new InsertElem();
            newInsertedElems.Show();
            newInsertedElems.label9.Text = Convert.ToString(Convert.ToInt32(max)+1);
           
       

            tracks = from t in doc.Descendants("toy")
                     select t;
            WriteText(tracks);
        }
    }
}


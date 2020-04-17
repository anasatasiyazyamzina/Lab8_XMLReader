using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLGUI
{
    static class EnteringPoint
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new XMLViewer());
         // doXml();
        }

        static void doXml()
        {
            //задаем путь к нашему рабочему файлу XML
            string fileName = "base.xml";

            //счетчик для номера композиции
            int trackId = 1;
            //Создание вложенными конструкторами.

///Одна запись журнала содержит поля: код игрушки, название игрушки, тип игрушки, возрастные границы (например, от 10 до 15), 
///цена за единицу, количество в наличии, дата поступления в магазин, поставщик. Организовать поиск по дате поступления, поставщику,
///возрастным границам.
            XDocument doc = new XDocument(
                new XElement("library",
                    new XElement("toy",
                        new XAttribute("id", trackId++),
                        new XAttribute("name", "Rabbit"),
                        new XAttribute("type", "soft"),
                        new XElement("price", 100),
                        new XElement("age", 10),
                        new XElement("instock", 10),
                        new XElement("dataoforder", "10.02.2019"),
                        new XElement("provider", "Shop1"))//,
                    //new XElement("library",
                    //new XElement("toy",
                    //    new XAttribute("id", trackId++),
                    //    new XAttribute("name", "Dolly"),
                    //    new XAttribute("type", "Doll"),
                    //    new XElement("price", 1000),
                    //    new XElement("age", 10),
                    //    new XElement("instock", 100),
                    //    new XElement("dataoforder", "10.03.2019"),
                    //    new XElement("provider", "Shop2")))
                    ));
            //сохраняем наш документ
            doc.Save("testIntBase.xml");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_NAIM_PRICE_TOVAR_BENZINE
{


    class Program


    /*Создайте XML- документ, представляющий информацию по определенной вариантом предметной области. 
     Созданный документ должен соответствовать следующим требования:*/
    {
        static void Main(string[] args)
        {
            Console.Title = "Домашнее Задание - Латыпов Альфар --XmlDocument ";

            XmlDocument doc = new XmlDocument(); // Создаем документ виртуально

            XmlElement root = doc.CreateElement("User"); //Создаем РУТ- ЭЛЕМЕНТ 


            /*1.	документы должны иметь глубину вложенности не менее четырех элементов;
              2.	число элементов документа, не имеющих вложенных, должно быть не менее пяти;
              3.	элементы документа должны содержать комментарии о своем содержании;
              4.	документ должен включать элементы, содержащие символьные данные и дочерний элементы;
              5.	Создание XML документа в текстовом редакторе и проверка структуры документа в программе-броузере Internet Explorer.
*/


            XmlElement name = doc.CreateElement("Name");
            name.InnerText = "Alfar";

            root.AppendChild(name);

            doc.AppendChild(root);

            doc.Save("UserAlfar.xml");

        }
    }
}

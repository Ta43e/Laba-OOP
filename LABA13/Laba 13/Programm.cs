using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Laba_13
{
    public class Programm
    {
        public static void Main()
        {
            //-------------------------------1 задание -------------------------------------//
            Goods cakeBinary = new Cake(11230, "BSTU", "XZ", "OOO Dostavka.by", "Imperatriza");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("BinaryFormat.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, cakeBinary);
            };
            using (FileStream fs = new FileStream("BinaryFormat.dat", FileMode.OpenOrCreate))
            {
                Goods cakeBinaryDes = (Goods)binaryFormatter.Deserialize(fs);
                Console.WriteLine("=====Дисериализация BinaryFormatter=====");
                Console.WriteLine(cakeBinaryDes.ToString());
                Console.WriteLine("========================");
            };
            Goods cakeSoap = new Cake(7834, "BSTU", "KoPe14ka", "OOO Dostavka.by", "Muraveinik");
            SoapFormatter soapFormatter = new SoapFormatter();
            using (FileStream fl = new FileStream("SoapFormat.xml", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fl, cakeSoap);
            };
            using (FileStream fl = new FileStream("SoapFormat.xml", FileMode.OpenOrCreate))
            {
                Console.WriteLine("=====Дисериализация SoapFormatter=====");
                Goods cakeSoapFormat = (Goods)soapFormatter.Deserialize(fl);
                Console.WriteLine(cakeSoapFormat.ToString());
                Console.WriteLine("========================");
            }
            Goods JSONcake = new Cake(98765, "1_BNTU", "ZALESE", "OOO Trans.by", "9Orech6");
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Cake));
            using (FileStream fs = new FileStream("JsonFormat.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, JSONcake);
            };
            using (FileStream fs = new FileStream("JsonFormat.json", FileMode.OpenOrCreate))
            {
                Console.WriteLine("=====Дисериализация DataContractJsonSerializer=====");
                Goods JsonCake = (Cake)jsonSerializer.ReadObject(fs);
                Console.WriteLine(JsonCake.ToString());
                Console.WriteLine("========================");
            };
            Goods cakeXML = new Cake(5622, "BNTU", "ZALESE", "OOO Trans.by", "Orech");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Cake));
            using (FileStream fs = new FileStream("XmlFormat.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, cakeXML);
            };
            using (FileStream fs = new FileStream("XmlFormat.xml", FileMode.OpenOrCreate))
            {
                Console.WriteLine("=====Дисериализация XmlSerializer=====");
                Goods xmlCake = (Cake)xmlSerializer.Deserialize(fs);
                Console.WriteLine(xmlCake.ToString());
                Console.WriteLine("========================");
            };

            //---------------------- 2 задание -------------------------// 
            Goods[] arrCake = new Cake[] { (Cake)cakeBinary, (Cake)cakeSoap, (Cake)JSONcake };
            XmlSerializer xmlSerializerArr = new XmlSerializer(typeof(Cake[]));
            using (FileStream fs = new FileStream("arrCakeXml.xml", FileMode.OpenOrCreate))
            {
                xmlSerializerArr.Serialize(fs, arrCake);
            }
            using (FileStream fs = new FileStream("arrCakeXml.xml", FileMode.OpenOrCreate))
            {
                Console.WriteLine("=====Дисериализация массива Cake=====");
                Goods[]? newCake = xmlSerializerArr.Deserialize(fs) as Goods[];
                if (newCake != null)
                {
                    foreach (Goods good in newCake)
                    {
                        Console.WriteLine(good.ToString());
                    }
                }
                Console.WriteLine("========================");
            };
            //---------------------- 3 задание -------------------------// 
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("arrCakeXml.xml");
            XmlElement? xRoot = xDoc.DocumentElement;
            XmlNodeList? nodes = xRoot?.SelectNodes("Cake");
            if (nodes is not null)
            {
                foreach (XmlNode nod in nodes)
                    Console.WriteLine(nod.OuterXml);
            }
            XmlNodeList? node = xRoot?.SelectNodes("*");
            if (nodes is not null)
            {
                foreach (XmlNode nod in node)
                    Console.WriteLine(nod.OuterXml);
            }
            XmlNodeList nodeList = xDoc.DocumentElement.SelectNodes("/Goods/body");
            foreach (XmlNode no in nodeList)
            {
                Console.WriteLine("========================= qwfqwf ==================");
                Goods cakes = new Cake();
                cakes.Manufacturer = no.SelectSingleNode("Manufacturer").InnerText;
                cakes.Delivery = no.SelectSingleNode("Delivery").InnerText;
                Console.WriteLine(cakes.ToString());
            }
            //---------------------- 4 задание -------------------------//
            Console.WriteLine("=====================Задание 4======================");
            XDocument xDoc2 = new XDocument();
            XElement root = new XElement("Cake");
            XElement cake;
            XElement delivery;
            XAttribute cost;

            cake = new XElement("Cake");
            delivery = new XElement("Delivery");
            delivery.Value = "OOO BST.by";
            cost = new XAttribute("Cost", "1234");
            cake.Add(delivery);
            cake.Add(cost);
            root.Add(cake);
            xDoc2.Add(root);
            xDoc2.Save("NewTest.xml");
            var elements = from p in root.Elements("Cake").Where(p => Convert.ToInt32(p.Attribute("Cost").Value) < 10000) select p;
            foreach (var item in elements)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}

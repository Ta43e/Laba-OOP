
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 8081);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);


            //Создание объекта
            Cake cake = new Cake(98765, "1_BNTU", "ZALESE", "OOO Trans.by", "9Orech6");

            //Сериализация объекта
            MemoryStream memorystream = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(memorystream, cake);
            var message = memorystream.ToArray();

            foreach (var i in message)
                Console.Write($"{i} ");


            var data = message;

            sender.Connect(ipEndPoint);
            sender.Send(data);
            var buffer = new byte[256];
            var answer = new StringBuilder();
            var size = 0;

            do
            {
                size = sender.Receive(buffer);
                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
            }
            while (sender.Available > 0);

            Console.WriteLine(answer.ToString());

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();

            Console.ReadLine();
        }
    }
}
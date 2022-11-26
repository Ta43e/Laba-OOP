using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laba_13
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 8081);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            sender.Bind(ipEndPoint);
            sender.Listen(5);

            var listener = sender.Accept();
            var buffer = new byte[256];
            var data = new Cake();
            var size = 0;

            do
            {
                size = listener.Receive(buffer);
                byte[] b = buffer;
                using (var stream = new MemoryStream(b))
                {
                    var formatter = new BinaryFormatter();
                    stream.Seek(0, SeekOrigin.Begin);
                    data = formatter.Deserialize(stream) as Cake;
                }
            }
            while (listener.Available > 0);

            Console.WriteLine(data.ToString());

            listener.Send(Encoding.UTF8.GetBytes("\nОтвет клиента: Сообщение принято"));

            listener.Shutdown(SocketShutdown.Both);
            listener.Close();

            Console.ReadLine();
        }
    }
}
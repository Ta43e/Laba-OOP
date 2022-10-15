using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LABA7_1
{
    public static class json<T>
    {
        public static void Ser<T>(MyList<T> list)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA7_1\test.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, list.Head);
            }
        }
        public static void Der<T>(MyList<T> list)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
            };
            using var stream = new StreamReader(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA7_1\test.json");
            string JsonData = stream.ReadToEnd();

#pragma warning disable CS8600
            MyList<T>.Node deserialisationList = JsonConvert.DeserializeObject<MyList<T>.Node>(JsonData, settings);
            MyList<T>.Node current = deserialisationList;
            while (current != null)
            {
                list.Add(current.Data);
                current = current.Next;
            }
#pragma warning restore CS8600
        }

    }
}

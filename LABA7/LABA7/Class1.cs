using System.IO;
using Newtonsoft.Json;

namespace LABA7
{
    public static class GenericsAndFiles
    {
        public static async Task WriteListAsync<T>(Person<int> person)
        {
            //JsonSerializer serializer = new JsonSerializer();
            //serializer.NullValueHandling = NullValueHandling.Ignore;

            //using (StreamWriter sw = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA7\test.json"))
            //using (JsonWriter writer = new JsonTextWriter(sw))
            //{
            //    writer.Formatting = Formatting.Indented;
            //    serializer.Serialize(writer, list);
            //}


            //using (FileStream fs = new FileStream(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA7\test.json", FileMode.OpenOrCreate))
            //{
            //    object value = await JsonSerializer.SerializeAsync<Person<int>>(fs, person);
            //    Console.WriteLine("Data has been saved to file");
            //}
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LABA11
{
    public static class Reflector
    {
        //----a-----//
        private static StreamWriter streamWrite = null;
        public static void NameAssembler(string NameClass)
        {
            streamWrite = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA11\ClassInfo.txt", true);
            Assembly assemCar = Type.GetType(NameClass).Assembly;
            Console.WriteLine("Assembly Full Name:");
            Console.WriteLine(assemCar.FullName);
            streamWrite.WriteLine("Assembly Full Name:");
            streamWrite.WriteLine(assemCar.FullName);
            streamWrite.Close();
        }
        //----b----//
        public static IEnumerable<string> GetConstructors(string NameClass)
        {
            streamWrite = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA11\ClassInfo.txt", true);
            List<string> list = new List<string>();
            ConstructorInfo[] infoCar = Type.GetType(NameClass).GetConstructors();
            streamWrite.WriteLine($"Публичных конструкторов: {infoCar.Length}");
            streamWrite.Close();
            list.Add("Публичных конструкторов: " + infoCar.Length);
            return list;
        }
        //----c-----//
        public static IEnumerable<string> CheckMetod(string NameClass)
        {
            streamWrite = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA11\ClassInfo.txt", true);
            Type type = Type.GetType(NameClass);
            List<string> list = new List<string>();
            foreach (MethodInfo method in type.GetMethods().Where(m => !m.Name.StartsWith("get_") && !m.Name.StartsWith("set_")))
            {
                string modificator = "";
                if (method.IsStatic)
                {
                    modificator += "static: ";
                }
                list.Add(modificator + method.ReturnType.Name + " " + method.Name);
                streamWrite.WriteLine(modificator + method.ReturnType.Name + " " + method.Name);
            }
            streamWrite.Close();
            return list;


        }
        //-----d-----//
        public static IEnumerable<string> InfoPole(string NameClass)
        {
            streamWrite = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA11\ClassInfo.txt", true);
            List<string> list = new List<string>();
            Type type = Type.GetType(NameClass);
            FieldInfo[] myField = type.GetFields();
            PropertyInfo[] myFildSv = type.GetProperties();
            if (myField.Length == 0)
            {
                streamWrite.WriteLine("Public полей нету");
                streamWrite.Close();
                throw new Exception("Public полей нету");
            }
            foreach (FieldInfo field in myField)
            {
                string modificator = "";
                modificator += "Поле " + field.Name + " ";
                streamWrite.WriteLine(modificator);
                list.Add(modificator);
            }
            if (myFildSv.Length == 0)
            {
                streamWrite.WriteLine("Cвойств нету");
                streamWrite.Close();
                throw new Exception("Свойcтв нету");
            }
            foreach (PropertyInfo field in myFildSv)
            {
                string modificator = "";
                modificator += "Cвойство " + field.Name + " ";
                streamWrite.WriteLine(modificator);
                list.Add(modificator);
            }
            streamWrite.Close();
            return list;
        }
        //-----e-----//
        public static IEnumerable<string> InfoInterfeice(string NameClass)
        {
            streamWrite = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA11\ClassInfo.txt", true);
            List<string> list = new List<string>();
            Type type = Type.GetType(NameClass);
            if (type != null)
            {
                list.Add("Итерфейсов нету");
                streamWrite.WriteLine("Интерфейсов нету");
                streamWrite.Close();
                return list;
            }
            foreach (Type item in type.GetInterfaces())
            {
                list.Add("Интерфейс: " + item.Name);
                streamWrite.WriteLine("Интерфейс: " + item.Name);
            }
            streamWrite.Close();
            return list;
        }
        public static void InfoParametr(string NameClass, string Modification)
        {
            streamWrite = new StreamWriter(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA11\ClassInfo.txt", true);
            Type type = Type.GetType(NameClass);
            foreach (MethodInfo item in type.GetMethods())
            {
                bool check = false;
                ParameterInfo[] parameters = item.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    var param = parameters[i];
                    if (param.ParameterType.Name == Modification)
                    {
                        check = true;
                        break;
                    }
                }
                if (check)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        var param = parameters[i];
                        Console.Write(item.Name + " " + param.ParameterType.Name + " " + param.ParameterType);
                        streamWrite.WriteLine(item.Name + " " + param.ParameterType.Name + " " + param.ParameterType);
                        if (i + 1 == parameters.Length)
                        {
                            Console.WriteLine("\n---------");
                            streamWrite.WriteLine("\n---------");
                        }
                    }
                }
            }
            streamWrite.Close();
        }
        public static void Invoke(string NameClass, string NameMethod)
        {
            try
            {
                Object? obj = Activator.CreateInstance(Type.GetType(NameClass));
                var method = Type.GetType(NameClass).GetMethod(NameMethod);
                List<string> str = File.ReadAllLines(@"D:\УНИК\Семестр 3\ООП\OOP_git\Laba-OOP\LABA11\invoke.txt").ToList();
                List<string>[] strings = new List<string>[] { str };
                method.Invoke(obj, strings);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static object Create(string currentClassName)
        {
            object obj = Activator.CreateInstance(Type.GetType(currentClassName));
            return obj;
        }

    }
}

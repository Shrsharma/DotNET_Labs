using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace NuGetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("data display using csharp escape characters--");
            string data = "{\"name\":\"Tom S.\", \"age\":\"14\"}";
            Console.WriteLine(data);

            JArray array = new JArray();
            JValue text = new JValue("Manual Text");
            JValue date = new JValue(new DateTime(2000, 5, 23));
            array.Add(text);
            array.Add(date);
            Console.WriteLine("\ndata display using json--");
            Console.WriteLine(array.ToString());

            DemoEmployee e = new DemoEmployee();
            e.ID = 1;
            e.Name = "ABC";
            e.Dept = "IT";
            Console.WriteLine("\nData using serialize from json package:\n"+JsonConvert.SerializeObject(e));
        }
    }
}

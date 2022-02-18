using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Json1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var location = @"S:\NB\Assi\Day1 Morning assignment by Surya Teja Chandolu 24 Jan 2022\C#\Day19Feb17\JsonFile.json";
            StreamReader sr = File.OpenText(location);

            string s = "";
            JArray jsonObject;
            StringBuilder StringData = new StringBuilder();
            while ((s = sr.ReadLine()) != null)
            {
                StringData.Append(s);
            }

            jsonObject = JArray.Parse(StringData.ToString());
            var id = jsonObject.Select(x => x["@Id"].ToString());
            var name= jsonObject.Select(x => x["@Name"].ToString());
            var brand = jsonObject.Select(x => x["@Brand"].ToString());


            Console.WriteLine($"Id: {JsonConvert.SerializeObject(id)} \nName: {JsonConvert.SerializeObject(name)} \nBrand: {JsonConvert.SerializeObject(brand)}");

            Console.ReadLine();

        }
    }
}

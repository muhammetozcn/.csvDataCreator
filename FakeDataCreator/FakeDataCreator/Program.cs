using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
namespace FakeDataCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            //FakeData kullanılarak excel tablolu veri seti oluşturma projesi
            Console.Write("Veri Sayisi giriniz:");
            int numberOfData=int.Parse(Console.ReadLine());

            FakeDataFactory factory = new FakeDataFactory();
            var memoryStream = new MemoryStream();
            var writer = new StreamWriter(memoryStream);
            var csv = new CsvHelper.CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture);

            string title = string.Format("{0},{1},{2},{3},{4}\n", "ID", "CUSTOMERNAME", "CITY", "GENDER", "AGE");
            File.AppendAllText("output.csv", title);
            for (int i = 0; i < numberOfData; i++)
            {
                DataModel model=factory.createData();
                string wr = string.Format("{0},{1},{2},{3},{4} \n", model.Id, model.CustomerName,model.City,model.gender,model.age);
              
                
                File.AppendAllText("output.csv", wr);
                


            }


        }
    }
}

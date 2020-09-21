using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDataCreator
{
    public class FakeDataFactory
    {
        int startId = 1;
        DataModel model;


        public FakeDataFactory()
        {
            model = new DataModel();
        }
      
        public DataModel createData()
        {
            model.Id = this.startId;
            this.startId++;
            model.City = FakeData.PlaceData.GetCity();
            model.ConnectionDate = FakeData.DateTimeData.GetDatetime();
            model.age = FakeData.NumberData.GetNumber(25, 60);

            Random random = new Random();
            int dice = random.Next();
            if (dice % 2 == 0) //Randomly gender selection
            {
                model.CustomerName = FakeData.NameData.GetMaleFirstName() + " " + FakeData.NameData.GetSurname();
                model.gender = 'M';
            }
            else
            {
                model.CustomerName = FakeData.NameData.GetFemaleFirstName() + " " + FakeData.NameData.GetSurname();
                model.gender = 'F';
            }

            return model;
        }


        
    }
}

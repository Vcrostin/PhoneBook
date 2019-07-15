using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookBL.model
{
    [Serializable]
    public class NumberData
    {
        int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronynic { get; set; }
        public List<string> Number { get; set; }
        public string ImageLink { get; set; }
        public DateTime Birthday { get; set; }

        public void AddNumber(string number)
        {
            Number.Add(number);
        }

        public void RemoveNumber(string number)
        {
            Number.Remove(number);
        }

        public NumberData(int id, string name, string number)
        {
            ID = id;
            FirstName = name;
            Number = new List<string>
            {
                number
            };
        }
    }
}

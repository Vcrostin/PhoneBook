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
        public string Name { get; set; }
        public string Number { get; set; }
        DateTime Birthday { get; set; }


        public NumberData(int id, string name, string number)
        {
            ID = id;
            Name = name;
            Number = number;
        }
    }
}

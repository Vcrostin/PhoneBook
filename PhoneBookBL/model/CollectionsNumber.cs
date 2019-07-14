using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookBL.model
{
    [Serializable]
    public class CollectionsNumber
    {
        public List<NumberData> NumberDatas;

        public CollectionsNumber()
        {
            NumberDatas = UpdateData();
        }

        public void AddPeople(NumberData CurrentNumber)
        {
            NumberDatas.Add(CurrentNumber);
            SaveData();
        }

        public void RemovePeople(NumberData CurrentNumber)
        {
            NumberDatas.Remove(item: CurrentNumber);
            SaveData();
        }

        public List<NumberData> UpdateData()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("NumberData.dat", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && formatter.Deserialize(fs) is List<NumberData> numberDatas)
                {
                    return numberDatas;
                }
                else
                {
                    return new List<NumberData>();
                }
            };
        }

        public void SaveData()
        {
            var formatter = new BinaryFormatter();
            using(var fs=new FileStream("NumberData.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, NumberDatas);
            }
        }
    }
}

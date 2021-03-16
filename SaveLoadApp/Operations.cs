using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SaveLoadApp
{
    [Serializable]
    public class Operations
    {
        public Operations()
        {

        }
        XmlSerializer formatter = new XmlSerializer(typeof(List<ItemsForSerializable>));
        public void Save(List<ItemsForSerializable> items)
            //newItemsClass = ProgramParams
        {
            using (FileStream fs = new FileStream("e:\\TEST.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, items);
            }
            Console.WriteLine("Complete save operation");
        }

        public void Load()
        {
            using (FileStream fs = new FileStream("e:\\TEST.xml", FileMode.OpenOrCreate))
            {
                List <ItemsForSerializable> newItems = (List<ItemsForSerializable>)formatter.Deserialize(fs);

                foreach (ItemsForSerializable parametr in newItems)
                {
                    Console.WriteLine($"Имя: {parametr.NameItem} \t Значение:  {parametr.ValueItem}");
                }
            }
        }

    }
}

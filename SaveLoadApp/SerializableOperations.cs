using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SaveLoadApp
{
    [Serializable]
    public class SerializableOperations
    {

        public SerializableOperations()
        {

        }

      //  private List<ProgramParams> listForSerializable = new List<ProgramParams>();
        XmlSerializer formatter = new XmlSerializer(typeof(List<ProgramParams>));
        public void Save()
        {
        var parametr = new ProgramParams();

            foreach (var item in parametr.GetType().GetProperties())
            {
                Console.WriteLine("{0} = {1}", item.Name, item.GetValue(parametr, null));
                
                //listForSerializable.Add(item);
            }

        }

        public void Save1(List<ProgramParams> items)
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

        }

    }
}

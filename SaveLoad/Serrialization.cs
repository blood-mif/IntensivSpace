using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SaveLoad
{
    public class Serrialization<SerrializeClass>
    {
        public Serrialization(string path = "saveClass.xml")
        {
            DeSerrialize();
        }

        public void Serrialize(string path = "saveClass.xml")
        {

            if (File.Exists(path))
                File.Delete(path);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SerrializeClass));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, this);
            }
        }

        public void DeSerrialize(string path = "saveClass.xml")
        {
            if (File.Exists(path))
                File.Delete(path);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SerrializeClass));
            SerrializeClass SaveClass = default;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                if (fs.Length != 0)
                    SaveClass = (SerrializeClass)xmlSerializer.Deserialize(fs);
            }

            var props = this.GetType().GetProperties();

            foreach (var item in props)
            {
                object val = item.GetValue(SaveClass, null);
                item.SetValue(this, val);
            }
        }
    }
}

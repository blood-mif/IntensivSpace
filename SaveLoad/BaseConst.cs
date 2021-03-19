using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SaveLoad
{
    public class BaseConst 
    {
        public static _T nameUsing<_T>(string path) where _T : BaseConst
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(_T));

            _T SaveClass = null;
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    if (fs.Length != 0)
                        SaveClass = (_T)xmlSerializer.Deserialize(fs);
                }
                Console.WriteLine("Deserialize compleate");
              
            return SaveClass;
            
        }

    }
}

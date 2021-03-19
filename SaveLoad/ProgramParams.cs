using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SaveLoad
{
    [Serializable]
    public class ProgramParams : Serrialization<ProgramParams>
    {
        /// <summary>
        /// Колличество полупериодов пропущенных перед началом длинной калибровки
        /// </summary>
        public UInt32 SkipLongCal { get; set; } = 33;
        /// <summary>
        /// Колличество полупериодов использованных для длинной калибровки
        /// </summary>
        public UInt32 UseLongCal { get; set; } = 1120;
        /// <summary>
        /// Колличество полупериодов использованных для определения накопленного угла после длинной калибровки
        /// </summary>
    [XmlIgnore]
        public UInt32 FlyLongCal { get; set; } = 10;
        



    }
}

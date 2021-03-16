using System;
using System.Collections.Generic;
using System.Text;

namespace SaveLoadApp
{
    [Serializable]
    public class ProgramParams: SerializableOperations
    {
        /// <summary>
        /// Колличество полупериодов пропущенных перед началом длинной калибровки
        /// </summary>
        public UInt32 SkipLongCal { get; set; } = 3;
        /// <summary>
        /// Колличество полупериодов использованных для длинной калибровки
        /// </summary>
        public UInt32 UseLongCal { get; set; }  = 10;
        /// <summary>
        /// Колличество полупериодов использованных для определения накопленного угла после длинной калибровки
        /// </summary>
        public UInt32 FlyLongCal { get; set; } = 10;

        
    }
}

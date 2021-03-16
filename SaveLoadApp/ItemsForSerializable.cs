using System;
using System.Collections.Generic;
using System.Text;

namespace SaveLoadApp
{
    [Serializable]
    public class ItemsForSerializable
    {

        public ItemsForSerializable()
        {
                
        }

        public List<ItemsForSerializable> itemsForSerializablesList = new List<ItemsForSerializable>();

        public string NameItem { get; set; }
        //public string TypeItem { get; set; }
        public object ValueItem { get; set; }

        public ItemsForSerializable(string nameItem, object valueItem)
        {
            NameItem = nameItem;
         //   TypeItem = valueItem.GetType().FullName;
            ValueItem = valueItem;
        }
        public void Save()
        {

        }
        public void Load()
        {

        }
    }
}

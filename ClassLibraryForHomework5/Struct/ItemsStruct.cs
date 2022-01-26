using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForHomework5.Struct
{
    public struct ItemsStruct
    {
        public string Name;
        public double Price;
        public int Id;
        
        public ItemsStruct(string NameIn, double PriceIn, int IdIn)
        {
            Name = NameIn;
            Price = PriceIn;    
            Id = IdIn;
        }


}


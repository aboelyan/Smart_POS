using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Smart_POS.Classes
{
    public class comboItemClass
    {
        public comboItemClass(string _Id, string _Des)
        {
            Id = _Id;
            Des = _Des;
        }
        public string Id { get; set; }
        public string Des { get; set; }
        public override string ToString()
        {
            
                return Des;
     
        }
    }
}

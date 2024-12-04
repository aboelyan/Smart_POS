using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_POS.Classes
{
    public static class declerationClass
    {
        public static int userId;
        public static string userFullName;
        public static Dictionary<string,Object> systemOptions;
        public static List<modelPermition> permitions;
    }

    public class modelPermition
    {
        public string mainScreen { get; set; }
        public string permition { get; set; }
        public bool theCase { get; set; }
    }
}

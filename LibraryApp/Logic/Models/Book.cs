using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public partial class Book
    {
        public bool IsAvailable
        {
            get
            {
                if (Records.Count != 0 && Records.LastOrDefault().IsTaken)
                    return false;
                return true;
            }
        }
        public string NameForRecord 
        {
            get
            {
                return $"{Id} - «{Name}» {Author}, {Year}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Textbook :BaseBookClass
    {
        public string Subject { get; set; }

        public override string GetInfo()
        {
            return $"{Title} (Textbook - {Subject}) by {Author}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Ebook : BaseBookClass
    {
        public string FileFormat { get; set; }

        public override string GetInfo()
        {
            return $"{Title} (Ebook - {FileFormat}) by {Author}";
        }
    }
}

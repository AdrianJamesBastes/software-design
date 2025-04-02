using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class AudioBook : BaseBookClass
    {
        public double Duration { get; set; }
        public string Narrator { get; set; }

        public override string GetInfo()
        {
            return $"{Title} (Audiobook - {Duration} hours) narrated by {Narrator}";
        }
    }
}

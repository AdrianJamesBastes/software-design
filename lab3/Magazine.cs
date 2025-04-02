using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Magazine : BaseBookClass
    {
        internal int IssueNumber;

        public int Issuenumber { get; set; }
    public override string GetInfo()
    {
        return $"{Title} - Issue {IssueNumber}";
    }
}
}

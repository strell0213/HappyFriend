using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmilDiplom
{
    internal class Donate
    {
        public int DonateID { get; set; }
        public int AmountDonate { get; set; }
        private string Name, Currency, DateDonate, Comment;

        public string name { get { return Name; } set {Name = value;} }
        public string currency { get { return Currency; } set { Currency = value;} }
        public string dateDonate { get { return DateDonate; } set { DateDonate = value; }  }
        public string comment { get { return Comment; } set { Comment = value;} }

        public Donate() { }
        public Donate(string Name, int AmountDonate, string Currency,string Comment, string DateDonate) { 
            this.Name= Name;
            this.AmountDonate= AmountDonate;
            this.Currency= Currency;
            this.Comment= Comment;
            this.DateDonate= DateDonate;

        }
    }
}

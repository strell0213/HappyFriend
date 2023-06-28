using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AmilDiplom
{
    internal class New
    {
        [Key]
        public int NewID { get; set; }
        private string Title, DatePost, MainText, FromAdmins, PathImage;
        
        public string title { get { return Title; } set { Title = value; } }
        public string datePost { get { return DatePost; } set { DatePost = value; } }
        public string mainText { get { return MainText; } set { MainText = value; } }
        public string fromAdmins { get { return FromAdmins; } set { FromAdmins = value; } }
        public string pathImage { get { return PathImage; } set { PathImage = value; } }

        public New() { }
        public New(string Title, string DatePost, string MainText, string FromAdmins, string PathImage)
        {
            this.Title = Title;
            this.DatePost = DatePost;
            this.MainText = MainText;
            this.FromAdmins = FromAdmins;
            this.PathImage = PathImage;
        }
    }
}

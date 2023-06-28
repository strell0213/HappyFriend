using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmilDiplom
{

    internal class Animal
    {
        [Key]
        public int AnimalID { get; set; }
        private string Name, History, PathImage;
        public string name { get { return Name; } set { Name = value; } }
        public string history { get { return History; } set { History = value; } }
        public string pathImage { get { return PathImage; } set { PathImage = value; } }

        public Animal() { }
        public Animal(string Name, string History, string pathImage)
        {
            this.Name = Name;
            this.History = History;
            this.pathImage = pathImage;
        }
    }
}

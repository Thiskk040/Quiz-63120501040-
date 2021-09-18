using System.Collections.Generic;
namespace _47
{
    class Flower
    {
        public int ID;
        public string name;
        public string description;
        public int height;
        public string round;

        public Flower(int id, string Name, string Description, int Height, string Round)
        {
            this.ID = id;
            this.name = Name;
            this.description = Description;
            this.height = Height;
            this.round = Round;
        }
    }
}

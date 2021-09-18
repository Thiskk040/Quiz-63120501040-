using System;
namespace _47
{

    class Sunflower : Flower
    {
        public int numbersunflower;
        public string sunflowername;

        public Sunflower(int id, string Name, string Description, int Height, string Round, string sunflowername, int numbersunflower) : base(id, Name, Description, Height, Round)
        {
            this.numbersunflower = numbersunflower;
            this.sunflowername = sunflowername;
            return;
        }
    }
}

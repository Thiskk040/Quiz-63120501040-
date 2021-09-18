using System.Collections.Generic;
;
namespace _47
{
    class Rose : Flower
    {
        List<Rose>listroses;
        public string Rosename;

        public Rose(int id, string Name, string Description, int Height, string Round, string Rosename) : base(id, Name, Description, Height, Round)
        {
            this.Rosename = Rosename;
            return;
        }
        
    }
}

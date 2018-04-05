using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class BirdViewModel
    {
        public static List<Bird> Get3TestBirds()
        {
            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird() { Name = "Angry", ImgFile = "BirdRed.png", Value = 1000 });
            birds.Add(new Bird() { Name = "Nasty", ImgFile = "BirdBlack.png", Value = 1000 });
            birds.Add(new Bird() { Name = "Curious", ImgFile = "BirdYellow.png", Value = 1000 });

            return birds;
        }
    }
}

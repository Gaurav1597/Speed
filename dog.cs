using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed
{
    class Dog

    {
        public int Location = 0;
        public static Random MyRandom = new Random(); //declared random object as static to avoid same random number

        public static int StartingPosition1 { get; set; }
        public static int RacetrackLength1 { get; set; }
      public PictureBox DogPictureBox { get; set; } = null;
     //  public PictureBox DogPictureBox { get; internal set; }

        // generation across all  Dog objects

        public static bool Run(Dog obj)
        {
            int distance = MyRandom.Next(1, 10);
             if (obj.DogPictureBox != null)
            obj.MoveDogPictureBox(distance);

            obj.Location += distance;
            if (obj.Location >= (RacetrackLength1 - StartingPosition1))
            {
                return true;
            }
            return false;
        }

        public void StartPosition()
        {
            MoveDogPictureBox(-Location); //reset location to -ve distance ie. to starting point
            Location = 0;

        }

        public void MoveDogPictureBox(int distance)
        {
            Point p = DogPictureBox.Location;
            p.X += distance;
            DogPictureBox.Location = p; //move  Dog in x-axis
        }
    }
}


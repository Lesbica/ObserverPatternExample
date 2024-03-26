using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.Observer
{
    public class AfternoonObs : ITimeObserver
    {
        PictureBox pictureboxbg;
        PictureBox pictureboxdird;
        PictureBox pictureboxhouse;
        PictureBox pictureboxtree;

        public AfternoonObs(PictureBox pictureboxbg, PictureBox pictureboxdird, PictureBox pictureboxhouse, PictureBox pictureboxtree)
        {
            this.pictureboxbg = pictureboxbg;
            this.pictureboxhouse = pictureboxhouse;
            this.pictureboxdird = pictureboxdird;
            this.pictureboxtree = pictureboxtree;
        }

        public void Update(TimeOfDay time)
        {
            if(time == TimeOfDay.Afternoon)
            {
                pictureboxbg.Image = Image.FromFile("img/afternoon.jpg");
                pictureboxdird.Image = Image.FromFile("img/lastochka.png");
                pictureboxhouse.Image = Image.FromFile("img/day house.png");
                pictureboxtree.Image = Image.FromFile("img/day tree.png");
            }
        }
    }
}

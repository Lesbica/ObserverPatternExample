using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.Observer
{
    public class NightObs : ITimeObserver
    {
        PictureBox pictureboxbg;
        PictureBox pictureboxdird;
        PictureBox pictureboxhouse;
        PictureBox pictureboxtree;

        public NightObs(PictureBox pictureboxbg, PictureBox pictureboxdird, PictureBox pictureboxhouse, PictureBox pictureboxtree)
        {
            this.pictureboxbg = pictureboxbg;
            this.pictureboxhouse = pictureboxhouse;
            this.pictureboxdird = pictureboxdird;
            this.pictureboxtree = pictureboxtree;
        }

        public void Update(TimeOfDay time)
        {
            if (time == TimeOfDay.Night)
            {
                pictureboxbg.Image = Image.FromFile("img/night.jpg");
                pictureboxdird.Image = Image.FromFile("img/duolingo.png");
                pictureboxhouse.Image = Image.FromFile("img/night house.png");
                pictureboxtree.Image = Image.FromFile("img/night tree.png");
            }
        }
    }
}

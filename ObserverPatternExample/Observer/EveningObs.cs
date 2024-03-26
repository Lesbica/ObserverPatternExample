using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.Observer
{
    public class EveningObs : ITimeObserver
    {
        PictureBox pictureboxbg;
        PictureBox pictureboxdird;
        PictureBox pictureboxhouse;
        PictureBox pictureboxtree;

        public EveningObs(PictureBox pictureboxbg, PictureBox pictureboxdird, PictureBox pictureboxhouse, PictureBox pictureboxtree)
        {
            this.pictureboxbg = pictureboxbg;
            this.pictureboxhouse = pictureboxhouse;
            this.pictureboxdird = pictureboxdird;
            this.pictureboxtree = pictureboxtree;
        }

        public void Update(TimeOfDay time)
        {
            if (time == TimeOfDay.Evening)
            {
                pictureboxbg.Image = Image.FromFile("img/evening.jpg");
                pictureboxdird.Image = Image.FromFile("img/eagle.png");
                pictureboxhouse.Image = Image.FromFile("img/evening house.png");
                pictureboxtree.Image = Image.FromFile("img/evening tree.png");
            }
        }
    }
}

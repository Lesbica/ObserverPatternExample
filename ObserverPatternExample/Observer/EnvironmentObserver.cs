using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.Observer
{
    public class EnvironmentObserver : ITimeObserver
    {
        PictureBox pictureboxbg;
        PictureBox pictureboxdird;
        PictureBox pictureboxhouse;
        PictureBox pictureboxtree;

        public EnvironmentObserver(PictureBox pictureboxbg, PictureBox pictureboxdird, PictureBox pictureboxhouse, PictureBox pictureboxtree)
        {
            this.pictureboxbg = pictureboxbg;
            this.pictureboxhouse = pictureboxhouse;
            this.pictureboxdird = pictureboxdird;
            this.pictureboxtree = pictureboxtree;
        }

        public void Update(TimeOfDay time)
        {
            switch (time)
            {
                case TimeOfDay.Morning:
                    pictureboxbg.Image = Image.FromFile("img/morning.jpg");
                    pictureboxdird.Image = Image.FromFile("img/lastochka.png");
                    pictureboxhouse.Image = Image.FromFile("img/morning house.png");
                    pictureboxtree.Image = Image.FromFile("img/morning tree.png");
                    break;
                case TimeOfDay.Afternoon:
                    pictureboxbg.Image = Image.FromFile("img/afternoon.jpg");
                    pictureboxdird.Image = Image.FromFile("img/lastochka.png");
                    pictureboxhouse.Image = Image.FromFile("img/day house.png");
                    pictureboxtree.Image = Image.FromFile("img/day tree.png");
                    break;
                case TimeOfDay.Evening:
                    pictureboxbg.Image = Image.FromFile("img/evening.jpg");
                    pictureboxdird.Image = Image.FromFile("img/eagle.png");
                    pictureboxhouse.Image = Image.FromFile("img/evening house.png");
                    pictureboxtree.Image = Image.FromFile("img/evening tree.png");
                    break;
                case TimeOfDay.Night:
                    pictureboxbg.Image = Image.FromFile("img/night.jpg");
                    pictureboxdird.Image = Image.FromFile("img/duolingo.png");
                    pictureboxhouse.Image = Image.FromFile("img/night house.png");
                    pictureboxtree.Image = Image.FromFile("img/night tree.png");
                    break;
            }
        }
    }
}

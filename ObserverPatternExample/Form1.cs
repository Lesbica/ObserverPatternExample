using ObserverPatternExample.Observer;

namespace ObserverPatternExample
{
    public partial class Form1 : Form
    {
        private TimeObservable timeObservable = new TimeObservable();

        public Form1()
        {
            InitializeComponent();
            InitializeObservers();
        }

        private void InitializeObservers()
        {
            // Create environment observer and register it with the time observable
            EnvironmentObserver environmentObserver = new EnvironmentObserver(pictureBox1, pictureboxdird, pictureboxhouse, pictureboxtree);
            timeObservable.RegisterObserver(environmentObserver);
        }

        private void morningButton_Click(object sender, EventArgs e)
        {
            timeObservable.SetTime(TimeOfDay.Morning);
        }

        private void afternoonButton_Click(object sender, EventArgs e)
        {
            timeObservable.SetTime(TimeOfDay.Afternoon);
        }

        private void eveningButton_Click(object sender, EventArgs e)
        {
            timeObservable.SetTime(TimeOfDay.Evening);
        }

        private void nightButton_Click(object sender, EventArgs e)
        {
            timeObservable.SetTime(TimeOfDay.Night);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                pictureboxhouse.Visible = true;
            }else pictureboxhouse.Visible = false;

            if (checkBox2.Checked)
            {
                pictureboxtree.Visible = true;
            }
            else pictureboxtree.Visible = false;

            if (checkBox3.Checked)
            {
                pictureboxdird.Visible = true;
            }
            else pictureboxdird.Visible = false;
        }
    }
}

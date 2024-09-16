using System;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {

        private int loadingBarValue;
        public LoadingScreen()
        {
            InitializeComponent();
        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingbarTimer.Start();
        }

        private void loadingbarTimer_Tick(object sender, EventArgs e)
        {

            loadingBarValue += 1;

            lblLoadingProgress.Text = loadingBarValue.ToString() + "%";   //aus 1 = "1" | int to string
            loadingProgressbar.Value = loadingBarValue;   //das selbe wie bei den Eigenschaften

            if (loadingBarValue >= loadingProgressbar.Maximum) //damit haben wir keine magicnumber
            {
                loadingbarTimer.Stop();
                //finish loadng
            }

        }

       
    }
}
//Lektion 105. minute 6,22
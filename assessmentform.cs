using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace drumtuto_main
{
    public partial class assessmentform : Form
    {
        #region variables
        int perfectcounter = 0;
        int greatcounter = 0;
        int goodcounter = 0;
        int misscounter = 0;
        int tempscorecounter = 0;
        int totalscorecounter = 0;
        int totalmultiplier = 0;
        int choicecounter = 1;
        bool failedflag = false;
        public static bool rockflag = false;
        public static bool classicflag = false;
        public static bool jazzflag = false;
        public static bool basicbeats1flag = false;
        public static bool basicbeats2flag = false;
        public static bool restartflag = false;
        bool indicatorled = false;
        SoundPlayer choicess;
        SoundPlayer enter;
        #endregion

       
        public assessmentform()
        {
            perfectcounter = drumstutos.perfectcounter;
            greatcounter = drumstutos.greatcounter;
            goodcounter = drumstutos.goodcounter;
            misscounter = drumstutos.misscounter;
            tempscorecounter = drumstutos.scorecounter;
            totalmultiplier = drumstutos.energymultipliercounter;
            failedflag = drumstutos.failedflag;
            indicatorled = Settings.indicatorled;
            choicess = new SoundPlayer(drumtuto_main.Properties.Resources.tom);
            enter = new SoundPlayer(drumtuto_main.Properties.Resources.enter);
            InitializeComponent();
        }

        public void assessmentstar() 
        {

            if (failedflag == false && perfectcounter > misscounter && misscounter == 0 || failedflag == false && greatcounter > misscounter && misscounter == 0 || failedflag == false && goodcounter > misscounter && misscounter == 0)
        {
            pbstars1.Image = drumtuto_main.Properties.Resources._3star;
        }
        else if (failedflag == false && perfectcounter > misscounter && misscounter >= 0 || failedflag == false && greatcounter > misscounter && misscounter >= 0 || failedflag == false && goodcounter > misscounter && misscounter >= 0)
        {
            pbstars1.Image = drumtuto_main.Properties.Resources._2_star;
        }
        else if (failedflag == false && perfectcounter < misscounter && misscounter >= 0 || failedflag == false && greatcounter < misscounter && misscounter >= 0 || failedflag == false && goodcounter < misscounter && misscounter >= 0)
        {
            pbstars1.Image = drumtuto_main.Properties.Resources._1_star;
        }
        else if(failedflag == true && tempscorecounter <=0 || misscounter > perfectcounter && misscounter > goodcounter && misscounter > greatcounter)
        {
            pbstars1.Image = drumtuto_main.Properties.Resources.btnfailed;
        }
        }

        public void choiceshighlight(int mainchoicecounter1)
        {
            switch (mainchoicecounter1)
            {
                case 1:
                    {
                        
                        btnexit.Size = new Size(280, 80);
                        btnrestart.Size = new Size(235, 53);
                        break;
                    }
                case 2:
                    {

                        btnrestart.Size = new Size(280, 80);
                        btnexit.Size = new Size(235, 53);
                        break;
                    }
              
            }

        }

        private void assessmentform_Load(object sender, EventArgs e)
        {
            perfect1.Text = perfectcounter.ToString();
            great1.Text = greatcounter.ToString();
            good1.Text = goodcounter.ToString();
            miss1.Text = misscounter.ToString();
            multi1.Text = totalmultiplier.ToString();
            choiceshighlight(choicecounter);
            if (indicatorled == true)
            {
                try
                {
                    port1.Open();
                    port1.WriteLine("ledoff");
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                }
                finally
                {
                    port1.Dispose();
                    port1.Close();
                }
            }
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempscorecounter > 0)
            {
                while (totalscorecounter <= tempscorecounter)
                {

                    totalscore1.Text = totalscorecounter.ToString();
                    totalscorecounter++;
                }
            }
            else
            {
                timer1.Stop();
            }

            if (totalmultiplier > 0)
            {
                int finalscore = totalscorecounter * totalmultiplier;
                totalscore1.Text = finalscore.ToString();

            }
            else 
            {
                timer1.Stop();
            }
            assessmentstar();
            //Thread.Sleep(500);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonpress1(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='v')
            {
                enter.Play();
                if(choicecounter == 1)
                {
                    menu2 b = new menu2();
                    b.Show();
                    b.Focus();
                    this.Close();
                }

                if(choicecounter == 2)
                {
                    drumstutos.misscounter = 0;
                    drumstutos.perfectcounter = 0;
                    drumstutos.goodcounter = 0;
                    drumstutos.combocounter = 0;
                    drumstutos.energymultipliercounter = 0;
                    drumstutos.scorecounter = 0;
                    drumstutos.greatcounter = 0;
                   
                    drumstutos tutos = new drumstutos();
                    tutos.Show();
                    tutos.Focus();
                    this.Close();
                }
            }

            if (e.KeyChar == 'x') 
            {
                choicess.Play();
             if(choicecounter >=1)
             {
                 choicecounter += 1;
                 choiceshighlight(choicecounter);

                 if(choicecounter >2)
                 {
                     choicecounter = 1;
                     choiceshighlight(choicecounter);
                 }
             }

            }
        }
    }
}

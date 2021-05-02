using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;
namespace drumtuto_main
{
    public partial class Settings : Form
    {
        #region variables
        SoundPlayer choicess;
        SoundPlayer enter;
        public int choicecounter = 1;
        public int exitchoicecounter = 0;
        public int subchoicecounter1 = 0;
        public int subchoicecounter2 = 0;
        public int entercounter = 0;
        bool extflag = false;
        public static bool mode = true;
        public static bool indicatorled = true; //change back to false 
        bool tempmode = false;
        bool tempindicatorled = false;
        #endregion

        public Settings()
        {
            InitializeComponent();
            choicess = new SoundPlayer(drumtuto_main.Properties.Resources.tom);
            enter = new SoundPlayer(drumtuto_main.Properties.Resources.enter);
        }

        public void mainchoicesscroll(int choicecounter1)
        {
            switch (choicecounter1)
            {
                case 1:
                    {
                        label1.Text = "This Option sets the scoring \ncalibration,To student \nor prefessional mode.";
                        btncalibration.Size = new Size(280, 80);
                        btnsound.Size = new Size(235, 53);
                        btnback.Size = new Size(235, 53);
                        break;
                    }
                case 2:
                    {
                        label1.Text = "This Option sets the \nled indication, To on or off mode.";
                        btnsound.Size = new Size(280, 80);
                        btncalibration.Size = new Size(235, 53);
                        btnback.Size = new Size(235, 53);
                        break;
                    }

                case 3:
                    {
                        label1.Text = "This Option gets \nthe user back to the main menu";
                        btnback.Size = new Size(280, 80);
                        btnsound.Size = new Size(235, 53);
                        btncalibration.Size = new Size(235, 53);
                        break;
                    }
            }

        }
       
        public void subchoicesscroll1(int scrollcounter1)
        {
            switch (scrollcounter1)
            {
                case 0:
                    {
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnstudent;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnprofessional;
                        btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
                 
                        opt1.Visible = false;
                        opt2.Visible = false;
                        
                        btnback2.Visible = false;

                        opt1.Size = new Size(280, 80);
                        opt2.Size = new Size(235, 53);
                        
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 1:
                    {

                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnstudent;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnprofessional;
                        btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        
                        btnback2.Visible = true;

                        opt1.Size = new Size(280, 80);
                        opt2.Size = new Size(235, 53);
                        
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 2:
                    {
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnstudent;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnprofessional;
                        btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
                        
                        opt1.Visible = true;
                        opt2.Visible = true;
                        
                        btnback2.Visible = true;

                        opt2.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 3:
                    {
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnstudent;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnprofessional;
                        btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
                        
                        opt1.Visible = true;
                        opt2.Visible = true;
                        
                        btnback2.Visible = true;

                        btnback2.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        opt2.Size = new Size(235, 53);
                        
                        break;
                    }
             
            }

        } //sub1 choices highlight

        public void subchoicesscroll2(int scrollcounter2)
        {
            switch (scrollcounter2)
            {
                case 0:
                    {
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnon;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnoff;
                        btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
                        opt1.Visible = false;
                        opt2.Visible = false;
                       
                        btnback2.Visible = false;

                        opt1.Size = new Size(280, 80);
                        opt2.Size = new Size(235, 53);
                        
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 1:
                    {
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnon;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnoff;
                        btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        
                        btnback2.Visible = true;

                        opt1.Size = new Size(280, 80);
                        opt2.Size = new Size(235, 53);
                        
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 2:
                    {
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnon;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnoff;
                        btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        
                        btnback2.Visible = true;

                        opt2.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 3:
                    {
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnon;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnoff;
                        btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        
                        btnback2.Visible = true;

                        btnback2.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        opt2.Size = new Size(235, 53);
                        
                        break;
                    }
            
            }

        } //sub1 choices highlight

        public void exitchoicescroll(int extchoice) 
        {
        switch(extchoice)
        {


            case 1:
                {
                    label1.Text = "Do you want to save your setting?\n\r(the setting will close \n\rupon choosing a choice)";
                    opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnyes;
                    opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnno;

                    opt1.Visible = true;
                    opt2.Visible = true;

                    opt1.Size = new Size(280, 80);
                    opt2.Size = new Size(235, 53);


                    break;
                }
            case 2:
                {
                    label1.Text = "Do you want to save your setting?\n\r(the setting will close \n\rupon choosing a choice)";
                    opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnyes;
                    opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnno;

                    opt1.Visible = true;
                    opt2.Visible = true;

                    opt2.Size = new Size(280, 80);
                    opt1.Size = new Size(235, 53);

                    break;
                }
        }
        }

        public void subenterfunction1(int entercounters1)
        {
            switch (entercounters1)
            {

                case 1:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                        
                        btnback2.Visible = false;
                        this.subchoicecounter1 = subchoicecounter1 = 0;
                        
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        tempmode = false;
                        extflag = true;
                        break;
                    }
                case 2:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                       
                        btnback2.Visible = false;
                        this.subchoicecounter1 = subchoicecounter1 = 0;
                        
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        tempmode = true;
                        extflag = true;
                        break;
                    }
                case 3:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                        btnback2.Visible = false;
                        this.subchoicecounter1 = subchoicecounter1 = 0;
                        entercounter = 0;
                        extflag = false;
                        break;
                    }
            }
        }

        public void subenterfunction2(int entercounters2)
        {
            switch (entercounters2)
            {

                case 1:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                       
                        btnback2.Visible = false;
                        this.subchoicecounter2 = subchoicecounter2 = 0;
                       
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        tempindicatorled = true;
                        extflag = true;
                        break;
                    }
                case 2:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                        
                        btnback2.Visible = false;
                        this.subchoicecounter2 = subchoicecounter2 = 0;
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        tempindicatorled = false;
                        extflag = true;
                        break;
                    }
                case 3:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                        
                        btnback2.Visible = false;
                        this.subchoicecounter2 = subchoicecounter2 = 0;
                        entercounter = 0;
                        extflag = false;
                        break;
                    }
            }
        }

        public void exitenterfunction(int entercounters3) 
        {
        switch(entercounters3)
        {
            case 1:
                {
                    mode = tempmode;
                    indicatorled = tempindicatorled;
                    menu b = new menu();
                    b.Focus();
                    b.Show();
                    this.Close();
                    break;
                }

            case 2:
                {
                    menu b = new menu();
                    b.Focus();
                    b.Show();
                    this.Close();
                    break;
                }
        }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = drumtuto_main.Properties.Resources.settingbg;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btncalibration.BackgroundImage = drumtuto_main.Properties.Resources.btnscoringcalibration;
            btnsound.BackgroundImage = drumtuto_main.Properties.Resources.btnindicatorleds;
            btnback.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
            btnmenu.BackgroundImage = drumtuto_main.Properties.Resources.btnsettings;
            mainchoicesscroll(choicecounter);
        }

        private void btnpress1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'x')
            {

                choicess.Play();
                if (subchoicecounter1 == 0 && subchoicecounter2 == 0 && exitchoicecounter==0)
                {
                    choicecounter += 1;
                    if (choicecounter > 3)
                    {
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                    }
                    mainchoicesscroll(choicecounter);

                }

                else if (subchoicecounter1 >= 1)
                {
                    subchoicecounter1 += 1;

                    if (subchoicecounter1 > 3)
                    {
                        subchoicecounter1 = 1;
                        subchoicesscroll1(subchoicecounter1);
                    }
                    subchoicesscroll1(subchoicecounter1);

                }
                else if (subchoicecounter2 >= 1)
                {
                    subchoicecounter2 += 1;

                    if (subchoicecounter2 > 3)
                    {
                        subchoicecounter2 = 1;
                        subchoicesscroll2(subchoicecounter2);
                    }
                    subchoicesscroll2(subchoicecounter2);

                }
                else if (exitchoicecounter >= 1)
                {
                    exitchoicecounter += 1;

                    if (exitchoicecounter > 2)
                    {
                        exitchoicecounter = 1;
                        exitchoicescroll(exitchoicecounter);
                    }
                    exitchoicescroll(exitchoicecounter);

                }
            }

            if (e.KeyChar == 'v')
            {
                enter.Play();
                if (choicecounter == 1 && subchoicecounter1 == 0 && subchoicecounter2 == 0 && entercounter == 0)
                {

                    subchoicecounter1 = 1;
                    entercounter += 1;
                    subchoicesscroll1(subchoicecounter1);

                }
                if (choicecounter == 2 && subchoicecounter1 == 0 && subchoicecounter2 == 0 && entercounter == 0)
                {
                    subchoicecounter2 = 1;
                    entercounter += 1;
                    subchoicesscroll2(subchoicecounter2);
                }

                if (choicecounter == 3 && subchoicecounter1 == 0 && subchoicecounter2 == 0 && entercounter == 0)
                {
                    if (extflag == true)
                    {
                        exitchoicecounter = 1;
                        exitchoicescroll(exitchoicecounter);
                    }
                    else 
                    {
                        menu b = new menu();
                        b.Focus();
                        b.Show();
                        this.Close();
                    }

                }

               
                //first subchoice enter function
                if (subchoicecounter1 == 1)
                {
                    entercounter++;
                    if (entercounter > 2)
                    {
                        subenterfunction1(subchoicecounter1);
                    }
                }
                if (subchoicecounter1 == 2)
                {
                    entercounter++;
                    if (entercounter > 2)
                    {
                        subenterfunction1(subchoicecounter1);
                    }
                }
                if (subchoicecounter1 == 3)
                {
                    entercounter++;
                    if (entercounter > 2)
                    {
                        subenterfunction1(subchoicecounter1);
                    }
                }
                if (subchoicecounter1 == 3)
                {

                    subchoicecounter1 = 0;
                    subchoicecounter2 = 0;
                    subchoicesscroll1(subchoicecounter1);
                    entercounter = 0;
                }

                //second subchoice enter function

                if (subchoicecounter2 == 1)
                {
                    entercounter++;
                    if (entercounter > 2)
                    {
                        subenterfunction2(subchoicecounter2);
                    }
                }
                if (subchoicecounter2 == 2)
                {
                    entercounter++;
                    if (entercounter > 2)
                    {
                        subenterfunction2(subchoicecounter2);
                    }
                }
                if (subchoicecounter2 == 3)
                {
                    entercounter++;
                    if (entercounter > 2)
                    {
                        subenterfunction2(subchoicecounter2);
                    }
                }

                if (subchoicecounter2 == 3)
                {

                    subchoicecounter1 = 0;
                    subchoicecounter2 = 0;
                    subchoicesscroll2(subchoicecounter2);
                    entercounter = 0;
                }

                if (exitchoicecounter == 1)
                {
                    entercounter++;
                    if (entercounter >= 2)
                    {
                        exitenterfunction(exitchoicecounter);
                    }
                }
                if (exitchoicecounter == 2)
                {
                    entercounter++;
                    if (entercounter >= 2)
                    {
                        exitenterfunction(exitchoicecounter);
                    }
                }

            }
        }

    }
}

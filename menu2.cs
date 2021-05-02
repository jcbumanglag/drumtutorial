using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
// objectives
// beautification of ui 
// combine with main gameplay
namespace drumtuto_main
{
    public partial class menu2 : Form
    {
        SoundPlayer choicess;
        SoundPlayer enter;
        
        public int choicecounter = 1;
        public int subchoicecounter1 = 0;
        public int subchoicecounter2 = 0;
        public int entercounter = 0;

        public static bool rockflag = false;
        public static bool classicflag = false;
        public static bool jazzflag = false;
        public static bool basicbeats1flag = false;
        public static bool basicbeats2flag = false;
        public static bool basicbeats3flag = false;

        public menu2()
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
                        label1.Text = "This set of tutorial \nwill help the user \nto learn basic beats \nand practice on \nhow to be dexterous."; 
                        btnwarmup.Size = new Size(280, 80);
                        btntutor.Size = new Size(235, 53);
                        btnback.Size = new Size(235, 53);
                        break;
                    }
                case 2:
                    {
                        label1.Text = "This set of tutorial \nwill help the user \nto learn basic genres."; 
                        btntutor.Size = new Size(280, 80);
                        btnwarmup.Size = new Size(235, 53);
                        btnback.Size = new Size(235, 53);
                        break;
                    }

                case 3:
                    {
                        label1.Text = "This option will return \nto the main menu."; 
                        btnback.Size = new Size(280, 80);
                        btnwarmup.Size = new Size(235, 53);
                        btntutor.Size = new Size(235, 53);

                        break;
                    }
            }

        }//primary choices highlight

        public void subchoicesscroll1(int scrollcounter1)
        {
            switch (scrollcounter1)
            {
                case 0: 
                    {
                        label1.Text = "This tutorial will help the user \nto learn the basic beats."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btn3beats;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btndex1;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btndex2;
                        opt1.Visible = false;
                        opt2.Visible = false;
                        opt3.Visible = false;
                        btnback2.Visible = false;

                        opt1.Size = new Size(280, 80);
                        opt2.Size = new Size(235, 53);
                        opt3.Size = new Size(235, 53);
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 1:
                    {
                        label1.Text = "This tutorial will help the user \nto learn the basic beats."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btn3beats;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btndex1;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btndex2;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        opt3.Visible = true;
                        btnback2.Visible = true;

                        opt1.Size = new Size(280, 80);
                        opt2.Size = new Size(235, 53);
                        opt3.Size = new Size(235, 53);
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 2:
                    {
                        label1.Text = "This tutorial will help to \nenhance his/her dexterity."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btn3beats;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btndex1;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btndex2;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        opt3.Visible = true;
                        btnback2.Visible = true;

                        opt2.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        opt3.Size = new Size(235, 53);
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 3:
                    {
                        label1.Text = "This tutorial will help to \nenhance his/her dexterity."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btn3beats;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btndex1;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btndex2;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        opt3.Visible = true;
                        btnback2.Visible = true;

                        opt3.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        opt2.Size = new Size(235, 53);
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 4:
                    {
                        label1.Text = "This option will return \nto the main choices."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btn3beats;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btndex1;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btndex2;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        opt3.Visible = true;
                        btnback2.Visible = true;

                        btnback2.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        opt2.Size = new Size(235, 53);
                        opt3.Size = new Size(235, 53);
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
                        label1.Text = "This tutorial will help \nthe user understand rock."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnrock;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnclassic;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btnjazz;
                        opt1.Visible = false;
                        opt2.Visible = false;
                        opt3.Visible = false;
                        btnback2.Visible = false;

                        opt1.Size = new Size(280, 80);
                        opt2.Size = new Size(235, 53);
                        opt3.Size = new Size(235, 53);
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 1:
                    {
                        label1.Text = "This tutorial will help \nthe user understand rock."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnrock;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnclassic;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btnjazz;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        opt3.Visible = true;
                        btnback2.Visible = true;

                        opt1.Size = new Size(280, 80);
                        opt2.Size = new Size(235, 53);
                        opt3.Size = new Size(235, 53);
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 2:
                    {
                        label1.Text = "This tutorial will help \nthe user understand classic."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnrock;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnclassic;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btnjazz;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        opt3.Visible = true;
                        btnback2.Visible = true;

                        opt2.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        opt3.Size = new Size(235, 53);
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 3:
                    {
                        label1.Text = "This tutorial will help \nthe user understand jazz."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnrock;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnclassic;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btnjazz;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        opt3.Visible = true;
                        btnback2.Visible = true;

                        opt3.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        opt2.Size = new Size(235, 53);
                        btnback2.Size = new Size(235, 53);
                        break;
                    }
                case 4:
                    {
                        label1.Text = "This option will return \nto the main choices."; 
                        opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnrock;
                        opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnclassic;
                        opt3.BackgroundImage = drumtuto_main.Properties.Resources.btnjazz;
                        opt1.Visible = true;
                        opt2.Visible = true;
                        opt3.Visible = true;
                        btnback2.Visible = true;

                        btnback2.Size = new Size(280, 80);
                        opt1.Size = new Size(235, 53);
                        opt2.Size = new Size(235, 53);
                        opt3.Size = new Size(235, 53);
                        break;
                    }
            }

        } //sub1 choices highlight

        public void subenterfunction1(int entercounters1)
        {
            switch (entercounters1)
            {
                
                case 1:
                    {
                    
                        opt1.Visible = false;
                        opt2.Visible = false;
                        opt3.Visible = false;
                        btnback2.Visible = false;
                        this.subchoicecounter1 = subchoicecounter1 = 0;
                        //MessageBox.Show("Game Entered");
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        rockflag = false;
                        classicflag = false;
                        jazzflag = false;
                        basicbeats1flag = true;
                        basicbeats2flag = false;
                        basicbeats3flag = false;
                        drumstutos b = new drumstutos();
                        b.Show();
                        b.Focus();
                        this.Close();
                        break;
                    }
                case 2:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                        opt3.Visible = false;
                        btnback2.Visible = false;
                        this.subchoicecounter1 = subchoicecounter1 = 0;
                        //MessageBox.Show("Game Entered");
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        rockflag = false;
                        classicflag = false;
                        jazzflag = false;
                        basicbeats1flag = false;
                        basicbeats2flag = true;
                        basicbeats3flag = false;
                        drumstutos b = new drumstutos();
                        b.Show();
                        b.Focus();
                        this.Close();
                        break;
                    }
                case 3:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                        opt3.Visible = false;
                        btnback2.Visible = false;
                        this.subchoicecounter1 = subchoicecounter1 = 0;
                        //MessageBox.Show("Game Entered");
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        basicbeats1flag = false;
                        basicbeats2flag = false;
                        basicbeats3flag = true;
                        drumstutos b = new drumstutos();
                        b.Show();
                        b.Focus();
                        this.Close();
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
                        opt3.Visible = false;
                        btnback2.Visible = false;
                        this.subchoicecounter2 = subchoicecounter2 = 0;
                        //MessageBox.Show("Game Entered");
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        rockflag = true;
                        classicflag = false;
                        jazzflag = false;
                        basicbeats1flag = false;
                        basicbeats2flag = false;
                        basicbeats3flag = false;
                        drumstutos b = new drumstutos();
                        b.Show();
                        b.Focus();
                        this.Close();
                        break;
                    }
                case 2:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                        opt3.Visible = false;
                        btnback2.Visible = false;
                        this.subchoicecounter2 = subchoicecounter2 = 0;
                        //MessageBox.Show("Game Entered");
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        rockflag = false;
                        classicflag = true;
                        jazzflag = false;
                        basicbeats1flag = false;
                        basicbeats2flag = false;
                        basicbeats3flag = false;
                        drumstutos b = new drumstutos();
                        b.Show();
                        b.Focus();
                        this.Close();
                        break;
                    }
                case 3:
                    {

                        opt1.Visible = false;
                        opt2.Visible = false;
                        opt3.Visible = false;
                        btnback2.Visible = false;
                        this.subchoicecounter2 = subchoicecounter2 = 0;
                        //MessageBox.Show("Game Entered");
                        entercounter = 0;
                        choicecounter = 1;
                        mainchoicesscroll(choicecounter);
                        rockflag = false;
                        classicflag = false;
                        jazzflag = true;
                        basicbeats1flag = false;
                        basicbeats2flag = false;
                        basicbeats3flag = false;
                        drumstutos b = new drumstutos();
                        b.Show();
                        b.Focus();
                        this.Close();
                        break;
                    }
            }
        }

        private void menu2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = drumtuto_main.Properties.Resources.gamestart;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
            btnback.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
            btnwarmup.BackgroundImage = drumtuto_main.Properties.Resources.btnbasic;
            btntutor.BackgroundImage = drumtuto_main.Properties.Resources.btngenre;
            btnmenu.BackgroundImage = drumtuto_main.Properties.Resources.btntutorialmenu;

            mainchoicesscroll(choicecounter);
        }

        private void btnpress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'x')
            {
                choicess.Play();
                if(subchoicecounter1 == 0 && subchoicecounter2 == 0)
                {
                choicecounter += 1;
                if (choicecounter > 3)
                {
                    choicecounter = 1;
                    mainchoicesscroll(choicecounter);
                }
                mainchoicesscroll(choicecounter);
                }
                
                else if(subchoicecounter1 >= 1)
                {
                    choicess.Play();
                    subchoicecounter1+=1;
             
                    if(subchoicecounter1 > 4)
                    {
                        subchoicecounter1 = 1;
                        subchoicesscroll1(subchoicecounter1);
                    }
                    subchoicesscroll1(subchoicecounter1);

                }
                else if (subchoicecounter2 >= 1)
                {
                    choicess.Play();
                    subchoicecounter2 += 1;

                    if (subchoicecounter2 > 4)
                    {
                        subchoicecounter2 = 1;
                        subchoicesscroll2(subchoicecounter2);
                    }
                    subchoicesscroll2(subchoicecounter2);

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
                    entercounter +=1;
                    subchoicesscroll2(subchoicecounter2);
                }

                if (choicecounter == 3 && subchoicecounter1 == 0 && subchoicecounter2 == 0 && entercounter == 0)
                {
                    menu Mainmenu = new menu();
                    this.Close();
                    Mainmenu.Focus();
                    Mainmenu.Show();
                }
                
                
                //first subchoice enter function
                if(subchoicecounter1==1 )
                {
                 entercounter++;
                 if(entercounter > 2)
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
                if(subchoicecounter1 == 4)
                {
              
                    subchoicecounter1 = 0;
                    subchoicecounter2 = 0;    
                    subchoicesscroll1(subchoicecounter1);
                    entercounter=0;
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
               
                if (subchoicecounter2 == 4)
                {

                    subchoicecounter1 = 0;
                    subchoicecounter2 = 0;
                    subchoicesscroll2(subchoicecounter2);
                    entercounter = 0;
                }
  
            }
        }


    }
}

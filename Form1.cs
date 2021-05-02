using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace drumtuto_main
{
    public partial class menu : Form
    {
        public static int choicecounter = 1;
        SoundPlayer choicess;
        SoundPlayer enter;
        
        public menu()
        {
         
            InitializeComponent();
            choicess = new SoundPlayer(drumtuto_main.Properties.Resources.tom);
            enter = new SoundPlayer(drumtuto_main.Properties.Resources.enter);
        }
       
        public void choices(int choicecounter1) 
        {
            switch(choicecounter1)
            {
                case 1:
                    {
                        label1.Text = "This option will lead the user \nto a tutorial menu.";
                        btnstart.Size = new Size(280, 80);
                        btnsettings.Size = new Size(235, 53);
                        btnexit.Size = new Size(235, 53);
                        break;
                    }
                case 2:
                    {
                        label1.Text = "This option will allow the user \nto set or calibrate the tutorial \nto their likings.";
                        btnsettings.Size = new Size(280, 80);
                        btnstart.Size = new Size(235, 53);
                        btnexit.Size = new Size(235, 53);

                        break;
                    }
                case 3:
                    {
                        label1.Text = "To close or exit the application.";
                        btnexit.Size = new Size(280, 80);
                        btnsettings.Size = new Size(235, 53);
                        btnstart.Size = new Size(235, 53);
                        break;
                    }
                default:
                    {
                        choicecounter = 1;
                        choices(choicecounter);
                       break;
                    }
            }

          
            
        }

        public void subchoice(int choicecounter2) 
        {
            switch (choicecounter2) 
            {
                case 1:
                    {

                        this.Hide();
                        menu2 b = new menu2();
                        b.Show();
                        choicecounter = 1;
                   
                        break;
                    }
                case 2: 
                    {

                        this.Hide();
                        Settings b = new Settings();
                        b.Show();
                        choicecounter = 1;
                  
                        break;
                    }
                case 3:
                    {

                        Application.Exit();
                        break;
                    }
            }
        
        }

        private void menu_Load(object sender, EventArgs e)
        {
            main.BackgroundImage = drumtuto_main.Properties.Resources.menuset;
            btnstart.BackgroundImage = drumtuto_main.Properties.Resources.btnstart;
            btnsettings.BackgroundImage = drumtuto_main.Properties.Resources.btnsettings;
            btnexit.BackgroundImage = drumtuto_main.Properties.Resources.btnext;
            pbtitle.Image = drumtuto_main.Properties.Resources.title;
            
            choices(choicecounter);
          
        }

        private void btnch(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'x')
            {
                choicess.Play();
                choicecounter++;
                if (choicecounter > 3)
                {
                    choicecounter = 1;
                }
                choices(choicecounter);
            }

            if (e.KeyChar == 'v')
            {

                enter.Play();
                subchoice(choicecounter);
                
            }
        }
    }
}

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
        public static int ch = 1;
        SoundPlayer choicess;
        SoundPlayer enter;
        
        public menu()
        {
         
            InitializeComponent();
            choicess = new SoundPlayer(drumtuto_main.Properties.Resources.tom);
            enter = new SoundPlayer(drumtuto_main.Properties.Resources.enter);
        }
       
        public void choices() 
        {

            if (ch == 4 || ch < 0 )
            {
                ch = 1;
            }

            if (ch == 1)
            {
                btnstart.Size = new Size(280, 80);
                btnsettings.Size = new Size(235, 53);
                btnexit.Size = new Size(235, 53);

            }
            if (ch == 2)
            {
                btnsettings.Size = new Size(280, 80);
                btnstart.Size = new Size(235, 53);
                btnexit.Size = new Size(235, 53);
         
            }
            if (ch == 3)
            {
                btnexit.Size = new Size(280, 80);
                btnsettings.Size = new Size(235, 53);
                btnstart.Size = new Size(235, 53);
          
            }

            
        }

        private void menu_Load(object sender, EventArgs e)
        {
            main.BackgroundImage = drumtuto_main.Properties.Resources.menuset;
            btnstart.BackgroundImage = drumtuto_main.Properties.Resources.btnstart;
            btnsettings.BackgroundImage = drumtuto_main.Properties.Resources.btnsettings;
            btnexit.BackgroundImage = drumtuto_main.Properties.Resources.btnext;
            pbtitle.Image = drumtuto_main.Properties.Resources.title;
            //p1.Open();
            choices();
          
        }

        private void btnch(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'x')
            {
                choicess.Play();
                ch++;
                choices();
            }

            if (e.KeyChar == ',')
            {
                choicess.Play();
                ch--;
                choices();
            }

            if (e.KeyChar == 'v')
            {

                enter.Play();
                if(ch == 1)
                {
                    this.Hide();
                    menu2 b = new menu2();
                    b.Show();
                }
                if (ch == 3)
                {
                    Application.Exit();
                }
            }
        }

        private void p1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string p1s = p1.ReadExisting().ToString();
            
            if (p1s.StartsWith("X"))
            {
                Button.CheckForIllegalCrossThreadCalls = false;
                choicess.Play();
                ch++;
                choices();
            }

            if (p1s.StartsWith(","))
            {
                Button.CheckForIllegalCrossThreadCalls = false;
                choicess.Play();
                ch--;
                choices();
            }

            if (p1s.StartsWith("V"))
            {
                Button.CheckForIllegalCrossThreadCalls = false;
                enter.Play(); 
                p1.Close();
                if (ch == 1)
                {      
                   
                    this.Hide();
                    menu2 b = new menu2();
                    b.Show();
             
                 
                }
                if (ch == 3)
                {
                    p1.Close();
                    Application.Exit();
                }
            }
        }
    }
}

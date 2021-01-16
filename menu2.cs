using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
// objectives
// rock to be added in tutorial
namespace drumtuto_main
{
    public partial class menu2 : Form
    {
        public static int ch = 1;
        public static int subch = 0;

        public menu2()
        {
            InitializeComponent();
  
        }
        
        public void choices()
        {
           
        if(subch==0)
        {
            opt1.Visible = false;
            opt2.Visible = false;
            opt3.Visible = false;
            btnback2.Visible = false;
        }
        if (ch == 5)
        {
                ch = 1;
        }
        if(ch == 1)
        {
            btnwarmup.Size = new Size(280, 80);
            btntutor.Size = new Size(235, 53);
            btnmusic.Size = new Size(235, 53);
            btnback.Size = new Size(235, 53);
        }
        if (ch == 2)
        { 
            btntutor.Size = new Size(280, 80);
            btnwarmup.Size = new Size(235, 53);
            btnmusic.Size = new Size(235, 53);
            btnback.Size = new Size(235, 53);
        }
        if (ch == 3)
        { 
            
            btnmusic.Size = new Size(280, 80);
            btnwarmup.Size = new Size(235, 53);
            btntutor.Size = new Size(235, 53);
            btnback.Size = new Size(235, 53);
        }
        if (ch == 4)
        {   
            btnback.Size = new Size(280, 80);
            btnwarmup.Size = new Size(235, 53);
            btntutor.Size = new Size(235, 53);
            btnmusic.Size = new Size(235, 53);
         
        }
        }

        public void subchoices() 
        {
            
        if(subch == 5 )
        {
                subch = 1;
        }
        if(subch == 1)
        {
            opt1.Size = new Size(280, 80);
            opt2.Size = new Size(235, 53);
            opt3.Size = new Size(235, 53);
            btnback2.Size = new Size(235, 53);
        }
        if (subch == 2)
        {
            opt2.Size = new Size(280, 80);
            opt1.Size = new Size(235, 53);
            opt3.Size = new Size(235, 53);
            btnback2.Size = new Size(235, 53);
        }
        if (subch == 3)
        { 
            opt3.Size = new Size(280, 80);
            opt1.Size = new Size(235, 53);
            opt2.Size = new Size(235, 53);
            btnback2.Size = new Size(235, 53);
        }
        if (subch == 4)
        { 
            btnback2.Size = new Size(280, 80);
            opt1.Size = new Size(235, 53);
            opt2.Size = new Size(235, 53);
            opt3.Size = new Size(235, 53);
           
        }
        }

        private void menu2_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = drumtuto_main.Properties.Resources.gamestart;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            btnback2.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
            btnback.BackgroundImage = drumtuto_main.Properties.Resources.btnback;
            btnwarmup.BackgroundImage = drumtuto_main.Properties.Resources.btnwarmup;
            btntutor.BackgroundImage = drumtuto_main.Properties.Resources.btntutorials;
            btnmusic.BackgroundImage = drumtuto_main.Properties.Resources.btnmusic;
            opt1.BackgroundImage = drumtuto_main.Properties.Resources.btnopt1;
            opt2.BackgroundImage = drumtuto_main.Properties.Resources.btnopt2;
            opt3.BackgroundImage = drumtuto_main.Properties.Resources.btnopt3;


            choices();
            //p1.Open();

        
        }

        private void btnpress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'x' && subch == 0)
            {
                ch += 1;
                choices();
            }
            if (e.KeyChar == 'x' && subch >= 1)
            {
                subch += 1;
                subchoices();
            }

            if (e.KeyChar == 'v' && ch==1)
            {
            this.Close();
            drumstutos b = new drumstutos();
            b.Show();
            }
            if (e.KeyChar == 'v' && subch == 1)
            {
                this.Close();
                drumstutos b = new drumstutos();
                b.Show();
            }
            if (e.KeyChar == 'v' && subch == 2)
            {
                this.Close();
                drumstutos b = new drumstutos();
                b.Show();
            }
            if (e.KeyChar == 'v' && subch == 3)
            {
                this.Close();
                drumstutos b = new drumstutos();
                b.Show();
            }
            if(e.KeyChar == 'v' && subch == 0 && ch == 2)
            {
                opt1.Visible = true;
                opt2.Visible = true;
                opt3.Visible = true;
                btnback2.Visible = true;
                subch = 1;
                subchoices();
            }
            if(e.KeyChar == 'v' && subch == 4)
            {  
                subch = 0;
                ch = 2;
                choices();
                
            }
            if(e.KeyChar == 'v' && ch == 4)
            {
                this.Close();
                menu b = new menu();
                b.Show();
            }
        }

        private void p1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           string p1s = p1.ReadExisting().ToString();
            if (p1s.StartsWith("X") && subch == 0)
            {

                ch += 1;
                choices();
            }
            if (p1s.StartsWith("X") && subch >= 1)
            {

                subch += 1;
                subchoices();
            }

            if (p1s.StartsWith("V") && ch == 1)
            {
                p1.Close();
                this.Close();
               
                drumstutos b = new drumstutos();
                b.Show();
            }
            if (p1s.StartsWith("V") && subch == 1)
            {
                 p1.Close();
                this.Close();
              
                drumstutos b = new drumstutos();
                b.Show();
            }
            if (p1s.StartsWith("V") && subch == 2)
            {
                p1.Close();
                this.Close();
               
                drumstutos b = new drumstutos();
                b.Show();
            }
            if (p1s.StartsWith("V") && subch == 3)
            {
                p1.Close();
                this.Close();
              
                drumstutos b = new drumstutos();
                b.Show();
            }
            if (p1s.StartsWith("V") && subch == 0 && ch == 2)
            {

                opt1.Visible = true;
                opt2.Visible = true;
                opt3.Visible = true;
                btnback2.Visible = true;
                subch = 1;
                subchoices();
            }
            if (p1s.StartsWith("V") && subch == 4)
            {

                subch = 0;
                ch = 2;
                choices();

            }
            if (p1s.StartsWith("V") && ch == 4)
            {

                this.Close();
                menu b = new menu();
                b.Show();
            }
        }
    }
}

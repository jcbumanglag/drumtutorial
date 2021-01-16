using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using System.Media;
using System.Threading;

//objetives
// edit remaining notes
// add rock genre with no pause
// combine menu
// add indication (arduino)
// add arduino controller
// add 5 miss game over
namespace drumtuto_main
{
    public partial class drumstutos : Form
    {
        #region variables
        SoundPlayer sticks;
        SoundPlayer snare;
        int x1_1 = 0;
        int x1_2 = -100;
        int x1_3 = -200;
        int x1_4 = -300;
        int x1_5 = -400;


        //initial position of each notes(snare)
        int x2_1 = 0;
        int x2_2 = -100;
        int x2_3 = -200;
        int x2_4 = -300;
        int x2_5 = -400;


        //initial position of each notes(bass)
        int x3_1 = 0;
        int x3_2 = -100;
        int x3_3 = -200;
        int x3_4 = -300;
        int x3_5 = -400;

        int x4_1 = 0;
        int x4_2 = -100;
        int x4_3 = -200;
        int x4_4 = -300;
        int x4_5 = -400;

        int x8_1 = 0;
        int x8_2 = -100;
        int x8_3 = -200;
        int x8_4 = -300;
        int x8_5 = -400;

        int x5 =  -5;

        int x6 =  -5;

        int x7 =  -5;

        int quick1;
        int duration1 = 0;
        int score = 0;
        int ones = 4;
        int perfect = 0;
        int miss = 0;
        int good = 0;

        //int goodcom = 0;
        //int perfcom = 0; 
        // for database
       
        int gscore = 0;
        int beat1 = 0;
        int beat2 = 0;
        int beat3 = 0;
        int beat4 = 0;
        int beat5 = 0;
        int beat6 = 0;
        int beat7 = 0;
        int beat8 = 0;

        int hit1 = 0;
        int hit2 = 0;
        int hit3 = 0;
        int hit4 = 0;
        int hit5 = 0;
        int hit6 = 0;
        int hit7 = 0;
        int hit8 = 0;

        //used for tutorial(used for menu)
        int tutor1 = 0;
       
        //used for warmup and music tutorial(used for menu)
        int pattern = 0;
        int musictuto1 = 0;
        
        //used for warmup (used for menu)
        int warmup = 1;
        int set = 1;
        
        #endregion

        #region stopwatches
        //for each beats
      
        public Stopwatch watch { get; set;}


        //beats for hi-hat
        public Stopwatch watch1_1 { get; set; }
        public Stopwatch watch1_2 { get; set; }
        public Stopwatch watch1_3 { get; set; }
        public Stopwatch watch1_4 { get; set; }
        public Stopwatch watch1_5 { get; set; }
        public Stopwatch watch1_6 { get; set; }
        public Stopwatch watch1_7 { get; set; }
        public Stopwatch watch1_8 { get; set; }

        public Stopwatch watch2_1 { get; set; }
        public Stopwatch watch2_2 { get; set; }
        public Stopwatch watch2_3 { get; set; }
        public Stopwatch watch2_4 { get; set; }
        public Stopwatch watch2_5 { get; set; }
        public Stopwatch watch2_6 { get; set; }
        public Stopwatch watch2_7 { get; set; }
        public Stopwatch watch2_8 { get; set; }

        //beats for snare
        public Stopwatch watch3_1 { get; set; }
        public Stopwatch watch3_2 { get; set; }
        public Stopwatch watch3_3 { get; set; }
        public Stopwatch watch3_4 { get; set; }
        public Stopwatch watch3_5 { get; set; }
        public Stopwatch watch3_6 { get; set; }
        public Stopwatch watch3_7 { get; set; }
        public Stopwatch watch3_8 { get; set; }

        //beats base
        public Stopwatch watch4_1 { get; set; }
        public Stopwatch watch4_2 { get; set; }
        public Stopwatch watch4_3 { get; set; }
        public Stopwatch watch4_4 { get; set; }
        public Stopwatch watch4_5 { get; set; }
        public Stopwatch watch4_6 { get; set; }
        public Stopwatch watch4_7 { get; set; }
        public Stopwatch watch4_8 { get; set; }

        public Stopwatch watch8_1 { get; set; }
        public Stopwatch watch8_2 { get; set; }
        public Stopwatch watch8_3 { get; set; }
        public Stopwatch watch8_4 { get; set; }
        public Stopwatch watch8_5 { get; set; }
        public Stopwatch watch8_6 { get; set; }
        public Stopwatch watch8_7 { get; set; }
        public Stopwatch watch8_8 { get; set; }
        #endregion

        #region tutorials

        public void tuto1()
        {
            #region Tuto1
            ///hi hat tutorial
            if(tutor1 == 1)
            {
               
                curr1.Text = score.ToString();
                if(hit1 < 5)
                {
                    n1.Start();
                }

                if(hit1 == 5)
                {
                    hit1 = 0;

                    score += 5;
                    curr1.Text = score.ToString();

                    a1_1.Visible = true;
                    a1_2.Visible = true;
                    a1_3.Visible = true;
                    a1_4.Visible = true;
                    a1_5.Visible = true;

                    n1.Start();
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);


                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);


                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);

                    x1_4 = -300;
                    a1_4.Location = new Point(12, x1_4);

                    x1_5 = -400;
                    a1_5.Location = new Point(12, x1_5);

                    if(score == 60)
                    {
                        hit1 = 0;
                        score = 0;
                        indi2.Visible = false;
                        indi4.Visible = false;
                        curr1.Visible = false;
                        goal1.Visible = false;

                        n1.Stop();
                        tutor1 = 2;
                        textstuto();
                    }
                }
            
            }
            if (tutor1 == 2)
            {
              
                curr1.Text = score.ToString();
                if (hit1 < 5)
                {
                    n1.Start();
                }

                if (hit1 == 5)
                {
                    hit1 = 0;

                    score += 5;
                    curr1.Text = score.ToString();

                    a1_1.Visible = true;
                    a1_2.Visible = true;
                    a1_3.Visible = true;
                    a1_4.Visible = true;
                    a1_5.Visible = true;

                    n1.Start();
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);


                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);


                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);

                    x1_4 = -300;
                    a1_4.Location = new Point(12, x1_4);

                    x1_5 = -400;
                    a1_5.Location = new Point(12, x1_5);

                    if (score == 90)
                    {
                        hit1 = 0;
                        score = 0;

                        indi2.Visible = false;
                        indi4.Visible = false;
                        curr1.Visible = false;
                        goal1.Visible = false;
                        n1.Stop();
                        tutor1 = 3;
                        textstuto();
                    }
                }

            }

            if (tutor1 == 3)
            {
                
                curr1.Text = score.ToString();
                if (hit1 < 5)
                {
                    n1.Start();
                }

                if (hit1 == 5)
                {
                    hit1 = 0;

                    score += 5;
                    curr1.Text = score.ToString();

                    a1_1.Visible = true;
                    a1_2.Visible = true;
                    a1_3.Visible = true;
                    a1_4.Visible = true;
                    a1_5.Visible = true;

                    n1.Start();
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);


                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);


                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);

                    x1_4 = -300;
                    a1_4.Location = new Point(12, x1_4);

                    x1_5 = -400;
                    a1_5.Location = new Point(12, x1_5);

                    if (score == 120)
                    {

                        hit1 = 0;
                        score = 0;
                        indi2.Visible = false;
                        indi4.Visible = false;
                        curr1.Visible = false;
                        goal1.Visible = false;
                        stats1.Visible = true;
                        indi1.Visible = false;
                        currperf.Text = perfect.ToString();
                        currgood.Text = good.ToString();
                        currmiss.Text = miss.ToString();
                        n1.Stop();
                        durations.Stop();

                    }
                }

            }
            #endregion

            #region Tuto2
            //snare & bass

            if (tutor1 == 4) 
            {
                curr1.Text = score.ToString();
                if (hit2 < 5 && hit4 < 5)
                {
                    n4.Start();

                    if (watch.ElapsedMilliseconds > 35)
                    {
                        n2.Start();
                    }
                    watch = Stopwatch.StartNew();

                }

                if (hit2 == 5 && hit4 == 5)
                {
                    Thread.Sleep(100);

                    hit2 = 0;
                    hit4 = 0;
                 

               
                    watch = Stopwatch.StartNew();

                    x4_1 = -55;
                    a4_1.Location = new Point(239, x4_1);


                    x4_2 = -190;
                    a4_2.Location = new Point(239, x4_2);


                    x4_3 = -300;
                    a4_3.Location = new Point(239, x4_3);

                    x4_4 = -405;
                    a4_4.Location = new Point(239, x4_4);

                    x4_5 = -505;
                    a4_5.Location = new Point(239, x4_5);

                    n4.Start();
                    a4_1.Visible = true;
                    a4_2.Visible = true;
                    a4_3.Visible = true;
                    a4_4.Visible = true;
                    a4_5.Visible = true;
            
            
                    if (watch.ElapsedMilliseconds > 35)
                    {

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        x2_5 = -440;
                        a2_5.Location = new Point(89, x2_5);

                        n2.Start();
                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        a2_5.Visible = true;
                    }

                    watch = Stopwatch.StartNew();

                    score += 5;
                    curr1.Text = score.ToString();

                    if(score == 60)
                    {
                       
                        hit2 = 0;
                        hit4 = 0;
                        score = 0;


                        indi2.Visible = false;
                        indi4.Visible = false;
                        curr1.Visible = false;
                        goal1.Visible = false;

                        
                        n2.Stop();
                        n4.Stop();

                        tutor1 = 5;
                        textstuto();
                    }

                }
            }

            if (tutor1 == 5) //should be right snare & bass
            {
                curr1.Text = score.ToString();
                if (hit2 < 5 && hit4 < 5)
                {
                    n2.Start();

                    if (watch.ElapsedMilliseconds > 35)
                    {
                        n2.Start();
                    }
                    watch = Stopwatch.StartNew();

                }

                if (hit2 == 5 && hit4 == 5)
                {

                    hit2 = 0;
                    hit4 = 0;



                    watch = Stopwatch.StartNew();

                    x4_1 = -55;
                    a4_1.Location = new Point(239, x4_1);


                    x4_2 = -190;
                    a4_2.Location = new Point(239, x4_2);


                    x4_3 = -300;
                    a4_3.Location = new Point(239, x4_3);

                    x4_4 = -405;
                    a4_4.Location = new Point(239, x4_4);

                    x4_5 = -505;
                    a4_5.Location = new Point(239, x4_5);

                    n4.Start();
                    a4_1.Visible = true;
                    a4_2.Visible = true;
                    a4_3.Visible = true;
                    a4_4.Visible = true;

                    if (watch.ElapsedMilliseconds > 35)
                    {

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        x2_5 = -440;
                        a2_5.Location = new Point(89, x2_5);

                        n2.Start();
                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        a2_5.Visible = true;
                    }

                    watch = Stopwatch.StartNew();

                    score += 5;
                    curr1.Text = score.ToString();

                    if (score == 90)
                    {

                        hit2 = 0;
                        hit4 = 0;
                        score = 0;


                        indi2.Visible = false;
                        indi4.Visible = false;
                        curr1.Visible = false;
                        goal1.Visible = false;


                        n2.Stop();
                        n4.Stop();

                        tutor1 = 6;
                        textstuto();
                    }

                }
            }

            if (tutor1 == 6) //should be right snare & bass
            {
                curr1.Text = score.ToString();
                if (hit2 < 5 && hit4 < 5)
                {
                    n4.Start();

                    if (watch.ElapsedMilliseconds > 35)
                    {
                        n2.Start();
                    }
                    watch = Stopwatch.StartNew();

                }

                if (hit2 == 5 && hit4 == 5)
                {

                    hit2 = 0;
                    hit4 = 0;



                    watch = Stopwatch.StartNew();

                    x4_1 = -55;
                    a4_1.Location = new Point(239, x4_1);


                    x4_2 = -190;
                    a4_2.Location = new Point(239, x4_2);


                    x4_3 = -300;
                    a4_3.Location = new Point(239, x4_3);

                    x4_4 = -405;
                    a4_4.Location = new Point(239, x4_4);

                    x4_5 = -505;
                    a4_5.Location = new Point(239, x4_5);

                    n4.Start();
                    a4_1.Visible = true;
                    a4_2.Visible = true;
                    a4_3.Visible = true;
                    a4_4.Visible = true;

                    if (watch.ElapsedMilliseconds > 15)
                    {

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        x2_5 = -440;
                        a2_5.Location = new Point(89, x2_5);

                        n2.Start();
                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        a2_5.Visible = true;
                    }

                    watch = Stopwatch.StartNew();

                    score += 5;
                    curr1.Text = score.ToString();

                    if (score == 120)
                    {
                        tutor1 = 0;
                        hit2 = 0;
                        hit4 = 0;
                        score = 0;


                        //indi3.Text = "Bass and Snare Tutorial Done!";
                        indi2.Visible = false;
                        indi4.Visible = false;
                        curr1.Visible = false;
                        goal1.Visible = false;


                        n2.Stop();
                        n4.Stop();
                        textstuto();
                        stats1.Visible = true;
                        indi1.Visible = false;
                        currperf.Text = perfect.ToString();
                        currgood.Text = good.ToString();
                        currmiss.Text = miss.ToString();
                        n2.Stop();
                        n4.Stop();
                        durations.Stop();
                    }

                }
            }
            #endregion

            #region Tuto3
            //Hi-hat & Bass

            if (tutor1 == 7)
            {
                curr1.Text = score.ToString();
                if (hit1 < 5 && hit4 < 5)
                {
                    n4.Start();

                    if (watch.ElapsedMilliseconds > 35)
                    {
                        n1.Start();
                    }
                    watch = Stopwatch.StartNew();

                }

                if (hit1 == 5 && hit4 == 5)
                {

                    hit1 = 0;
                    hit4 = 0;



                    watch = Stopwatch.StartNew();

                    x4_1 = -55;
                    a4_1.Location = new Point(239, x4_1);


                    x4_2 = -190;
                    a4_2.Location = new Point(239, x4_2);


                    x4_3 = -300;
                    a4_3.Location = new Point(239, x4_3);

                    x4_4 = -405;
                    a4_4.Location = new Point(239, x4_4);

                    x4_5 = -505;
                    a4_5.Location = new Point(239, x4_5);

                    n4.Start();
                    a4_1.Visible = true;
                    a4_2.Visible = true;
                    a4_3.Visible = true;
                    a4_4.Visible = true;
                    a4_5.Visible = true;


                    if (watch.ElapsedMilliseconds > 35)
                    {

                        x1_1 = 0;
                        a1_1.Location = new Point(12, x1_1);


                        x1_2 = -120;
                        a1_2.Location = new Point(12, x1_2);


                        x1_3 = -240;
                        a1_3.Location = new Point(12, x1_3);


                        x1_4 = -340;
                        a1_4.Location = new Point(12, x1_4);

                        x1_5 = -440;
                        a1_5.Location = new Point(12, x1_5);

                        n1.Start();
                        a1_1.Visible = true;
                        a1_2.Visible = true;
                        a1_3.Visible = true;
                        a1_4.Visible = true;
                        a1_5.Visible = true;
                    }

                    watch = Stopwatch.StartNew();

                    score += 5;
                    curr1.Text = score.ToString();

                    if (score == 60)
                    {

                        hit1 = 0;
                        hit4 = 0;
                        score = 0;


                        indi2.Visible = false;
                        indi4.Visible = false;
                        curr1.Visible = false;
                        goal1.Visible = false;


                        n1.Stop();
                        n4.Stop();
                        tutor1 = 8;
                        textstuto();
                     
                    }

                }
            }

            if (tutor1 == 8) //should be right snare & bass
            {
                curr1.Text = score.ToString();
                if (hit1 < 5 && hit4 < 5)
                {
                    n4.Start();

                    if (watch.ElapsedMilliseconds > 35)
                    {
                        n1.Start();
                    }
                    watch = Stopwatch.StartNew();

                }

                if (hit2 == 5 && hit4 == 5)
                {

                    hit2 = 0;
                    hit4 = 0;


                    watch = Stopwatch.StartNew();

                    x4_1 = -55;
                    a4_1.Location = new Point(239, x4_1);


                    x4_2 = -190;
                    a4_2.Location = new Point(239, x4_2);


                    x4_3 = -300;
                    a4_3.Location = new Point(239, x4_3);

                    x4_4 = -405;
                    a4_4.Location = new Point(239, x4_4);

                    x4_5 = -505;
                    a4_5.Location = new Point(239, x4_5);
                    n4.Start();
                    a4_1.Visible = true;
                    a4_2.Visible = true;
                    a4_3.Visible = true;
                    a4_4.Visible = true;

                    if (watch.ElapsedMilliseconds > 35)
                    {

                        x1_1 = 0;
                        a1_1.Location = new Point(12, x1_1);


                        x1_2 = -120;
                        a1_2.Location = new Point(12, x1_2);


                        x1_3 = -240;
                        a1_3.Location = new Point(12, x1_3);


                        x1_4 = -340;
                        a1_4.Location = new Point(12, x1_4);

                        x1_5 = -440;
                        a1_5.Location = new Point(12, x1_5);

                        n1.Start();
                        a1_1.Visible = true;
                        a1_2.Visible = true;
                        a1_3.Visible = true;
                        a1_4.Visible = true;
                        a1_5.Visible = true;
                    }

                    watch = Stopwatch.StartNew();

                    score += 5;
                    curr1.Text = score.ToString();

                    if (score == 90)
                    {

                        hit1 = 0;
                        hit4 = 0;
                        score = 0;


                        indi2.Visible = false;
                        indi4.Visible = false;
                        curr1.Visible = false;
                        goal1.Visible = false;


                        n1.Stop();
                        n4.Stop();
                        tutor1 = 9;
                        textstuto();
           
                    }

                }
            }

            if (tutor1 == 9) //should be right snare & bass
            {
                curr1.Text = score.ToString();
                if (hit1 < 5 && hit4 < 5)
                {
                    n4.Start();

                    if (watch.ElapsedMilliseconds > 35)
                    {
                        n1.Start();
                    }
                    watch = Stopwatch.StartNew();

                }

                if (hit1 == 5 && hit4 == 5)
                {

                    hit1 = 0;
                    hit4 = 0;



                    watch = Stopwatch.StartNew();

                    x4_1 = -55;
                    a4_1.Location = new Point(239, x4_1);


                    x4_2 = -190;
                    a4_2.Location = new Point(239, x4_2);


                    x4_3 = -300;
                    a4_3.Location = new Point(239, x4_3);

                    x4_4 = -405;
                    a4_4.Location = new Point(239, x4_4);

                    x4_5 = -505;
                    a4_5.Location = new Point(239, x4_5);

                    n4.Start();
                    a4_1.Visible = true;
                    a4_2.Visible = true;
                    a4_3.Visible = true;
                    a4_4.Visible = true;

                    if (watch.ElapsedMilliseconds > 35)
                    {

                        x1_1 = 0;
                        a1_1.Location = new Point(12, x1_1);


                        x1_2 = -120;
                        a1_2.Location = new Point(12, x1_2);


                        x1_3 = -240;
                        a1_3.Location = new Point(12, x1_3);


                        x1_4 = -340;
                        a1_4.Location = new Point(12, x1_4);

                        x1_5 = -440;
                        a1_5.Location = new Point(12, x1_5);

                        n1.Start();
                        a1_1.Visible = true;
                        a1_2.Visible = true;
                        a1_3.Visible = true;
                        a1_4.Visible = true;
                        a1_5.Visible = true;
                    }

                    watch = Stopwatch.StartNew();

                    score += 5;
                    curr1.Text = score.ToString();

                    if (score == 120)
                    {
                        tutor1 = 0;
                        hit1 = 0;
                        hit4 = 0;
                        score = 0;


                        //indi3.Text = "Bass and Snare Tutorial Done!";
                        indi2.Visible = false;
                        indi4.Visible = false;
                        curr1.Visible = false;
                        goal1.Visible = false;


                        stats1.Visible = true;
                        indi1.Visible = false;
                        currperf.Text = perfect.ToString();
                        currgood.Text = good.ToString();
                        currmiss.Text = miss.ToString();
                        n1.Stop();
                        n4.Stop();
                        durations.Stop();
                    }

                }
            }
            #endregion
        }
        
        public void warmups()
        {
            #region Warmup1
            if (warmup == 1)
            {
            if(hit2 < 5)
            {
                n2.Start();
            }
            if(hit2 == 5)
            {
                hit2 = 0;

                score += 5;
                curr1.Text = score.ToString();

                x2_1 = 0;
                a2_1.Location = new Point(89, x2_1);


                x2_2 = -120;
                a2_2.Location = new Point(89, x2_2);


                x2_3 = -240;
                a2_3.Location = new Point(89, x2_3);


                x2_4 = -340;
                a2_4.Location = new Point(89, x2_4);
                
                n2.Start();

                a2_1.Visible = true;
                a2_2.Visible = true;
                a2_3.Visible = true;
                a2_4.Visible = true;

                
            }
            if(score == 60)
            {
                hit2 = 0;
                score = 0;

                x2_1 = 0;
                x2_2 = -120;
                x2_3 = -240;
                x2_4 = -340;

                a2_1.Visible = false;
                a2_2.Visible = false;
                a2_3.Visible = false;
                a2_4.Visible = false;

                n2.Stop();

                set++;
                textstuto();
            }
            if(set == 1)
            {
                if (hit2 < 5)
                {
                    n2.Start();
                }
                if (hit2 == 5)
                {
                    hit2 = 0;

                    score += 5;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;


                }
                if (score == 90)
                {
                    hit2 = 0;
                    score = 0;

                    x2_1 = 0;
                    x2_2 = -120;
                    x2_3 = -240;
                    x2_4 = -340;

                    a2_1.Visible = false;
                    a2_2.Visible = false;
                    a2_3.Visible = false;
                    a2_4.Visible = false;

                    n2.Stop();

                    set++;
                    textstuto();
                }
            }
            if (set == 2)
            {
                if (hit2 < 5)
                {
                    n2.Start();
                }
                if (hit2 == 5)
                {
                    hit2 = 0;

                    score += 5;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;


                }
                if (score == 90)
                {
                    hit2 = 0;
                    score = 0;

                    x2_1 = 0;
                    x2_2 = -120;
                    x2_3 = -240;
                    x2_4 = -340;

                    a2_1.Visible = false;
                    a2_2.Visible = false;
                    a2_3.Visible = false;
                    a2_4.Visible = false;

                    n2.Stop();

                    set++;
                    textstuto();
                }

                if (set == 3)
                {
                    if (hit2 < 5)
                    {
                        n2.Start();
                    }
                    if (hit2 == 5)
                    {
                        hit2 = 0;

                        score += 5;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;


                    }
                    if (score == 120)
                    {
                        hit2 = 0;
                        score = 0;

                        x2_1 = 0;
                        x2_2 = -120;
                        x2_3 = -240;
                        x2_4 = -340;

                        a2_1.Visible = false;
                        a2_2.Visible = false;
                        a2_3.Visible = false;
                        a2_4.Visible = false;

                        n2.Stop();

                        warmup++;
                        pattern = 0;
                        set = 0;
                        textstuto();

                    }
                }
            }
            }
            #endregion

            #region Warmup2
            ///warmup 2
        if (warmup == 2)
        {
            if (hit2 < 5)
            {
                n2.Start();
            }
            if (hit2 == 5)
            {
                hit2 = 0;

                score += 5;
                curr1.Text = score.ToString();

                x2_1 = 0;
                a2_1.Location = new Point(89, x2_1);


                x2_2 = -120;
                a2_2.Location = new Point(89, x2_2);


                x2_3 = -240;
                a2_3.Location = new Point(89, x2_3);


                x2_4 = -340;
                a2_4.Location = new Point(89, x2_4);

                n2.Start();

                a2_1.Visible = true;
                a2_2.Visible = true;
                a2_3.Visible = true;
                a2_4.Visible = true;


            }
            if (score == 60)
            {
                hit2 = 0;
                score = 0;

                x2_1 = 0;
                x2_2 = -120;
                x2_3 = -240;
                x2_4 = -340;

                a2_1.Visible = false;
                a2_2.Visible = false;
                a2_3.Visible = false;
                a2_4.Visible = false;

                n2.Stop();

                set++;
                textstuto();
            }
            if (set == 1)
            {
                if (hit2 < 5)
                {
                    n2.Start();
                }
                if (hit2 == 5)
                {
                    hit2 = 0;

                    score += 5;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;


                }
                if (score == 90)
                {
                    hit2 = 0;
                    score = 0;

                    x2_1 = 0;
                    x2_2 = -120;
                    x2_3 = -240;
                    x2_4 = -340;

                    a2_1.Visible = false;
                    a2_2.Visible = false;
                    a2_3.Visible = false;
                    a2_4.Visible = false;

                    n2.Stop();

                    set++;
                    textstuto();
                }
            }
            if (set == 2)
            {
                if (hit2 < 5)
                {
                    n2.Start();
                }
                if (hit2 == 5)
                {
                    hit2 = 0;

                    score += 5;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;


                }
                if (score == 90)
                {
                    hit2 = 0;
                    score = 0;

                    x2_1 = 0;
                    x2_2 = -120;
                    x2_3 = -240;
                    x2_4 = -340;

                    a2_1.Visible = false;
                    a2_2.Visible = false;
                    a2_3.Visible = false;
                    a2_4.Visible = false;

                    n2.Stop();

                    set++;
                    textstuto();
                }

                if (set == 3)
                {
                    if (hit2 < 5)
                    {
                        n2.Start();
                    }
                    if (hit2 == 5)
                    {
                        hit2 = 0;

                        score += 5;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;


                    }
                    if (score == 120)
                    {
                        hit2 = 0;
                        score = 0;

                        x2_1 = 0;
                        x2_2 = -120;
                        x2_3 = -240;
                        x2_4 = -340;

                        a2_1.Visible = false;
                        a2_2.Visible = false;
                        a2_3.Visible = false;
                        a2_4.Visible = false;

                        n2.Stop();

                        textstuto();
                        
                        pattern = 0;
                        set = 0;
                        
                        warmup++;
                    
                    }
                }
            }
        }
            #endregion

            #region Warump3
        /////////// warump 3
            if(warmup == 3)
            {
                if(hit2<5)
                {
                    n2.Start();
                }

                if (hit2 == 5 && pattern == 0)
                {
                    hit2 = 0;

                    score += 3;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;
                    pattern++;
                    textstuto();
                }

                if (hit2 == 5 && pattern == 1)
                {
                    hit2 = 0;

                    score += 2;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;
                    pattern--;
                    textstuto();
                }

                if(score == 60)
                {
                    hit2 = 0;
                    score = 0;

                    x2_1 = 0;
                    x2_2 = -120;
                    x2_3 = -240;
                    x2_4 = -340;

                    a2_1.Visible = false;
                    a2_2.Visible = false;
                    a2_3.Visible = false;
                    a2_4.Visible = false;

                    n2.Stop();
                    set++;
                    pattern = 0;
                    textstuto();
                }

                if(set == 1)
                {
                    if (hit2 < 5)
                    {
                        n2.Start();
                    }

                    if (hit2 == 5 && pattern == 0)
                    {
                        hit2 = 0;

                        score += 3;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern++;
                        textstuto();
                    }

                    if (hit2 == 5 && pattern == 1)
                    {
                        hit2 = 0;

                        score += 2;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern--;
                        textstuto();
                    }
                    if (score == 90)
                    {
                        hit2 = 0;
                        score = 0;

                        x2_1 = 0;
                        x2_2 = -120;
                        x2_3 = -240;
                        x2_4 = -340;

                        a2_1.Visible = false;
                        a2_2.Visible = false;
                        a2_3.Visible = false;
                        a2_4.Visible = false;

                        n2.Stop();
                        set++;
                        pattern = 0;
                        textstuto();
                    }
                }
               
                if(set == 3)
                {
                    if (hit2 < 5)
                    {
                        n2.Start();
                    }

                    if (hit2 == 5 && pattern == 0)
                    {
                        hit2 = 0;

                        score += 3;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern++;
                        textstuto();
                    }

                    if (hit2 == 5 && pattern == 1)
                    {
                        hit2 = 0;

                        score += 2;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern--;
                        textstuto();
                    }

                    if (score == 120)
                    {
                        hit2 = 0;
                        score = 0;

                        x2_1 = 0;
                        x2_2 = -120;
                        x2_3 = -240;
                        x2_4 = -340;

                        a2_1.Visible = false;
                        a2_2.Visible = false;
                        a2_3.Visible = false;
                        a2_4.Visible = false;

                        n2.Stop();
                        
                        warmup++;
                        pattern = 0;
                        set = 0;
                        textstuto();
                        

                    }
                }
            }

#endregion

            #region Warmup4

            ///////warmup 4
            if (warmup == 4)
            {
                if (hit2 < 5)
                {
                    n2.Start();
                }
                if (hit2 == 5 && pattern == 0)
                {
                    hit2 = 0;

                    score += 1;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    x2_5 = -440;
                    a2_5.Location = new Point(89, x2_5);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;
                    a2_5.Visible = true;
                    pattern++;
                    textstuto();
                }

                if (hit2 == 5 && pattern == 1)
                {
                    hit2 = 0;

                    score += 1;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;
                    pattern++;
                    textstuto();
                }
                if (hit2 == 5 && pattern == 2)
                {
                    hit2 = 0;

                    score += 3;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;
                    pattern = 0;
                    textstuto();
                }
              
                if (score == 60)
                {
                    hit2 = 0;
                    score = 0;

                    x2_1 = 0;
                    x2_2 = -120;
                    x2_3 = -240;
                    x2_4 = -340;
                    x2_5 = -440;

                    a2_1.Visible = false;
                    a2_2.Visible = false;
                    a2_3.Visible = false;
                    a2_4.Visible = false;
                    a2_5.Visible = false;
                    n2.Stop();
                    pattern = 0;
                    set++;
                    textstuto();
                }

                if (set == 1)
                {
                    if (hit2 < 5)
                    {
                        n2.Start();
                    }
                    if (hit2 == 5 && pattern == 0)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        x2_5 = -440;
                        a2_5.Location = new Point(89, x2_5);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        a2_5.Visible = true;
                        pattern++;
                        textstuto();
                    }

                    if (hit2 == 5 && pattern == 1)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern++;
                        textstuto();
                    }
                    if (hit2 == 5 && pattern == 2)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern=0;
                        textstuto();
                    }
       

                    if (score == 90)
                    {
                        hit2 = 0;
                        score = 0;

                        x2_1 = 0;
                        x2_2 = -120;
                        x2_3 = -240;
                        x2_4 = -340;
                        x2_5 = -440;

                        a2_1.Visible = false;
                        a2_2.Visible = false;
                        a2_3.Visible = false;
                        a2_4.Visible = false;
                        a2_5.Visible = false;
                        n2.Stop();
                        set++;
                        pattern = 0;
                        textstuto();
                    }
                }
                if (set == 2)
                {
                    if (hit2 < 5)
                    {
                        n2.Start();
                    }
                    if (hit2 == 5 && pattern == 0)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        x2_5 = -440;
                        a2_5.Location = new Point(89, x2_5);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        a2_5.Visible = true;
                        pattern++;
                        textstuto();
                    }

                    if (hit2 == 5 && pattern == 1)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern++;
                        textstuto();
                    }
                    if (hit2 == 5 && pattern == 2)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern=0;
                        textstuto();
                    }
                    
                    if (score == 120)
                    {
                        hit2 = 0;
                        score = 0;

                        x2_1 = 0;
                        x2_2 = -120;
                        x2_3 = -240;
                        x2_4 = -340;
                        x2_5 = -440;

                        a2_1.Visible = false;
                        a2_2.Visible = false;
                        a2_3.Visible = false;
                        a2_4.Visible = false;
                        a2_5.Visible = false;
                        n2.Stop();
                        warmup++;
                        set = 0;
                        pattern = 0;
                        textstuto();
                    }
                }
            }
            #endregion

            #region Warmup5
            ///warmup5
            if (warmup == 5)
            {
                if (hit2 < 5)
                {
                    n2.Start();
                }
                if (hit2 == 5 && pattern == 0)
                {
                    hit2 = 0;

                    score += 1;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    x2_5 = -440;
                    a2_5.Location = new Point(89, x2_5);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;
                    a2_5.Visible = true;
                    pattern++;
                    textstuto();
                }

                if (hit2 == 5 && pattern == 1)
                {
                    hit2 = 0;

                    score += 1;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;
                    pattern++;
                    textstuto();
                }
                if (hit2 == 5 && pattern == 2)
                {
                    hit2 = 0;

                    score += 1;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;
                    pattern++;
                    textstuto();
                }
                if (hit2 == 5 && pattern == 3)
                {
                    hit2 = 0;

                    score += 2;
                    curr1.Text = score.ToString();

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);


                    x2_2 = -120;
                    a2_2.Location = new Point(89, x2_2);


                    x2_3 = -240;
                    a2_3.Location = new Point(89, x2_3);


                    x2_4 = -340;
                    a2_4.Location = new Point(89, x2_4);

                    n2.Start();

                    a2_1.Visible = true;
                    a2_2.Visible = true;
                    a2_3.Visible = true;
                    a2_4.Visible = true;
                    pattern=0;
                    textstuto();
                }

                if (score == 60)
                {
                    hit2 = 0;
                    score = 0;

                    x2_1 = 0;
                    x2_2 = -120;
                    x2_3 = -240;
                    x2_4 = -340;
                    x2_5 = -440;

                    a2_1.Visible = false;
                    a2_2.Visible = false;
                    a2_3.Visible = false;
                    a2_4.Visible = false;
                    a2_5.Visible = false;
                    n2.Stop();
                    pattern = 0;
                    set++;
                    textstuto();
                }

                if (set == 1)
                {
                    if (hit2 < 5)
                    {
                        n2.Start();
                    }
                    if (hit2 == 5 && pattern == 0)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        x2_5 = -440;
                        a2_5.Location = new Point(89, x2_5);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        a2_5.Visible = true;
                        pattern++;
                        textstuto();
                    }

                    if (hit2 == 5 && pattern == 1)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern++;
                        textstuto();
                    }
                    if (hit2 == 5 && pattern == 2)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern++;
                        textstuto();
                    }
                    if (hit2 == 5 && pattern == 3)
                    {
                        hit2 = 0;

                        score += 2;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern = 0;
                        textstuto();
                    }

                    if (score == 90)
                    {
                        hit2 = 0;
                        score = 0;

                        x2_1 = 0;
                        x2_2 = -120;
                        x2_3 = -240;
                        x2_4 = -340;
                        x2_5 = -440;

                        a2_1.Visible = false;
                        a2_2.Visible = false;
                        a2_3.Visible = false;
                        a2_4.Visible = false;
                        a2_5.Visible = false;
                        n2.Stop();
                        set++;
                        pattern = 0;
                        textstuto();
                    }
                }
                if (set == 2)
                {
                    if (hit2 < 5)
                    {
                        n2.Start();
                    }
                    if (hit2 == 5 && pattern == 0)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        x2_5 = -440;
                        a2_5.Location = new Point(89, x2_5);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        a2_5.Visible = true;
                        pattern++;
                        textstuto();
                    }

                    if (hit2 == 5 && pattern == 1)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern++;
                        textstuto();
                    }
                    if (hit2 == 5 && pattern == 2)
                    {
                        hit2 = 0;

                        score += 1;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern++;
                        textstuto();
                    }
                    if (hit2 == 5 && pattern == 3)
                    {
                        hit2 = 0;

                        score += 2;
                        curr1.Text = score.ToString();

                        x2_1 = 0;
                        a2_1.Location = new Point(89, x2_1);


                        x2_2 = -120;
                        a2_2.Location = new Point(89, x2_2);


                        x2_3 = -240;
                        a2_3.Location = new Point(89, x2_3);


                        x2_4 = -340;
                        a2_4.Location = new Point(89, x2_4);

                        n2.Start();

                        a2_1.Visible = true;
                        a2_2.Visible = true;
                        a2_3.Visible = true;
                        a2_4.Visible = true;
                        pattern = 0;
                        textstuto();
                    }

                    if (score == 120)
                    {
                        hit2 = 0;
                        score = 0;

                        x2_1 = 0;
                        x2_2 = -120;
                        x2_3 = -240;
                        x2_4 = -340;
                        x2_5 = -440;

                        a2_1.Visible = false;
                        a2_2.Visible = false;
                        a2_3.Visible = false;
                        a2_4.Visible = false;
                        a2_5.Visible = false;
                        n2.Stop();
                        warmup = 0;
                        currperf.Text = perfect.ToString();
                        currgood.Text = good.ToString();
                        currmiss.Text = miss.ToString();
                        set = 0;
                        pattern = 0;
                        textstuto();
                    }
                }
            }
            #endregion
        }

        public void textstuto()
        {
            #region warumpfull
         
            if (warmup == 1)
            {
               
                gpins1.Visible = true;
                if(set == 1){
                x2_1 = 0;
                x2_2 = -100;
                x2_3 = -200;
                x2_4 = -300;
                x2_5 = -400;

                a2_1.BackColor = Color.Orange;
                a2_2.BackColor = Color.PapayaWhip;
                a2_3.BackColor = Color.Orange;
                a2_4.BackColor = Color.PapayaWhip;

                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Snare Warmup";
                currtempo.Text = "Slow";
                goal1.Text = "60";
                n2.Interval = 50;
                n2.Start();
                }
                if (set == 2)
                {
                    x2_1 = 0;
                    x2_2 = -100;
                    x2_3 = -200;
                    x2_4 = -300;
                    x2_5 = -400;

                    a2_1.BackColor = Color.Orange;
                    a2_2.BackColor = Color.PapayaWhip;
                    a2_3.BackColor = Color.Orange;
                    a2_4.BackColor = Color.PapayaWhip;

                    indi2.Visible = true;
                    indi3.Visible = true;
                    indi4.Visible = true;
                    goal1.Visible = true;
                    curr1.Visible = true;

                    indi3.Text = "Snare Warmup";
                    currtempo.Text = "Normal";
                    goal1.Text = "90";
                    n2.Interval = 35;
                    n2.Start();
                }
                if (set == 3)
                {
                    x2_1 = 0;
                    x2_2 = -100;
                    x2_3 = -200;
                    x2_4 = -300;
                    x2_5 = -400;

                    a2_1.BackColor = Color.Orange;
                    a2_2.BackColor = Color.PapayaWhip;
                    a2_3.BackColor = Color.Orange;
                    a2_4.BackColor = Color.PapayaWhip;

                    indi2.Visible = true;
                    indi3.Visible = true;
                    indi4.Visible = true;
                    goal1.Visible = true;
                    curr1.Visible = true;

                    indi3.Text = "Snare Warmup";
                    currtempo.Text = "Fast";
                    goal1.Text = "120";
                    n2.Interval = 25;
                    n2.Start();
                }
  
              
            }


   
            if (warmup == 2)
            {
                beat2 = 4;
                gpins1.Visible = true;
                
                if (set == 1)
                {
                    x2_1 = 0;
                    x2_2 = -100;
                    x2_3 = -200;
                    x2_4 = -300;
                    x2_5 = -400;

                    a2_1.BackColor = Color.Orange;
                    a2_2.BackColor = Color.Orange;
                    a2_3.BackColor = Color.PapayaWhip;
                    a2_4.BackColor = Color.PapayaWhip;

                    indi2.Visible = true;
                    indi3.Visible = true;
                    indi4.Visible = true;
                    goal1.Visible = true;
                    curr1.Visible = true;

                    indi3.Text = "Snare Warmup";
                    currtempo.Text = "Slow";
                    goal1.Text = "60";
                    n2.Interval = 50;
                    n2.Start();
                }
                if (set == 2)
                {
                    
                    x2_1 = 0;
                    x2_2 = -100;
                    x2_3 = -200;
                    x2_4 = -300;
                    x2_5 = -400;

                    a2_1.BackColor = Color.Orange;
                    a2_2.BackColor = Color.Orange;
                    a2_3.BackColor = Color.PapayaWhip;
                    a2_4.BackColor = Color.PapayaWhip;

                    indi2.Visible = true;
                    indi3.Visible = true;
                    indi4.Visible = true;
                    goal1.Visible = true;
                    curr1.Visible = true;

                    indi3.Text = "Snare Warmup";
                    currtempo.Text = "Normal";
                    goal1.Text = "90";
                    n2.Interval = 35;
                    n2.Start();
                }
                if (set == 3)
                {
                    x2_1 = 0;
                    x2_2 = -100;
                    x2_3 = -200;
                    x2_4 = -300;
                    x2_5 = -400;

                    a2_1.BackColor = Color.Orange;
                    a2_2.BackColor = Color.Orange;
                    a2_3.BackColor = Color.PapayaWhip;
                    a2_4.BackColor = Color.PapayaWhip;

                    indi2.Visible = true;
                    indi3.Visible = true;
                    indi4.Visible = true;
                    goal1.Visible = true;
                    curr1.Visible = true;

                    indi3.Text = "Snare Warmup";
                    currtempo.Text = "Fast";
                    goal1.Text = "120";
                    n2.Interval = 25;
                    n2.Start();
                }

            }


       
            if (warmup == 3)
            {
                beat2 = 4;
                gpins1.Visible = true;
                if (set == 1)
                {
                    if (pattern == 0)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Slow";
                        goal1.Text = "60";
                        n2.Interval = 50;
                        n2.Start();
                    }
                    if (pattern == 1)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Slow";
                        goal1.Text = "60";
                        n2.Interval = 50;
                        n2.Start();
                    }
                }
                if (set == 2)
                {
                    if (pattern == 0)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Normal";
                        goal1.Text = "90";
                        n2.Interval = 35;
                        n2.Start();
                    }
                    if (pattern == 1)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Normal";
                        goal1.Text = "90";
                        n2.Interval = 35;
                        n2.Start();
                    }
                }
                if (set == 3)
                {
                    if (pattern == 0)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Fast";
                        goal1.Text = "120";
                        n2.Interval = 25;
                        n2.Start();
                    }
                    if (pattern == 1)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Fast";
                        goal1.Text = "120";
                        n2.Interval = 25;
                        n2.Start();
                    }
                }
            }
 

        
            if (warmup == 4)
            {
                beat2 = 5;
                gpins1.Visible = true;
                if (set == 1)
                {
                    if (pattern == 0)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Slow";
                        goal1.Text = "60";
                        n2.Interval = 50;
                        n2.Start();
                    }
                    if (pattern == 1)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.PapayaWhip;
                        a2_5.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Slow";
                        goal1.Text = "60";
                        n2.Interval = 50;
                        n2.Start();
                    }
                    if (pattern == 2)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.PapayaWhip;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Slow";
                        goal1.Text = "60";
                        n2.Interval = 50;
                        n2.Start();
                    }
                }
                if (set == 2)
                {
                    if (pattern == 0)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Normal";
                        goal1.Text = "90";
                        n2.Interval = 35;
                        n2.Start();
                    }
                    if (pattern == 1)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.PapayaWhip;
                        a2_5.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Normal";
                        goal1.Text = "90";
                        n2.Interval = 35;
                        n2.Start();
                    }
                    if (pattern == 2)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.PapayaWhip;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Normal";
                        goal1.Text = "90";
                        n2.Interval = 35;
                        n2.Start();
                    }
                }
                if (set == 3)
                {
                    if (pattern == 0)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Fast";
                        goal1.Text = "120";
                        n2.Interval = 25;
                        n2.Start();
                    }
                    if (pattern == 1)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.PapayaWhip;
                        a2_5.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Fast";
                        goal1.Text = "120";
                        n2.Interval = 25;
                        n2.Start();
                    }
                    if (pattern == 2)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.PapayaWhip;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Fast";
                        goal1.Text = "120";
                        n2.Interval = 25;
                        n2.Start();
                    }
                }

            }
 


            ///warmup 5
            if (warmup == 5)
            {
                beat2 = 5;
                gpins1.Visible = true;
                if (set == 1)
                {
                    if (pattern == 0)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Slow";
                        goal1.Text = "60";
                        n2.Interval = 50;
                        n2.Start();
                    }
                    if (pattern == 1)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Slow";
                        goal1.Text = "60";
                        n2.Interval = 50;
                        n2.Start();
                    }
                    if (pattern == 2)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.PapayaWhip;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Slow";
                        goal1.Text = "60";
                        n2.Interval = 50;
                        n2.Start();
                    }
                    if (pattern == 3)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Slow";
                        goal1.Text = "60";
                        n2.Interval = 50;
                        n2.Start();
                    }
                }
                if (set == 2)
                {
                    if (pattern == 0)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Normal";
                        goal1.Text = "90";
                        n2.Interval = 35;
                        n2.Start();
                    }
                    if (pattern == 1)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Normal";
                        goal1.Text = "90";
                        n2.Interval = 35;
                        n2.Start();
                    }
                    if (pattern == 2)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.PapayaWhip;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Normal";
                        goal1.Text = "90";
                        n2.Interval = 35;
                        n2.Start();
                    }
                    if (pattern == 3)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Normal";
                        goal1.Text = "90";
                        n2.Interval = 35;
                        n2.Start();
                    }
                }
                if (set == 3)
                {
                    if (pattern == 0)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.Orange;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Fast";
                        goal1.Text = "120";
                        n2.Interval = 25;
                        n2.Start();
                    }
                    if (pattern == 1)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.Orange;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.PapayaWhip;

                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Fast";
                        goal1.Text = "120";
                        n2.Interval = 25;
                        n2.Start();
                    }
                    if (pattern == 2)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.PapayaWhip;
                        a2_3.BackColor = Color.Orange;
                        a2_4.BackColor = Color.PapayaWhip;
                        a2_5.BackColor = Color.Orange;


                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Fast";
                        goal1.Text = "120";
                        n2.Interval = 25;
                        n2.Start();
                    }
                    if (pattern == 3)
                    {
                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;

                        a2_1.BackColor = Color.PapayaWhip;
                        a2_2.BackColor = Color.Orange;
                        a2_3.BackColor = Color.PapayaWhip;
                        a2_4.BackColor = Color.Orange;
                        a2_5.BackColor = Color.Orange;


                        indi2.Visible = true;
                        indi3.Visible = true;
                        indi4.Visible = true;
                        goal1.Visible = true;
                        curr1.Visible = true;

                        indi3.Text = "Snare Warmup";
                        currtempo.Text = "Fast";
                        goal1.Text = "120";
                        n2.Interval = 25;
                        n2.Start();
                    }
                }

            }
            
            #endregion

            #region Tutor1
            if (tutor1 == 1)
            {
                beat1 = 5;
                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Hi-hat Tutorial";
                goal1.Text = "60";
                currtempo.Text = "Slow";
                n1.Interval = 50;
                n1.Start();
            }
            if (tutor1 == 2)
            {
                beat1 = 5;
                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Hi-hat Tutorial";
                goal1.Text = "90";
                currtempo.Text = "Normal";
                n1.Interval = 35;
                n1.Start();
            }
            if (tutor1 == 3)
            {
                beat1 = 5;
                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Hi-hat Tutorial";
                goal1.Text = "120";
                currtempo.Text = "Fast";
                n1.Interval = 25;
                n1.Start();
            }
            #endregion

            #region Tutor2
            if (tutor1 == 4)
            {
                beat4 = 5;
                beat2 = 5;
                n4.Interval = 50;
                n2.Interval = 50;
                x2_1 = 0;
                x2_2 = -100;
                x2_3 = -200;
                x2_4 = -300;
                x2_5 = -400;



                x4_1 = -55;
                x4_2 = -190;
                x4_3 = -300;
                x4_4 = -405;
                x4_5 = -505;

                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Bass and Snare Tutorial";
                currtempo.Text = "Slow";
                goal1.Text = "60";
                n4.Interval = 50;
                n2.Interval = 50;
                n4.Start();
            }

            if (tutor1 == 5)
            {
                beat4 = 5;
                beat2 = 5;
                x2_1 = 0;
                x2_2 = -120;
                x2_3 = -240;
                x2_4 = -340;
                x2_5 = -440;



                x4_1 = -55;
                x4_2 = -190;
                x4_3 = -300;
                x4_4 = -405;
                x4_5 = -505;

                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Bass and Snare Tutorial";
                currtempo.Text = "Normal";
                goal1.Text = "90";
                n4.Interval = 35;
                n2.Interval = 35;
                n4.Start();
            }

            if (tutor1 == 6)
            {
                beat4 = 5;
                beat2 = 5;
                x2_1 = 0;
                x2_2 = -120;
                x2_3 = -240;
                x2_4 = -340;
                x2_5 = -440;


                x4_1 = -55;
                x4_2 = -190;
                x4_3 = -300;
                x4_4 = -405;
                x4_5 = -505;

                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Bass and Snare Tutorial";
                currtempo.Text = "Fast";
                goal1.Text = "120";
                n4.Interval = 25;
                n2.Interval = 25;
                n4.Start();
            }
            #endregion

            #region Tutor3
            if (tutor1 == 7)
            {
                beat4 = 5;
                beat1 = 5;
                x1_1 = 0;
                x1_2 = -120;
                x1_3 = -240;
                x1_4 = -340;
                x1_5 = -440;


                x4_1 = -55;
                x4_2 = -190;
                x4_3 = -300;
                x4_4 = -405;
                x4_5 = -505;

                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Hi-hat and Bass Tutorial";
                currtempo.Text = "Slow";
                goal1.Text = "60";
                n1.Interval = 50;
                n4.Interval = 50;
                n4.Start();
            }

            if (tutor1 == 8)
            {
                beat4 = 5;
                beat1 = 5;
                x1_1 = 0;
                x1_2 = -120;
                x1_3 = -240;
                x1_4 = -340;
                x1_5 = -440;


                x4_1 = -55;
                x4_2 = -190;
                x4_3 = -300;
                x4_4 = -405;
                x4_5 = -505;

                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Hi-hat and Bass Tutorial";
                currtempo.Text = "Normal";
                goal1.Text = "90";
                n1.Interval = 35;
                n4.Interval = 35;
                n4.Start();
            }

            if (tutor1 == 9)
            {
                beat4 = 5;
                beat1 = 5;
                x1_1 = 0;
                x1_2 = -120;
                x1_3 = -240;
                x1_4 = -340;
                x1_5 = -440;


                x4_1 = -55;
                x4_2 = -190;
                x4_3 = -300;
                x4_4 = -405;
                x4_5 = -505;




                indi2.Visible = true;
                indi3.Visible = true;
                indi4.Visible = true;
                goal1.Visible = true;
                curr1.Visible = true;

                indi3.Text = "Hi-hat and Bass Tutorial";
                goal1.Text = "120";
                currtempo.Text = "Fast";
                n1.Interval = 25;
                n4.Interval = 25;
                n4.Start();
            }

            #endregion

            #region Rock
            if (musictuto1 == 1)
            {
                if (set == 1)
                {

                    indi2.Visible = true;
                    indi3.Visible = true;
                    indi4.Visible = true;
                    goal1.Visible = true;
                    curr1.Visible = true;

                    indi3.Text = "Rock Tutorial";
                    goal1.Text = "90";
                    currtempo.Text = "Slow";

                    n1.Interval = 50;
                    n2.Interval = 50;
                    n3.Interval = 50;
                    n4.Interval = 50;

                    if (pattern == 1)
                    {
                        beat1 = 3;
                        beat2 = 1;
                        beat3 = 1;
                        beat4 = 1;

                        x1_3 = -200;
                        x3_1 = 25;
                        x4_1 = x3_1;
                        x2_1 = x1_3;
                    }
                    if(pattern == 2 || pattern == 4 || pattern == 6 || pattern ==8) //repeat on first beat
                    {
                        beat1 = 4;
                        beat4 = 2;
                        beat2 = 1;

                        x1_1 = 25;
                        x1_2 = -100;
                        x1_3 = -200;
                        x2_1 = x1_3;
                        x4_1 = x1_1;
                        x4_2 = x1_2;
                        
                    }

                    if(pattern == 3 || pattern == 5 || pattern == 7)
                    {
                        beat1 = 4;
                        beat4 = 1;
                        beat2 = 1;
                        x1_1 = 25;
                        x1_3 = -200;
                        x4_1 = x1_1;
                        x2_1 = x1_3;
                       

                    }


                }
            }
            #endregion
        }

        public void starts()
        {
            if (menu2.ch == 1 && menu2.subch ==0)
            {
                beat2 = 5;
                warmup = 1;
                textstuto();
            }
            if (menu2.ch == 2 && menu2.subch == 1)
            {
                beat1 = 5;
                tutor1 = 1;
                warmup = 0;
                textstuto();
            }
            if (menu2.ch == 2 && menu2.subch == 2)
            {
                beat1 = 5; 
                beat2 = 5;
                tutor1 = 7;
                warmup = 0;
                textstuto();
            }
            if (menu2.ch == 2 && menu2.subch == 3)
            {
                beat2 = 5;
                beat4 = 5;
                tutor1 = 4;
                warmup = 0;
                textstuto();
            }
   
        }

        public void musictuto()
        {
            #region Rock
            if(musictuto1 == 1)
            {
              
               if(set == 1){
               if(pattern == 1){
               if(hit1 < 3 && hit2 < 1 && hit3 < 1 && hit4 < 1)
               {
           

                   x3_1 = x4_1;
                   x2_1 = x1_2;

                   n1.Start();
                   n2.Start();
                   n3.Start();
                   n4.Start();
                   
                  } 
                   if(hit1 == 3 && hit2 == 1 && hit3 == 1 && hit4 == 1)
                   {
                       hit1 = 0;
                       hit2 = 0;
                       hit3 = 0;
                       hit4 = 0;
                       durations.Stop();
                       ones = 3;
                       timer1.Start();
                       pattern += 1;
                       textstuto();
                       score += 1;
                       curr1.Text = pattern.ToString();
                   }
                        
                }
               if (pattern == 2 && ones == 0)
               {
                
                   if (hit1 < 4 && hit2 < 1 && hit4 < 2)
                   {
                       beat1 = 4;
                       beat2 = 1;
                       beat4 = 2;

                       n1.Start();
                       n2.Start();
                       n4.Start();
                   }

                   if(hit1 == 4 && hit2 == 1 && hit4 == 2)
                   {
                       hit1 = 0;
                       hit2 = 0;
                       hit4 = 0;
                       durations.Stop();
                       ones = 3;
                       timer1.Start();
                       pattern += 1;
                       textstuto();
                       score += 1;
                       curr1.Text = pattern.ToString();
                   }
               }// end of pattern2

                if(pattern == 3 && ones == 0)
                {
                if(hit1 < 4 && hit2 < 1 && hit4 < 1)
                {
               
                    n1.Start();
                    n2.Start();
                    n4.Start();
                }
                if (hit1 == 4 && hit2 == 1 && hit4 == 1)
                {
                    hit1 = 0;
                    hit2 = 0;
                    hit4 = 0;
                    durations.Stop();
                    ones = 3;
                    timer1.Start();
                    pattern += 1;
                    textstuto();
                    score += 1;
                    curr1.Text = pattern.ToString();
                }
                }// end of pattern3
                   if(pattern == 4 && ones==0)
                   {
                       if (hit1 < 4 && hit2 < 1 && hit4 < 2)
                       {
                           beat1 = 4;
                           beat2 = 1;
                           beat4 = 2;

                           n1.Start();
                           n2.Start();
                           n4.Start();
                       }

                       if (hit1 == 4 && hit2 == 1 && hit4 == 2)
                       {
                           hit1 = 0;
                           hit2 = 0;
                           hit4 = 0;
                           durations.Stop();
                           ones = 3;
                           timer1.Start();
                           pattern += 1;
                           textstuto();
                           score += 1;
                           curr1.Text = pattern.ToString();
                       }
                   } // end of pattern 4

                   if (pattern == 5 && ones == 0)
                   {
                       if (hit1 < 4 && hit2 < 1 && hit4 < 1)
                       {
                           beat1 = 4;
                           beat2 = 1;
                           beat4 = 1;
                           n1.Start();
                           n2.Start();
                           n4.Start();
                       }
                       if (hit1 == 4 && hit2 == 1 && hit4 == 1)
                       {
                           hit1 = 0;
                           hit2 = 0;
                           hit4 = 0;
                           durations.Stop();
                           ones = 3;
                           timer1.Start();
                           pattern += 1;
                           textstuto();
                           score += 1;
                           curr1.Text = pattern.ToString();
                       }
                   }// end of pattern 5
                   if (pattern == 6 && ones == 0)
                   {
                       if (hit1 < 4 && hit2 < 1 && hit4 < 2)
                       {
                 

                           n1.Start();
                           n2.Start();
                           n4.Start();
                       }

                       if (hit1 == 4 && hit2 == 1 && hit4 == 2)
                       {
                           hit1 = 0;
                           hit2 = 0;
                           hit4 = 0;
                           durations.Stop();
                           ones = 3;
                           timer1.Start();
                           pattern += 1;
                           textstuto();
                           score += 1;
                           curr1.Text = pattern.ToString();
                       }
                   } // end of pattern 6

                   if (pattern == 7 && ones == 0)
                   {
                       if (hit1 < 4 && hit2 < 1 && hit4 < 1)
                       {
                           beat1 = 4;
                           beat2 = 1;
                           beat4 = 1;
                           n1.Start();
                           n2.Start();
                           n4.Start();
                       }
                       if (hit1 == 4 && hit2 == 1 && hit4 == 1)
                       {
                           hit1 = 0;
                           hit2 = 0;
                           hit4 = 0;
                           durations.Stop();
                           ones = 3;
                           timer1.Start();
                           pattern += 1;
                           textstuto();
                           score += 1;
                           curr1.Text = pattern.ToString();
                       }
                   }// end of pattern 7
                   if (pattern == 8 && ones == 0)
                   {
                       if (hit1 < 4 && hit2 < 1 && hit4 < 2)
                       {
                      

                           n1.Start();
                           n2.Start();
                           n4.Start();
                       }

                       if (hit1 == 4 && hit2 == 1 && hit4 == 2)
                       {
                           hit1 = 0;
                           hit2 = 0;
                           hit4 = 0;
                           durations.Stop();
                           //ones = 3;
                           //timer1.Start();
                           //pattern += 1;
                           //textstuto();
                           score += 1;
                           curr1.Text = pattern.ToString();
                       }
                   }
               }
             }
            #endregion
        }

        #endregion

        #region controls

        public void buttonactive1()
        {



            if (a1_1.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a1_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_1 = 0;

                a1_1.Location = new Point(12, x1_1);
                hit1 += 1;

                perfect += 1;
               
                ones = 1;
                delaytim.Start();

            }

            if (a1_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_1 = 0;
                a1_1.Location = new Point(12, x1_1);
                hit1 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();

            }


            if (a1_2.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a1_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_2 = -100;

                a1_2.Location = new Point(12, x1_2);
                hit1 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_2 = -100;
                a1_2.Location = new Point(12, x1_2);
                hit1 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_3.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a1_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_3 = -200;

                a1_3.Location = new Point(12, x1_3);
                hit1 += 1;

                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_3 = -200;
                a1_3.Location = new Point(12, x1_3);
                hit1 += 1;

                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_4.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a1_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_4 = -300;

                a1_4.Location = new Point(12, x1_4);
                hit1 += 1;

                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_4 = -300;
                a1_4.Location = new Point(12, x1_4);
                hit1 += 1;

                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_5.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a1_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_5 = -400;

                a1_5.Location = new Point(12, x1_5);
                hit1 += 1;

                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_5 = -400;
                a1_5.Location = new Point(12, x1_5);
                hit1 += 1;

                good += 1;
                ones = 1;
                delaytim.Start();
            }
        }

        public void buttonactive2() 
        {

            if (a2_1.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a2_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_1 = 0;

                a1_1.Location = new Point(89, x2_1);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_1 = 0;
                a2_1.Location = new Point(89, x2_1);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();

            }


            if (a2_2.Bounds.IntersectsWith(pnl1.Bounds) )
            {
                a2_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_2 = -100;

                a2_2.Location = new Point(89, x2_2);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_2 = -100;
                a2_2.Location = new Point(89, x2_2);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_3.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a2_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_3 = -200;

                a2_3.Location = new Point(89, x2_3);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_3 = -200;
                a2_3.Location = new Point(89, x2_3);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_4.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a2_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_4 = -300;

                a2_4.Location = new Point(89, x2_4);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_4 = -300;
                a2_4.Location = new Point(89, x2_4);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_5.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a2_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_5 = -400;

                a2_5.Location = new Point(89, x2_5);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_5 = -400;
                a2_5.Location = new Point(89, x1_5);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
        }

        public void buttonactive3() 
        {


            if (a3_1.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a3_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_1 = 0;

                a3_1.Location = new Point(163, x3_1);
                hit3 += 1;
                //n3.Stop();
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_1 = 0;
                a3_1.Location = new Point(163, x3_1);
                hit3 += 1;
                //n3.Stop();
                good += 1;
                ones = 1;
                delaytim.Start();
            }


            if (a3_2.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a3_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_2 = -100;

                a3_2.Location = new Point(163, x3_2);
                hit3 += 1;
                //n3.Stop();
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_2 = -100;
                a3_2.Location = new Point(163, x3_2);
                hit3 += 1;
                //n3.Stop();
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_3.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a3_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_3 = -200;
                
                a3_3.Location = new Point(163, x3_3);
                hit3 += 1;
                //n3.Stop();
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_3 = -200;
                a3_3.Location = new Point(163, x3_3);
                hit3 += 1;
                //n3.Stop();
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_4.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a3_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_4 = -300;
                
                a3_4.Location = new Point(163, x3_4);
                hit3 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_4 = -300;
                a3_4.Location = new Point(163, x3_4);
                hit3 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_5.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a3_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_5 = -400;
                
                a3_5.Location = new Point(163, x3_5);
                hit3 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_5 = -400;
                a3_5.Location = new Point(163, x3_5);
                hit3 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
        
        }
        
        public void buttonactive4() 
        {


            if (a4_1.Bounds.IntersectsWith(pnl1.Bounds) )
            {
                a4_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_1 = 0;
                
                a4_1.Location = new Point(239, x4_1);
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_1 = 0;
                a4_1.Location = new Point(239, x4_1);
                //n4.Stop();
                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_2.Bounds.IntersectsWith(pnl1.Bounds) )
            {
                a4_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_2 = -100;
                
                a4_2.Location = new Point(239, x4_2);
                //n4.Stop();
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_2 = -100;
                a4_2.Location = new Point(239, x4_2);
                //n4.Stop();
                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
            if (a4_3.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a4_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_3 = -200;
                a4_3.Location = new Point(239, x4_3);
                //n4.Stop();
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_3 = -200;
                a4_3.Location = new Point(239, x4_3);
                //n4.Stop();

                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
            if (a4_4.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a4_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_4 = -300;

                a4_1.Location = new Point(239, x4_4);
                //n4.Stop();
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_4 = -300;
                a4_4.Location = new Point(239, x4_4);
                // n4.Stop();
                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
            if (a4_5.Bounds.IntersectsWith(pnl1.Bounds))
            {
                a4_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_5 = -400;
                
                a4_5.Location = new Point(239, x4_5);
                //n4.Stop();
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_5 = -400;
                a4_5.Location = new Point(239, x4_5);
                //n4.Stop();
                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
        }

        /* For calibration
           public void buttonactive1()
        {



            if (a1_1.Bounds.IntersectsWith(pnl1.Bounds) && a1_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_1 = 0;

                a1_1.Location = new Point(12, x1_1);
                hit1 += 1;

                perfect += 1;
                ones = 1;
                delaytim.Start();

            }

            if (a1_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_1 = 0;
                a1_1.Location = new Point(12, x1_1);
                hit1 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();

            }


            if (a1_2.Bounds.IntersectsWith(pnl1.Bounds) && a1_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_2 = -100;

                a1_2.Location = new Point(12, x1_2);
                hit1 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_2 = -100;
                a1_2.Location = new Point(12, x1_2);
                hit1 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_3.Bounds.IntersectsWith(pnl1.Bounds) && a1_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_3 = -200;

                a1_3.Location = new Point(12, x1_3);
                hit1 += 1;

                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_3 = -200;
                a1_3.Location = new Point(12, x1_3);
                hit1 += 1;

                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_4.Bounds.IntersectsWith(pnl1.Bounds) && a1_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_4 = -300;

                a1_4.Location = new Point(12, x1_4);
                hit1 += 1;

                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_4 = -300;
                a1_4.Location = new Point(12, x1_4);
                hit1 += 1;

                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_5.Bounds.IntersectsWith(pnl1.Bounds) && a1_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x1_5 = -400;

                a1_5.Location = new Point(12, x1_5);
                hit1 += 1;

                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a1_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a1_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x1_5 = -400;
                a1_5.Location = new Point(12, x1_5);
                hit1 += 1;

                good += 1;
                ones = 1;
                delaytim.Start();
            }
        }

        public void buttonactive2() 
        {

            if (a2_1.Bounds.IntersectsWith(pnl1.Bounds) && a2_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_1 = 0;

                a1_1.Location = new Point(89, x2_1);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_1 = 0;
                a2_1.Location = new Point(89, x2_1);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();

            }


            if (a2_2.Bounds.IntersectsWith(pnl1.Bounds) && a2_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_2 = -100;

                a2_2.Location = new Point(89, x2_2);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_2 = -100;
                a2_2.Location = new Point(89, x2_2);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_3.Bounds.IntersectsWith(pnl1.Bounds) && a2_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_3 = -200;

                a2_3.Location = new Point(89, x2_3);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_3 = -200;
                a2_3.Location = new Point(89, x2_3);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_4.Bounds.IntersectsWith(pnl1.Bounds) && a2_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_4 = -300;

                a2_4.Location = new Point(89, x2_4);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_4 = -300;
                a2_4.Location = new Point(89, x2_4);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_5.Bounds.IntersectsWith(pnl1.Bounds) && a2_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x2_5 = -400;

                a2_5.Location = new Point(89, x2_5);
                hit2 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a2_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a2_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x2_5 = -400;
                a2_5.Location = new Point(89, x1_5);
                hit2 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
        }

        public void buttonactive3() 
        {


            if (a3_1.Bounds.IntersectsWith(pnl1.Bounds) && a3_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_1 = 0;

                a3_1.Location = new Point(163, x3_1);
                hit3 += 1;
                //n3.Stop();
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_1 = 0;
                a3_1.Location = new Point(163, x3_1);
                hit3 += 1;
                //n3.Stop();
                good += 1;
                ones = 1;
                delaytim.Start();
            }


            if (a3_2.Bounds.IntersectsWith(pnl1.Bounds) && a3_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_2 = -100;

                a3_2.Location = new Point(163, x3_2);
                hit3 += 1;
                //n3.Stop();
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_2 = -100;
                a3_2.Location = new Point(163, x3_2);
                hit3 += 1;
                //n3.Stop();
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_3.Bounds.IntersectsWith(pnl1.Bounds) && a3_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_3 = -200;
                ;
                a3_3.Location = new Point(163, x3_3);
                hit3 += 1;
                //n3.Stop();
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_3 = -200;
                a3_3.Location = new Point(163, x3_3);
                hit3 += 1;
                //n3.Stop();
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_4.Bounds.IntersectsWith(pnl1.Bounds) && a3_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_4 = -300;
                
                a3_4.Location = new Point(163, x3_4);
                hit3 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_4 = -300;
                a3_4.Location = new Point(163, x3_4);
                hit3 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_5.Bounds.IntersectsWith(pnl1.Bounds) && a3_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x3_5 = -400;
                
                a3_5.Location = new Point(163, x3_5);
                hit3 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a3_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a3_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x3_5 = -400;
                a3_5.Location = new Point(163, x3_5);
                hit3 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
        
        }
        
        public void buttonactive4() 
        {


            if (a4_1.Bounds.IntersectsWith(pnl1.Bounds) && a4_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_1 = 0;
                
                a4_1.Location = new Point(239, x4_1);
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_1.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_1.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_1 = 0;
                a4_1.Location = new Point(239, x4_1);
                //n4.Stop();
                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_2.Bounds.IntersectsWith(pnl1.Bounds) && a4_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_2 = -100;
                
                a4_2.Location = new Point(239, x4_2);
                //n4.Stop();
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_2.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_2.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_2 = -100;
                a4_2.Location = new Point(239, x4_2);
                //n4.Stop();
                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
            if (a4_3.Bounds.IntersectsWith(pnl1.Bounds) && a4_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_3 = -200;
                a4_3.Location = new Point(239, x4_3);
                //n4.Stop();
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_3.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_3.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_3 = -200;
                a4_3.Location = new Point(239, x4_3);
                //n4.Stop();

                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
            if (a4_4.Bounds.IntersectsWith(pnl1.Bounds) && a4_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_4 = -300;

                a4_1.Location = new Point(239, x4_4);
                //n4.Stop();
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_4.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_4.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_4 = -300;
                a4_4.Location = new Point(239, x4_4);
                // n4.Stop();
                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
            if (a4_5.Bounds.IntersectsWith(pnl1.Bounds) && a4_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Perfect";
                x4_5 = -400;
                
                a4_5.Location = new Point(239, x4_5);
                //n4.Stop();
                hit4 += 1;
                perfect += 1;
                ones = 1;
                delaytim.Start();
            }

            if (a4_5.Bounds.IntersectsWith(pnl2.Bounds))
            {
                a4_5.Visible = false;
                indi1.Visible = true;
                indi1.Text = "Good";

                x4_5 = -400;
                a4_5.Location = new Point(239, x4_5);
                //n4.Stop();
                hit4 += 1;
                good += 1;
                ones = 1;
                delaytim.Start();
            }
        }*/

        #endregion

        public drumstutos()
        {
            InitializeComponent();
            sticks = new SoundPlayer(drumtuto_main.Properties.Resources.countdown);
            snare = new SoundPlayer(drumtuto_main.Properties.Resources.snare);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region designs
            groupBox2.BackColor = Color.FromArgb(170, Color.Black);
            groupBox1.BackColor = Color.FromArgb(170, Color.Black);
            drumpic.BackColor = Color.FromArgb(120, Color.Black);
            panel1.BackColor = Color.FromArgb(170, Color.Black);
            gpins1.BackColor = Color.FromArgb(110, Color.Black);
            stats1.BackColor = Color.FromArgb(110, Color.Black); 
            drumpic.BackgroundImage = drumtuto_main.Properties.Resources._129852011_395377775244478_5922764547471579795_n;
            indi1.Parent = panel1;
            stats1.Parent = panel1;
            gpins1.Paint += new PaintEventHandler(gpins1_Paint);
            stats1.Paint += new PaintEventHandler(stats1_Paint);
            #endregion

            #region stopwatches
            watch = Stopwatch.StartNew();

            watch1_1 = Stopwatch.StartNew();
            watch1_2 = Stopwatch.StartNew();
            watch1_3 = Stopwatch.StartNew();
            watch1_4 = Stopwatch.StartNew();
            watch1_5 = Stopwatch.StartNew();
            watch1_6 = Stopwatch.StartNew();
            watch1_7 = Stopwatch.StartNew();
            watch1_8 = Stopwatch.StartNew();


            watch2_1 = Stopwatch.StartNew();
            watch2_2 = Stopwatch.StartNew();
            watch2_3 = Stopwatch.StartNew();
            watch2_4 = Stopwatch.StartNew();
            watch2_5 = Stopwatch.StartNew();
            watch2_6 = Stopwatch.StartNew();
            watch2_7 = Stopwatch.StartNew();
            watch2_8 = Stopwatch.StartNew();


            watch3_1 = Stopwatch.StartNew();
            watch3_2 = Stopwatch.StartNew();
            watch3_3 = Stopwatch.StartNew();
            watch3_4 = Stopwatch.StartNew();
            watch3_5 = Stopwatch.StartNew();
            watch3_6 = Stopwatch.StartNew();
            watch3_7 = Stopwatch.StartNew();
            watch3_8 = Stopwatch.StartNew();

            watch4_1 = Stopwatch.StartNew();
            watch4_2 = Stopwatch.StartNew();
            watch4_3 = Stopwatch.StartNew();
            watch4_4 = Stopwatch.StartNew();
            watch4_5 = Stopwatch.StartNew();
            watch4_6 = Stopwatch.StartNew();
            watch4_7 = Stopwatch.StartNew();
            watch4_8 = Stopwatch.StartNew();

#endregion

            #region startingdes
            starts();
            durations.Stop();
            n1.Stop();
            n2.Stop();
            n3.Stop();
            n4.Stop();
            n5.Stop();
            n6.Stop();
            n7.Stop();
            n8.Stop();
            indi1.SendToBack();
            #endregion

          
        }

        void stats1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, stats1.ClientRectangle,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        void gpins1_Paint(object sender, PaintEventArgs e)
        {

                   ControlPaint.DrawBorder(e.Graphics, gpins1.ClientRectangle,
                  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
                  SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void p1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string p1s = p1.ReadExisting().ToString();

            if (p1s.StartsWith("X"))

            {
                Button.CheckForIllegalCrossThreadCalls = false;
               buttonactive4(); 
                //a1.BackgroundImage = drumtuto_main.Properties.Resources.b1activated;
                //b1.Visible = true;

            }

            if (p1s.StartsWith("V"))
            {
                Button.CheckForIllegalCrossThreadCalls = false;
                buttonactive2();

            }
            if (p1s.StartsWith("V") && stats1.Visible == true)
            {
                Button.CheckForIllegalCrossThreadCalls = false;
                buttonactive4();

                p1.Close();
                this.Close();
                menu b = new menu();
                b.Show();
            }
        }

        private void durations_Tick(object sender, EventArgs e)
        {

            
           warmups();
            tuto1();
            musictuto();
            
        }

        private void n1_Tick(object sender, EventArgs e)
        {


            if (beat1 == 1)
            {
                if (hit1 == 0)
                {
                    a1_1.Visible = true;
                    x1_1 += 3080 / 577;
                    a1_1.Location = new Point(12, x1_1);
                }
                if (hit1 == 1)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);
                    n1.Stop();
                }
            }
            if (beat1 == 2)
            {
                if (hit1 == 0)
                {
                    a1_1.Visible = true;
                    x1_1 += 3080 / 577;
                    a1_1.Location = new Point(12, x1_1);
                }
                if (watch1_1.ElapsedMilliseconds > 15)
                {
                    a1_2.Visible = true;
                    x1_2 += 3080 / 577;
                    a1_2.Location = new Point(12, x1_2);
                }
                watch1_1 = Stopwatch.StartNew();
                if (hit1 == 2)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);
                    n1.Stop();
                }


            }
            if (beat1 == 3)
            {
                if (hit1 == 0)
                {
                    a1_1.Visible = true;
                    x1_1 += 3080 / 577;
                    a1_1.Location = new Point(12, x1_1);
                }
                if (hit1 == 1)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);
                }


                if (watch1_1.ElapsedMilliseconds > 15)
                {
                    a1_2.Visible = true;
                    x1_2 += 3080 / 577;
                    a1_2.Location = new Point(12, x1_2);
                }
                watch1_1 = Stopwatch.StartNew();
                if (hit1 == 2)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);
                }
                if (watch1_2.ElapsedMilliseconds > 15)
                {
                    a1_3.Visible = true;
                    x1_3 += 3080 / 577;
                    a1_3.Location = new Point(12, x1_3);
                }
                watch1_2 = Stopwatch.StartNew();

                if (hit1 == 3)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);

                    a1_3.Visible = false;
                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);

                    n1.Stop();

                }
            }
            if (beat1 == 4)
            {
                if (hit1 == 0)
                {
                    a1_1.Visible = true;
                    x1_1 += 3080 / 577;
                    a1_1.Location = new Point(12, x1_1);
                }
                if (hit1 == 1)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);
                }


                if (watch1_1.ElapsedMilliseconds > 15)
                {
                    a1_2.Visible = true;
                    x1_2 += 3080 / 577;
                    a1_2.Location = new Point(12, x1_2);
                }
                watch1_1 = Stopwatch.StartNew();
                if (hit1 == 2)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);

                }
                if (watch1_2.ElapsedMilliseconds > 15)
                {
                    a1_3.Visible = true;
                    x1_3 += 3080 / 577;
                    a1_3.Location = new Point(12, x1_3);
                }
                watch1_2 = Stopwatch.StartNew();

                if (hit1 == 3)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);

                    a1_3.Visible = false;
                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);
                }

                if (watch1_3.ElapsedMilliseconds > 15)
                {
                    a1_4.Visible = true;
                    x1_4 += 3080 / 577;
                    a1_4.Location = new Point(12, x1_4);
                }
                if (hit1 == 4)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);

                    a1_3.Visible = false;
                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);

                    a1_4.Visible = false;
                    x1_4 = -300;
                    a1_4.Location = new Point(12, x1_4);
                    n1.Stop();
                }
            }
            if (beat1 == 5)
            {
                if (hit1 == 0)
                {
                    a1_1.Visible = true;
                    x1_1 += 3080 / 577;
                    a1_1.Location = new Point(12, x1_1);
                }
                if (hit1 == 1)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);
                }


                if (watch1_1.ElapsedMilliseconds > 15)
                {
                    a1_2.Visible = true;
                    x1_2 += 3080 / 577;
                    a1_2.Location = new Point(12, x1_2);
                }
                watch1_1 = Stopwatch.StartNew();
                if (hit1 == 2)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);
                }
                if (watch1_2.ElapsedMilliseconds > 15)
                {
                    a1_3.Visible = true;
                    x1_3 += 3080 / 577;
                    a1_3.Location = new Point(12, x1_3);
                }
                watch1_2 = Stopwatch.StartNew();

                if (hit1 == 3)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);

                    a1_3.Visible = false;
                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);
                }

                if (watch1_3.ElapsedMilliseconds > 15)
                {
                    a1_4.Visible = true;
                    x1_4 += 3080 / 577;
                    a1_4.Location = new Point(12, x1_4);
                }
                watch1_3 = Stopwatch.StartNew();
                if (hit1 == 4)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);

                    a1_3.Visible = false;
                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);

                    a1_4.Visible = false;
                    x1_4 = -300;
                    a1_4.Location = new Point(12, x1_4);
                }

                if (watch1_4.ElapsedMilliseconds > 15)
                {
                    a1_5.Visible = true;
                    x1_5 += 3080 / 577;
                    a1_5.Location = new Point(12, x1_5);
                }
                watch1_4 = Stopwatch.StartNew();

                if (hit1 == 5)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);

                    a1_2.Visible = false;
                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);

                    a1_3.Visible = false;
                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);

                    a1_4.Visible = false;
                    x1_4 = -300;
                    a1_4.Location = new Point(12, x1_4);

                    a1_5.Visible = false;
                    x1_5 = -400;
                    a1_5.Location = new Point(12, x1_5);
                    n1.Stop();
                }
            }
            if (a1_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_1 = 0;

                a1_1.Visible = false;
                indi1.Visible = false;
                a1_1.Location = new Point(12, x1_1);
                miss += 1;
                hit1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a1_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_2 = -100;

                a1_2.Visible = false;
                indi1.Visible = false;
                a1_2.Location = new Point(12, x1_2);
                miss += 1;
                hit1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a1_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_3 = -200;

                a1_3.Visible = false;
                indi1.Visible = false;
                a1_3.Location = new Point(12, x1_3);
                miss += 1;
                hit1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a1_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_4 = -300;

                a1_4.Visible = false;
                indi1.Visible = false;
                a1_4.Location = new Point(12, x1_4);
                miss += 1;
                hit1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a1_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_5 = -400;

                a1_5.Visible = false;
                indi1.Visible = false;
                a1_5.Location = new Point(12, x1_5);
                miss += 1;
                hit1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }

        
        }

        private void n2_Tick(object sender, EventArgs e)
        {

            if (beat2 == 1)
            {
                if (hit2 == 0)
                {
                    a2_1.Visible = true;
                    x2_1 += 3080 / 577;
                    a2_1.Location = new Point(89, x2_1);
                }
                if (hit2 == 1)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                    n2.Stop();
                }
            }
            if (beat2 == 2)
            {
                if (hit2 == 0)
                {
                    a2_1.Visible = true;
                    x2_1 += 3080 / 577;
                    a2_1.Location = new Point(89, x2_1);
                }
                if (watch2_1.ElapsedMilliseconds > 15)
                {
                    a2_2.Visible = true;
                    x2_2 += 3080 / 577;
                    a2_2.Location = new Point(89, x2_2);
                }
                watch2_1 = Stopwatch.StartNew();
                if (hit2 == 2)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);
                    n2.Stop();
                }


            }
            if (beat2 == 3)
            {
                if (hit2 == 0)
                {
                    a2_1.Visible = true;
                    x2_1 += 3080 / 577;
                    a2_1.Location = new Point(89, x2_1);
                }
                if (hit2 == 1)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                }


                if (watch2_1.ElapsedMilliseconds > 15)
                {
                    a2_2.Visible = true;
                    x2_2 += 3080 / 577;
                    a2_2.Location = new Point(89, x2_1);
                }
                watch2_1 = Stopwatch.StartNew();
                if (hit2 == 2)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);
                }
                if (watch2_2.ElapsedMilliseconds > 15)
                {
                    a2_3.Visible = true;
                    x2_3 += 3080 / 577;
                    a2_3.Location = new Point(89, x2_3);
                }
                watch2_2 = Stopwatch.StartNew();

                if (hit2 == 3)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);

                    a2_3.Visible = false;
                    x2_3 = -200;
                    a2_3.Location = new Point(89, x2_3);

                    n2.Stop();

                }
            }
            if (beat2 == 4)
            {
                if (hit2 == 0)
                {
                    a2_1.Visible = true;
                    x2_1 += 3080 / 577;
                    a2_1.Location = new Point(89, x2_1);
                }
                if (hit2 == 1)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                }


                if (watch2_1.ElapsedMilliseconds > 15)
                {
                    a2_2.Visible = true;
                    x2_2 += 3080 / 577;
                    a2_2.Location = new Point(89, x2_2);
                }
                watch2_1 = Stopwatch.StartNew();
                if (hit2 == 2)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);
                }
                if (watch2_2.ElapsedMilliseconds > 15)
                {
                    a2_3.Visible = true;
                    x2_3 += 3080 / 577;
                    a2_3.Location = new Point(89, x2_3);
                }
                watch2_2 = Stopwatch.StartNew();

                if (hit2 == 3)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);

                    a2_3.Visible = false;
                    x2_3 = -200;
                    a2_3.Location = new Point(89, x2_3);
                }

                if (watch2_3.ElapsedMilliseconds > 15)
                {
                    a2_4.Visible = true;
                    x2_4 += 3080 / 577;
                    a2_4.Location = new Point(89, x2_4);
                }
                if (hit2 == 4)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);

                    a2_3.Visible = false;
                    x2_3 = -200;
                    a2_3.Location = new Point(89, x2_3);

                    a2_4.Visible = false;
                    x2_4 = -300;
                    a2_4.Location = new Point(89, x2_4);
                    n2.Stop();
                }
            }
            if (beat2 == 5)
            {
                if (hit2 == 0)
                {
                    a2_1.Visible = true;
                    x2_1 += 3080 / 577;
                    a2_1.Location = new Point(89, x2_1);
                }
                if (hit2 == 1)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                }


                if (watch2_1.ElapsedMilliseconds > 15)
                {
                    a2_2.Visible = true;
                    x2_2 += 3080 / 577;
                    a2_2.Location = new Point(89, x2_2);
                }
                watch2_1 = Stopwatch.StartNew();
                if (hit2 == 2)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);
                }
                if (watch2_2.ElapsedMilliseconds > 15)
                {
                    a2_3.Visible = true;
                    x2_3 += 3080 / 577;
                    a2_3.Location = new Point(89, x2_3);
                }
                watch2_2 = Stopwatch.StartNew();

                if (hit2 == 3)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);

                    a2_3.Visible = false;
                    x2_3 = -200;
                    a2_3.Location = new Point(89, x2_3);
                }

                if (watch2_3.ElapsedMilliseconds > 15)
                {
                    a2_4.Visible = true;
                    x2_4 += 3080 / 577;
                    a2_4.Location = new Point(89, x2_4);
                }
                watch2_3 = Stopwatch.StartNew();
                if (hit2 == 4)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);

                    a2_3.Visible = false;
                    x2_3 = -200;
                    a2_3.Location = new Point(89, x2_3);

                    a2_4.Visible = false;
                    x2_4 = -300;
                    a2_4.Location = new Point(89, x2_4);
                }

                if (watch2_4.ElapsedMilliseconds > 15)
                {
                    a2_5.Visible = true;
                    x2_5 += 3080 / 577;
                    a2_5.Location = new Point(89, x2_5);
                }
                watch2_4 = Stopwatch.StartNew();

                if (hit2 == 5)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);

                    a2_2.Visible = false;
                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);

                    a2_3.Visible = false;
                    x2_3 = -200;
                    a2_3.Location = new Point(89, x2_3);

                    a2_4.Visible = false;
                    x2_4 = -300;
                    a2_4.Location = new Point(89, x2_4);

                    a2_5.Visible = false;
                    x2_5 = -400;
                    a2_5.Location = new Point(89, x2_5);
                    n2.Stop();
                }
            }
            if (a2_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x2_1 = 0;

                a2_1.Visible = false;
                indi1.Visible = false;
                a2_1.Location = new Point(89, x2_1);
                miss += 1;
                hit2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a2_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x2_2 = -100;

                a2_2.Visible = false;
                indi1.Visible = false;
                a2_2.Location = new Point(89, x2_2);
                miss += 1;
                hit2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a2_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x2_3 = -200;

                a2_3.Visible = false;
                indi1.Visible = false;
                a2_3.Location = new Point(89, x2_3);
                miss += 1;
                hit2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a2_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x2_4 = -300;

                a2_4.Visible = false;
                indi1.Visible = false;
                a2_4.Location = new Point(89, x2_4);
                miss += 1;
                hit2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a2_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x2_5 = -400;

                a2_5.Visible = false;
                indi1.Visible = false;
                a2_5.Location = new Point(89, x2_5);
                miss += 1;
                hit2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }

        
        } 

        private void n3_Tick(object sender, EventArgs e)
        {

            if(beat3 == 1)
            {
                if(hit3 == 0)
                {
                a3_1.Visible = true;
                x3_1 += 3080 / 577;
                a3_1.Location = new Point(163, x3_1);
                }
                if(hit3 == 1)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);
                    n3.Stop();
                }
            }
            if (beat3 == 2)
            {
                if(hit3 == 0)
                {
                a3_1.Visible = true;
                x3_1 += 3080 / 577;
                a3_1.Location = new Point(163, x3_1);
                }
                if(watch3_1.ElapsedMilliseconds > 15)
                {
                a3_2.Visible = true;
                x3_2 += 3080 / 577;
                a3_2.Location = new Point(163, x3_2);
                }
                watch3_1 = Stopwatch.StartNew();
                if(hit3 == 2)
                {
                    a3_1.Visible = false;
                    x3_1 =0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);
                    n3.Stop();
                }


            }
            if (beat3 == 3)
            {
                if(hit3 == 0)
                {
                a3_1.Visible = true;
                x3_1 += 3080 / 577;
                a3_1.Location = new Point(163, x3_1);
                }
                if(hit3 == 1)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);
                }
                
                
                if(watch3_1.ElapsedMilliseconds > 15)
                {
                a3_2.Visible = true;
                x3_2 += 3080 / 577;
                a3_2.Location = new Point(163, x3_2);
                }
                watch3_1 = Stopwatch.StartNew();
                if(hit3 == 2)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);
                }
                if(watch3_2.ElapsedMilliseconds > 15)
                {
                a3_3.Visible = true;
                x3_3 += 3080 / 577;
                a3_3.Location = new Point(163, x3_3);
                }
                watch3_2 = Stopwatch.StartNew();

                if(hit3 == 3)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);
                    
                    a3_3.Visible = false;
                    x3_3 = -200;
                    a3_3.Location = new Point(163, x3_3);

                    n3.Stop();

                }
            }
            if (beat3 == 4)
            {
                if (hit3 == 0)
                {
                    a3_1.Visible = true;
                    x3_1 += 3080 / 577;
                    a3_1.Location = new Point(163, x3_1);
                }
                if (hit3 == 1)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);
                }


                if (watch3_1.ElapsedMilliseconds > 15)
                {
                    a3_2.Visible = true;
                    x3_2 += 3080 / 577;
                    a3_2.Location = new Point(163, x3_2);
                }
                watch3_1 = Stopwatch.StartNew();
                if (hit3 == 2)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);
                }
                if (watch3_2.ElapsedMilliseconds > 15)
                {
                    a3_3.Visible = true;
                    x3_3 += 3080 / 577;
                    a3_3.Location = new Point(163, x3_3);
                }
                watch3_2 = Stopwatch.StartNew();

                if (hit3 == 3)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);

                    a3_3.Visible = false;
                    x3_3 = -200;
                    a3_3.Location = new Point(163, x3_3);
                }

                if(watch3_3.ElapsedMilliseconds > 15)
                {
                    a3_4.Visible = true;
                    x3_4 += 3080 / 577;
                    a3_4.Location = new Point(163, x3_4);
                }
                if(hit3 == 4)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);

                    a3_3.Visible = false;
                    x3_3 = -200;
                    a3_3.Location = new Point(163, x3_3);

                    a3_4.Visible = false;
                    x3_4 = -300;
                    a3_4.Location = new Point(163, x3_4);
                    n3.Stop();
                }
            }
            if (beat3 == 5)
            {
                if (hit3 == 0)
                {
                    a3_1.Visible = true;
                    x3_1 += 3080 / 577;
                    a3_1.Location = new Point(163, x3_1);
                }
                if (hit3 == 1)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);
                }


                if (watch3_1.ElapsedMilliseconds > 15)
                {
                    a3_2.Visible = true;
                    x3_2 += 3080 / 577;
                    a3_2.Location = new Point(163, x3_2);
                }
                watch3_1 = Stopwatch.StartNew();
                if (hit3 == 2)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);
                }
                if (watch3_2.ElapsedMilliseconds > 15)
                {
                    a3_3.Visible = true;
                    x3_3 += 3080 / 577;
                    a3_3.Location = new Point(163, x3_3);
                }
                watch3_2 = Stopwatch.StartNew();

                if (hit3 == 3)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);

                    a3_3.Visible = false;
                    x3_3 = -200;
                    a3_3.Location = new Point(163, x3_3);
                }

                if (watch3_3.ElapsedMilliseconds > 15)
                {
                    a3_4.Visible = true;
                    x3_4 += 3080 / 577;
                    a3_4.Location = new Point(163, x3_4);
                }
                watch3_3 = Stopwatch.StartNew();
                if (hit3 == 4)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);

                    a3_3.Visible = false;
                    x3_3 = -200;
                    a3_3.Location = new Point(163, x3_3);

                    a3_4.Visible = false;
                    x3_4 = -300;
                    a3_4.Location = new Point(163, x3_4);
                }

                if(watch3_4.ElapsedMilliseconds > 15)
                {
                    a3_5.Visible = true;
                    x3_5 += 3080 / 577;
                    a3_5.Location = new Point(163, x3_5);
                }
                watch3_4 = Stopwatch.StartNew();

                if(hit3 == 5)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);

                    a3_3.Visible = false;
                    x3_3 = -200;
                    a3_3.Location = new Point(163, x3_3);

                    a3_4.Visible = false;
                    x3_4 = -300;
                    a3_4.Location = new Point(163, x3_4);

                    a3_5.Visible = false;
                    x3_5 = -400;
                    a3_5.Location = new Point(163, x3_5);
                    n3.Stop();
                }
            }
            if (a3_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x3_1 =  0;
                
                a3_1.Visible = false;
                indi1.Visible = false;
                a3_1.Location = new Point(163, x3_1);
                miss += 1;
                hit3 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a3_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x3_2 = -100;
            
                a3_2.Visible = false;
                indi1.Visible = false;
                a3_2.Location = new Point(163, x3_2);
                miss += 1;
                hit3 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a3_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x3_3 = -200;
                
                a3_3.Visible = false;
                indi1.Visible = false;
                a3_3.Location = new Point(163, x3_3);
                miss += 1;
                hit3 += 1;
                //n3.Stop();
            }
            if (a3_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x3_4 = -300;
                
                a3_4.Visible = false;
                indi1.Visible = false;
                a3_4.Location = new Point(163, x3_4);
                miss += 1;
                hit3 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }
            if (a3_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x3_5 = -400;
                
                a3_5.Visible = false;
                indi1.Visible = false;
                a3_5.Location = new Point(163, x3_5);
                miss += 1;
                hit3 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n3.Stop();
            }

        }

        private void n4_Tick(object sender, EventArgs e)
        {
          
            if(beat4 == 1)
            {
                if(hit4 == 0)
                {
                a4_1.Visible = true;
                x4_1 += 3080 / 577;
                a4_1.Location = new Point(239, x4_1);
                }
                if(hit4 == 1)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);
                    n4.Stop();
                }
            }
            if (beat4 == 2)
            {
                if (hit4 == 0)
                {
                    a4_1.Visible = true;
                    x4_1 += 3080 / 577;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (hit4 == 1)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                }

                if (watch4_1.ElapsedMilliseconds > 15)
                {
                    a4_2.Visible = true;
                    x4_2 += 3080 / 577;
                    a4_2.Location = new Point(239, x4_2);
                }
                watch4_1 = Stopwatch.StartNew();

                if(hit4 == 2)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 =-100;
                    a4_2.Location = new Point(239, x4_2);
                    n4.Stop();
                }
            }
            if (beat4 == 3)
            {
                if (hit4 == 0)
                {
                    a4_1.Visible = true;
                    x4_1 += 3080 / 577;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (hit4 == 1)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);
 
                }
                if(hit4 == 1 )
                {

                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (watch4_1.ElapsedMilliseconds > 15)
                {
                    a4_2.Visible = true;
                    x4_2 += 3080 / 577;
                    a4_2.Location = new Point(239, x4_2);
                }
                watch4_1 = Stopwatch.StartNew();
                if(hit4 == 2)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);
                }
                if (watch4_2.ElapsedMilliseconds > 15)
                {
                    a4_3.Visible = true;
                    x4_3 += 3080 / 577;
                    a4_3.Location = new Point(239, x4_3);
                }
                watch4_2 = Stopwatch.StartNew();


                if(hit4 == 3)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);

                    a4_3.Visible = false;
                    x4_3= -200;
                    a4_3.Location = new Point(239, x4_3);

                    n4.Stop();
                }
            }
            if (beat4 == 4)
            {
                if (hit4 == 0)
                {
                    a4_1.Visible = true;
                    x4_1 += 3080 / 577;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (hit4 == 1)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                }
                if (hit4 == 1)
                {

                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (watch4_1.ElapsedMilliseconds > 15)
                {
                    a4_2.Visible = true;
                    x4_2 += 3080 / 577;
                    a4_2.Location = new Point(239, x4_2);
                }
                watch4_1 = Stopwatch.StartNew();
                if (hit4 == 2)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);
                }
                if (watch4_2.ElapsedMilliseconds > 15)
                {
                    a4_3.Visible = true;
                    x4_3 += 3080 / 577;
                    a4_3.Location = new Point(239, x4_3);
                }
                watch4_2 = Stopwatch.StartNew();


                if (hit4 == 3)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);

                    a4_3.Visible = false;
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);

                  
                }

                if(watch4_3.ElapsedMilliseconds > 15)
                {
                    a4_4.Visible = true;
                    x4_4 += 3080 / 577;
                    a4_4.Location = new Point(239, x4_4);
                }

                watch4_3 = Stopwatch.StartNew();
                if(hit4==4)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);

                    a4_3.Visible = false;
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);

                    a4_4.Visible = false;
                    x4_4 = -300;
                    a4_4.Location = new Point(239, x4_4);

                    n4.Stop();
                }
            }
            if (beat4 == 5)
            {
                if (hit4 == 0)
                {
                    a4_1.Visible = true;
                    x4_1 += 3080 / 577;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (hit4 == 1)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                }
                if (hit4 == 1)
                {

                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (watch4_1.ElapsedMilliseconds > 15)
                {
                    a4_2.Visible = true;
                    x4_2 += 3080 / 577;
                    a4_2.Location = new Point(239, x4_2);
                }
                watch4_1 = Stopwatch.StartNew();
                if (hit4 == 2)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);
                }
                if (watch4_2.ElapsedMilliseconds > 15)
                {
                    a4_3.Visible = true;
                    x4_3 += 3080 / 577;
                    a4_3.Location = new Point(239, x4_3);
                }
                watch4_2 = Stopwatch.StartNew();


                if (hit4 == 3)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);

                    a4_3.Visible = false;
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);


                }

                if (watch4_3.ElapsedMilliseconds > 15)
                {
                    a4_4.Visible = true;
                    x4_4 += 3080 / 577;
                    a4_4.Location = new Point(239, x4_4);
                }
                watch4_3 = Stopwatch.StartNew();
                if (hit4 == 4)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);

                    a4_3.Visible = false;
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);

                    a4_4.Visible = false;
                    x4_4 = -300;
                    a4_4.Location = new Point(239, x4_4);

                   
                }

                if(watch4_4.ElapsedMilliseconds > 15)
                {
                    a4_5.Visible = true;
                    x4_5 += 3080 / 577;
                    a4_5.Location = new Point(239, x4_5);
                }

                if(hit4 == 5)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);

                    a4_3.Visible = false;
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);

                    a4_4.Visible = false;
                    x4_4 = -300;
                    a4_4.Location = new Point(239, x4_4);

                    a4_5.Visible = false;
                    x4_5 = -400;
                    a4_5.Location = new Point(239, x4_5);

                    n4.Stop();
                }
            }
            


            if (a4_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x4_1 =  0;
                a4_1.Visible = false;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_1);
                miss += 1;
                hit4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n4.Stop();
            }
            if (a4_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x4_2 = -100;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_2);
                miss += 1;
                hit4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n4.Stop();

            }
            if (a4_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x4_3 = -200;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_3);
                miss += 1;
                hit4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n4.Stop();

            }
            if (a4_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x4_4 = -300;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_4);
                miss += 1;
                hit4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n4.Stop();
               
            }
            if (a4_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x4_5 = -400;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_5);
                miss += 1;
                hit4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                ones = 1;
                delaytim.Start();
                //n4.Stop();

            }
        }

        private void n5_Tick(object sender, EventArgs e)
        {
            a1_1.Visible = true;
            x1_1 += 1200 / 100;
            a1_1.Location = new Point(12, x1_1);

            if (a1_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_1 =  -5;
                n1.Stop();

            }
        }

        private void n6_Tick(object sender, EventArgs e)
        {
            a1_1.Visible = true;
            x1_1 += 1200 / 100;
            a1_1.Location = new Point(12, x1_1);

            if (a1_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_1 =  -5;
                n1.Stop();

            }
        }

        private void n7_Tick(object sender, EventArgs e)
        {
            a1_1.Visible = true;
            x1_1 += 1200 / 100;
            a1_1.Location = new Point(12, x1_1);

            if (a1_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_1 =  -5;
                n1.Stop();

            }
        }

        private void n8_Tick(object sender, EventArgs e)
        {
            a1_1.Visible = true;
            x1_1 += 1200 / 100;
            a1_1.Location = new Point(12, x1_1);

            if (a1_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_1 =  -5;
                n1.Stop();

            }
        }

        private void buttonscont(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 'z')
            {
                buttonactive1();
                a1.BackgroundImage = drumtuto_main.Properties.Resources.b1activated;
                b1.Visible = true;
            }
            if (e.KeyChar == 'x')
            {
                buttonactive2();
                a2.BackgroundImage = drumtuto_main.Properties.Resources.b2activated;
                b2.Visible = true;
                //snare.Play();
            }
            if (e.KeyChar == 'c')
            {
                buttonactive3();
                a3.BackgroundImage = drumtuto_main.Properties.Resources.b3activated;
                b3.Visible = true;
            }
            if (e.KeyChar == 'v')
            {
                buttonactive4();
                a4.BackgroundImage = drumtuto_main.Properties.Resources.b4activated;
                b4.Visible = true;
              
            }
             if (e.KeyChar == 'v' && stats1.Visible==true)
            {
                buttonactive4();
                a4.BackgroundImage = drumtuto_main.Properties.Resources.b4activated;
                b4.Visible = true;
                //p1.Close();
                this.Close();
                menu b = new menu();
                b.Show();
            }
        }

        private void buttonsrel(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                a1.BackgroundImage = drumtuto_main.Properties.Resources.b1inactives;
                b1.Visible = false;
            }
            if (e.KeyCode == Keys.X)
            {
                a2.BackgroundImage = drumtuto_main.Properties.Resources.b2inactives;
                b2.Visible = false;
                
            }
            if (e.KeyCode == Keys.C)
            {
                a3.BackgroundImage = drumtuto_main.Properties.Resources.b3inactives;
                b3.Visible = false;
            }
            if (e.KeyCode == Keys.V)
            {
                a4.BackgroundImage = drumtuto_main.Properties.Resources.b4inactives;
                b4.Visible = false;
            }
        }

        private void delaytim_Tick(object sender, EventArgs e)
        {
            ones--;
            indi1.SendToBack();
            if(ones==0 || ones <=0)
            {
                indi1.Visible = false;
                delaytim.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ones--;
            sticks.Play();
            indi1.Text = ones.ToString();
            indi1.Location = new Point(251, 280);
            indi1.Visible = true;
            indi1.BringToFront();

            if(ones >= 4)
            {
                durations.Stop();
            }
            if(ones == 0)
            {   
                durations.Start();
                sticks.Stop();
                indi1.Location = new Point(145, 283);
                indi1.Visible = false;
                timer1.Stop();
                textstuto();
            }
        }

    }
}

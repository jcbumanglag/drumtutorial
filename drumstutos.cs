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
// add indication (arduino)
// add the last basic beats
namespace drumtuto_main
{
    public partial class drumstutos : Form
    {
        #region variables
        SoundPlayer sticks;
        SoundPlayer snare;
        //initial position of each notes(hihat)
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


        //initial position of each notes(cymbal)
        int x3_1 = 0;
        int x3_2 = -100;
        int x3_3 = -200;
        int x3_4 = -300;
        int x3_5 = -400;

        // initial position of each notes(bass)
        int x4_1 = 0;
        int x4_2 = -100;
        int x4_3 = -200;
        int x4_4 = -300;
        int x4_5 = -400;

        int x5_1 = 0;
        int x5_2 = -100;
        int x5_3 = -200;
        int x5_4 = -300;
        int x5_5 = -400;

        int x6_1 = 0;
        int x6_2 = -100;
        int x6_3 = -200;
        int x6_4 = -300;
        int x6_5 = -400;

        int x7_1 = 0;
        int x7_2 = -100;
        int x7_3 = -200;
        int x7_4 = -300;
        int x7_5 = -400;

        int x8_1 = 0;
        int x8_2 = -100;
        int x8_3 = -200;
        int x8_4 = -300;
        int x8_5 = -400;

        int onestimercounter = 4;
        int pausetimecounter = 4;
        int restarttimercounter = 4;
       
        //total of all hit notes
        public static int scorecounter = 0;
        int maxscoreperhit = 0;
        
        public static int perfectcounter = 0;
        public static int goodcounter = 0;
        public static int misscounter = 0;
        public static int greatcounter = 0;

        int beatcounter1 = 0;
        int beatcounter2 = 0;
        int beatcounter3 = 0;
        int beatcounter4 = 0;
        int beatcounter5 = 0;
        int beatcounter6 = 0;
        int beatcounter7 = 0;
        int beatcounter8 = 0;

        int hitcounter1 = 0;
        int hitcounter2 = 0;
        int hitcounter3 = 0;
        int hitcounter4 = 0;
        int hitcounter5 = 0;
        int hitcounter6 = 0;
        int hitcounter7 = 0;
        int hitcounter8 = 0;

        //pattern and sequence counter
        int patterncounter = 1;
        int sequencecounter = 1;
        
        // only used in 4 beats
        bool sequenceloopflag = false; 
        
        //flags for the menu
        public static bool rockflag = false;
        public static bool classicflag = false;
        public static bool jazzflag = false;
        public static bool basicbeats1flag = false;
        public static bool basicbeats2flag = false;
        public static bool basicbeats3flag = false;

        //flag for the settings
        public static bool mode = false;
        public static bool indicatorled = false;

        bool pausedelay = true; // do not change this is uninterruptable
        bool pausemenuflag = false;
        bool restartflag = false;
        bool unpause = false;
        bool textdelay = false;
        bool gameoverflag = false;
        int maxenergy = 50;
        int energyvaluechecker = 0;
        int hitdecreasecounter = 0; //this will decrease Energy
        int hitincreasecounter = 0; // this will increase Energy
        int mainchoicemenucounter = 1;
        int subchoicemenucounter = 0;
        int enterswitchcounter = 0;
        bool assessmentrestartflag = false;

        //assessment form
        public static bool failedflag = false;
        public static int combocounter = 0;
        public static int energymultipliercounter = 0;


        
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
        
        //beats for snare
        public Stopwatch watch2_1 { get; set; }
        public Stopwatch watch2_2 { get; set; }
        public Stopwatch watch2_3 { get; set; }
        public Stopwatch watch2_4 { get; set; }
        public Stopwatch watch2_5 { get; set; }
        public Stopwatch watch2_6 { get; set; }
        public Stopwatch watch2_7 { get; set; }
        public Stopwatch watch2_8 { get; set; }

        //beats for cymbals
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

        public Stopwatch watch5_1 { get; set; }
        public Stopwatch watch5_2 { get; set; }
        public Stopwatch watch5_3 { get; set; }
        public Stopwatch watch5_4 { get; set; }
        public Stopwatch watch5_5 { get; set; }
        public Stopwatch watch5_6 { get; set; }
        public Stopwatch watch5_7 { get; set; }
        public Stopwatch watch5_8 { get; set; }

        public Stopwatch watch6_1 { get; set; }
        public Stopwatch watch6_2 { get; set; }
        public Stopwatch watch6_3 { get; set; }
        public Stopwatch watch6_4 { get; set; }
        public Stopwatch watch6_5 { get; set; }
        public Stopwatch watch6_6 { get; set; }
        public Stopwatch watch6_7 { get; set; }
        public Stopwatch watch6_8 { get; set; }

        public Stopwatch watch7_1 { get; set; }
        public Stopwatch watch7_2 { get; set; }
        public Stopwatch watch7_3 { get; set; }
        public Stopwatch watch7_4 { get; set; }
        public Stopwatch watch7_5 { get; set; }
        public Stopwatch watch7_6 { get; set; }
        public Stopwatch watch7_7 { get; set; }
        public Stopwatch watch7_8 { get; set; }

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

        public void Tutorials()
        {
            // basicbeats2 and 3 needs to be edited

            #region basicbeats
            if (basicbeats1flag == true)
          {
           
          if(patterncounter <=9)
          {
             
              if(sequencecounter == 1)// CB-H-HS-H-HB-H
              { 
                    
                     beatcounter1 = 5;
                     beatcounter2 = 1;
                     beatcounter3 = 1;
                     beatcounter4 = 2;
                      x4_1 = x3_1 + 35; //CB
                      x2_1 = x1_2 + 35; // HS
                      x4_2 = x1_4 + 35; // HB
                    
                    
                      n3.Start();
                      n4.Start();
                      onestimercounter = 1;
                      textdelay = true;
                      maintimer.Start();

                      #region CB(bugfix)
                      if (x4_1 == x3_1  + 35 && hitcounter4 == 0 && hitcounter3 == 1) //CB-H-HS-H-HB-H //x4_1 = x3_1;
                      {
                          hitcounter4 = 1;
                          hitcounter3 = 1;
                          x4_1 = 0;
                          x3_1 = 0;
                          a4_1.Visible = false;
                          a3_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();

                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                      #region HS(bugfix)
                      if (x2_1 == x1_2 + 35 && hitcounter2 == 0 && hitcounter1 == 2) //CB-H-HS-H-HB-H //x2_1 = x1_2;
                      {
                          hitcounter2 = 1;
                          hitcounter1 = 2;
                          x2_1 = 0;
                          x1_2 = -100;
                          a1_2.Visible = false;
                          a2_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss2");
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
                          maintimer.Start();

                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }

                      }
                      #endregion

                      #region HB(bugfix)
                      if (x4_2 == x1_4 + 35 && hitcounter4 == 1 && hitcounter1 == 4) //CB-H-HS-H-HB-H //x4_2 = x1_4;
                      {
                          hitcounter4 = 2;
                          hitcounter1 = 4;
                          x1_4 = -400;
                          x4_2 = -100;
                          a4_2.Visible = false;
                          a1_4.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion


                if (sequencecounter == 1 && hitcounter1 == 5 && hitcounter2 == 1 && hitcounter3 == 1 & hitcounter4==2)
                {
                    hitcounter1 = 0;
                    hitcounter2 = 0;
                    hitcounter3 = 0;
                    hitcounter4 = 0;
                    n1.Stop();
                    n2.Stop();
                    n3.Stop();
                    n4.Stop();
                    sequencecounter++;
                }

               
              
              }
              
              if(sequencecounter == 2) //HS-H
              {
                  beatcounter1 = 2;
                  beatcounter2 = 1;
                  n1.Start();
                  n2.Start();
                  x2_1 = x1_1 + 35;

                  #region HS(bugfix)
                  if (x2_1 == x1_1 + 35 && hitcounter2 == 0 && hitcounter1 == 1) //HS-H //x2_1 = x1_1;
                  {
                      hitcounter1 = 1;
                      hitcounter2 = 1;
                      x2_1 = 0;
                      x1_1 = 0;
                      a2_1.Visible = false;
                      a1_1.Visible = false;
                      misscounter += 1;
                      indi1.Visible = true;
                      indi1.Text = "Miss";
                      onestimercounter = 2;
                      combocounter = 0;
                      textdelay = true;
                      if (indicatorled == true)
                      {
                          try
                          {
                              port1.Open();
                              port1.Write("miss2");
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
                      maintimer.Start();
                      energyvaluechecker = energybar1.Value - hitdecreasecounter;
                      if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                      {
                          energybar1.Value -= hitdecreasecounter;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }

                      if (energyvaluechecker < 0 && energymultipliercounter == 0)
                      {
                          energybar1.Value = 0;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }
                      if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                      {
                          energymultipliercounter--;
                          energymulti1.Text = "x" + energymultipliercounter;
                          if (energymultipliercounter < 0)
                          {
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                      }
                  }
                  #endregion

                  if ( sequencecounter == 2 && hitcounter1 == 2 && hitcounter2 == 1) //add misscounter
                  {
                      hitcounter1 = 0;
                      hitcounter2 = 0;
                      n1.Stop();
                      n2.Stop();
                      sequenceloopflag = true;
                      sequencecounter++;

                  }
              }
              if(sequenceloopflag == true)
              {
              if (sequencecounter == 3 || sequencecounter == 5 || sequencecounter == 7) // HB-H-HS-H-HB
              {
                  beatcounter1 = 5;
                  beatcounter2 = 1;
                  beatcounter4 = 2;

                  x4_1 = x1_1 + 35;
                  x2_1 = x1_3 + 35;
                  x4_2 = x1_5 + 35;
                  

                  n1.Start();
                  n2.Start();
                  n4.Start();

                  #region HB1(bugfix)
                  if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) // HB-H-HS-H-HB //x4_1 = x1_1;
                  {
                      hitcounter1 = 1;
                      hitcounter4 = 1;
                      x4_1 = 0;
                      x1_1 = 0;
                      a4_2.Visible = false;
                      a1_5.Visible = false;
                      misscounter += 1;
                      indi1.Visible = true;
                      indi1.Text = "Miss";
                      onestimercounter = 2;
                      combocounter = 0;
                      textdelay = true;
                      if (indicatorled == true)
                      {
                          try
                          {
                              port1.Open();
                              port1.Write("miss4");
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
                      maintimer.Start();
                      energyvaluechecker = energybar1.Value - hitdecreasecounter;
                      if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                      {
                          energybar1.Value -= hitdecreasecounter;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }

                      if (energyvaluechecker < 0 && energymultipliercounter == 0)
                      {
                          energybar1.Value = 0;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }
                      if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                      {
                          energymultipliercounter--;
                          energymulti1.Text = "x" + energymultipliercounter;
                          if (energymultipliercounter < 0)
                          {
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                      }
                  }
                  #endregion

                  #region HS(bugfix)
                  if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) // HB-H-HS-H-HB //x2_1 = x1_3;
                  {
                      hitcounter1 = 3;
                      hitcounter2 = 1;
                      x2_1 = 0;
                      x1_3 = -200;
                      a2_1.Visible = false;
                      a1_3.Visible = false;
                      misscounter += 1;
                      indi1.Visible = true;
                      indi1.Text = "Miss";
                      onestimercounter = 2;
                      combocounter = 0;
                      textdelay = true;
                      if (indicatorled == true)
                      {
                          try
                          {
                              port1.Open();
                              port1.Write("miss2");
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
                      maintimer.Start();
                      energyvaluechecker = energybar1.Value - hitdecreasecounter;
                      if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                      {
                          energybar1.Value -= hitdecreasecounter;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }

                      if (energyvaluechecker < 0 && energymultipliercounter == 0)
                      {
                          energybar1.Value = 0;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }
                      if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                      {
                          energymultipliercounter--;
                          energymulti1.Text = "x" + energymultipliercounter;
                          if (energymultipliercounter < 0)
                          {
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                      }
                  }
                  #endregion

                  #region HB2(bugfix)
                  if (x4_2 == x1_5 + 35 && hitcounter4 == 1 && hitcounter1 == 5) // HB-H-HS-H-H //  x4_2 = x1_5;
                  {   
                      hitcounter1 = 5;
                      hitcounter4 = 2;
                      x4_2 = -100;
                      x1_5 = -400;
                      a4_2.Visible = false;
                      a1_5.Visible = false;
                      misscounter += 1;
                      indi1.Visible = true;
                      indi1.Text = "Miss";
                      onestimercounter = 2;
                      combocounter = 0;
                      textdelay = true;
                      if (indicatorled == true)
                      {
                          try
                          {
                              port1.Open();
                              port1.Write("miss4");
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
                      maintimer.Start();
                      energyvaluechecker = energybar1.Value - hitdecreasecounter;
                      if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                      {
                          energybar1.Value -= hitdecreasecounter;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }

                      if (energyvaluechecker < 0 && energymultipliercounter == 0)
                      {
                          energybar1.Value = 0;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }
                      if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                      {
                          energymultipliercounter--;
                          energymulti1.Text = "x" + energymultipliercounter;
                          if (energymultipliercounter < 0)
                          {
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                      }
                  }
                  //end
                  #endregion

              }
              if (sequencecounter == 3 && hitcounter1 == 5 && hitcounter2 == 1 && hitcounter4 == 2 || sequencecounter == 5 && hitcounter1 == 5 && hitcounter2 == 1 && hitcounter4 == 2 || sequencecounter == 7 && hitcounter1 == 5 && hitcounter2 == 1 && hitcounter4 == 2)
              {
                 hitcounter1 = 0;
                 hitcounter2 = 0;
                 hitcounter4 = 0;

                 n1.Stop();
                 n2.Stop();
                 n4.Stop();
                 sequencecounter++;
              }
              if (sequencecounter == 4 || sequencecounter == 6 || sequencecounter == 8)//H-HS-H
              {
                  beatcounter1 = 3;
                  beatcounter2 = 1;

                  x2_1 = x1_2 + 35;
                  n1.Start();
                  n2.Start();

                  #region HS(bugfix)
                  if (x2_1 == x1_2 + 35 && hitcounter2 == 0 && hitcounter1 == 2) //H-HS-H  x2_1 = x1_2;
                  {
                      hitcounter1 = 2;
                      hitcounter2 = 1;
                      x2_1 = 0;
                      x1_2 = -100;
                      a2_1.Visible = false;
                      a1_2.Visible = false;
                      misscounter += 1;
                      indi1.Visible = true;
                      indi1.Text = "Miss";
                      onestimercounter = 2;
                      combocounter = 0;
                      textdelay = true;
                      if (indicatorled == true)
                      {
                          try
                          {
                              port1.Open();
                              port1.Write("miss2");
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
                      maintimer.Start();
                      energyvaluechecker = energybar1.Value - hitdecreasecounter;
                      if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                      {
                          energybar1.Value -= hitdecreasecounter;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }

                      if (energyvaluechecker < 0 && energymultipliercounter == 0)
                      {
                          energybar1.Value = 0;
                          energymultipliercounter = 0;
                          energymulti1.Text = "x" + energymultipliercounter;
                      }
                      if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                      {
                          energymultipliercounter--;
                          energymulti1.Text = "x" + energymultipliercounter;
                          if (energymultipliercounter < 0)
                          {
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                      }
                  }
                  #endregion
              }

             
              if (sequencecounter == 4 && hitcounter1 == 3 && hitcounter2 == 1 || sequencecounter == 6 && hitcounter1 == 3 && hitcounter2 == 1 || sequencecounter == 8 && hitcounter1 == 3 && hitcounter2 == 1)
              {
                  hitcounter1 = 0;
                  hitcounter2 = 0;
                  n1.Stop();
                  n2.Stop();
                  sequencecounter++;
              }
                  if(sequencecounter > 8)
                  {
                  sequenceloopflag = false;
                  sequencecounter = 1;
                  indi1.Visible = false;
                  patterncounter++;
                  }
              }
             

          }
              if(patterncounter > 9)
              {
                  n1.Stop();
                  n2.Stop();
                  n3.Stop();
                  n4.Stop();
              }
          }
            #endregion //edit 

            #region basicbeats2
            if(basicbeats2flag == true)
            {
                if(patterncounter <= 9)
                {
                if(sequencecounter == 1)
                {
                    beatcounter1 = 5;
                    beatcounter2 = 5;
                    n1.Start();
                    onestimercounter = 1;
                    textdelay = true;
                    maintimer.Start();
                if(sequencecounter == 1 && hitcounter1 == 5 && hitcounter2 == 5)
                {
                        hitcounter1 = 0;
                        hitcounter2 = 0;
                        n1.Stop();
                        n2.Stop();
                        sequencecounter++;
                }

                }
                
                if (sequencecounter == 2)
                {
                    beatcounter1 = 5;
                    beatcounter2 = 5;
                    n1.Start();
                    onestimercounter = 1;
                    textdelay = true;
                    maintimer.Start();
                 if (sequencecounter == 2 && hitcounter1 == 5 && hitcounter2 == 5)
                {
                    hitcounter1 = 0;
                    hitcounter2 = 0;
                    n1.Stop();
                    n2.Stop();
                    sequencecounter++;
                }

                }
              
                if (sequencecounter == 3)
                {
                    beatcounter1 = 5;
                    n1.Start(); 
                if (sequencecounter == 3 && hitcounter1 == 5)
                {
                    hitcounter1 = 0;

                    n1.Stop();
                    n2.Stop();
                    sequencecounter = 1;
                    patterncounter++;
                    indi1.Visible = false;
                }
                }
               
             
             
                if (patterncounter > 9)
                {
                    n1.Stop();
                    n2.Stop();

                }
                }
            }
            #endregion

            #region basicbeats3
            if(basicbeats3flag == true)
            {
            if(patterncounter <= 9)
            {
            if (sequencecounter == 1)
            {
                x2_1 = x1_1 + 35;

                beatcounter1 = 1;
                beatcounter2 = 1;
               
                n1.Start();
                n2.Start();
           
            if(sequencecounter == 1 && hitcounter1 == 1 && hitcounter2 == 1)
            {
                    hitcounter2 = 0;
                    hitcounter1 = 0;
                    n1.Stop();
                    n2.Stop();
                    sequencecounter =1;
            }
            }
            }
            }
            #endregion

            #region rock
            if (rockflag == true)
            {
                if (patterncounter <= 12)
                {
                    if (sequencecounter == 1) //HB-H-HS-H
                    {
                        beatcounter1 = 4;
                        beatcounter2 = 1;
                        beatcounter4 = 1;
                        x4_1 = x1_1 + 35;
                        x2_1 = x1_3 + 35;
                        n1.Start();
                        n2.Start();
                        n4.Start();

                        #region HB(bugfix)
                        if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                        {
                            hitcounter4 = 1;
                            hitcounter1 = 1;
                            x4_1 = 0;
                            x1_1 = 0;
                            a4_1.Visible = false;
                            a1_1.Visible = false;
                            misscounter += 1;
                            indi1.Visible = true;
                            indi1.Text = "Miss";
                            onestimercounter = 2;
                            combocounter = 0;
                            textdelay = true;
                            if (indicatorled == true)
                            {
                                try
                                {
                                    port1.Open();
                                    port1.Write("miss4");
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
                            maintimer.Start();
                            energyvaluechecker = energybar1.Value - hitdecreasecounter;
                            if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                            {
                                energybar1.Value -= hitdecreasecounter;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }

                            if (energyvaluechecker < 0 && energymultipliercounter == 0)
                            {
                                energybar1.Value = 0;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }
                            if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                            {
                                energymultipliercounter--;
                                energymulti1.Text = "x" + energymultipliercounter;
                                if (energymultipliercounter < 0)
                                {
                                    energymultipliercounter = 0;
                                    energymulti1.Text = "x" + energymultipliercounter;
                                }
                            }
                        }
                        #endregion

                        #region HS(bugfix)
                        if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H //x2_1 = x1_3;
                        {
                            hitcounter2 = 1;
                            hitcounter1 = 3;
                            x2_1 = 0;
                            x1_3 = -200;
                            a2_1.Visible = false;
                            a1_3.Visible = false;
                            misscounter += 1;
                            indi1.Visible = true;
                            indi1.Text = "Miss";
                            onestimercounter = 2;
                            combocounter = 0;
                            textdelay = true;
                            if (indicatorled == true)
                            {
                                try
                                {
                                    port1.Open();
                                    port1.Write("miss2");
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
                            maintimer.Start();
                            energyvaluechecker = energybar1.Value - hitdecreasecounter;
                            if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                            {
                                energybar1.Value -= hitdecreasecounter;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }

                            if (energyvaluechecker < 0 && energymultipliercounter == 0)
                            {
                                energybar1.Value = 0;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }
                            if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                            {
                                energymultipliercounter--;
                                energymulti1.Text = "x" + energymultipliercounter;
                                if (energymultipliercounter < 0)
                                {
                                    energymultipliercounter = 0;
                                    energymulti1.Text = "x" + energymultipliercounter;
                                }
                            }
                        }
                        #endregion
                    }
                    if (sequencecounter == 1 && hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 1)
                    {
                        hitcounter1 = 0;
                        hitcounter2 = 0;
                        hitcounter4 = 0;
                        n1.Stop();
                        n2.Stop();
                        n4.Stop();
                        sequencecounter++;
                    }
                    if(sequencecounter == 2) //HB-HB-HS-H
                    {
                        beatcounter1 = 4;
                        beatcounter2 = 1;
                        beatcounter4 = 2;

                        x4_1 = x1_1 + 35;
                        x4_2 = x1_2 + 35;
                        x2_1 = x1_3 + 35;

                        n1.Start();
                        n2.Start();
                        n4.Start();

                        #region HB1(bugfix)
                        if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                        {
                            hitcounter4 = 1;
                            hitcounter1 = 1;
                            x4_1 = 0;
                            x1_1 = 0;
                            a4_1.Visible = false;
                            a1_1.Visible = false;
                            misscounter += 1;
                            indi1.Visible = true;
                            indi1.Text = "Miss";
                            onestimercounter = 2;
                            combocounter = 0;
                            textdelay = true;
                            if (indicatorled == true)
                            {
                                try
                                {
                                    port1.Open();
                                    port1.Write("miss4");
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
                            maintimer.Start();
                            energyvaluechecker = energybar1.Value - hitdecreasecounter;
                            if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                            {
                                energybar1.Value -= hitdecreasecounter;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }

                            if (energyvaluechecker < 0 && energymultipliercounter == 0)
                            {
                                energybar1.Value = 0;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }
                            if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                            {
                                energymultipliercounter--;
                                energymulti1.Text = "x" + energymultipliercounter;
                                if (energymultipliercounter < 0)
                                {
                                    energymultipliercounter = 0;
                                    energymulti1.Text = "x" + energymultipliercounter;
                                }
                            }
                        }
                        #endregion

                        #region HB2(bugfix)
                        if (x4_2 == x1_2 + 35 && hitcounter4 == 1 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                        {
                            hitcounter4 = 2;
                            hitcounter1 = 2;
                            x4_2 = -100;
                            x1_2 = -100;
                            a4_2.Visible = false;
                            a1_2.Visible = false;
                            misscounter += 1;
                            indi1.Visible = true;
                            indi1.Text = "Miss";
                            onestimercounter = 2;
                            combocounter = 0;
                            textdelay = true;
                            if (indicatorled == true)
                            {
                                try
                                {
                                    port1.Open();
                                    port1.Write("miss4");
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
                            maintimer.Start();
                            energyvaluechecker = energybar1.Value - hitdecreasecounter;
                            if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                            {
                                energybar1.Value -= hitdecreasecounter;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }

                            if (energyvaluechecker < 0 && energymultipliercounter == 0)
                            {
                                energybar1.Value = 0;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }
                            if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                            {
                                energymultipliercounter--;
                                energymulti1.Text = "x" + energymultipliercounter;
                                if (energymultipliercounter < 0)
                                {
                                    energymultipliercounter = 0;
                                    energymulti1.Text = "x" + energymultipliercounter;
                                }
                            }
                        }
                        #endregion

                        #region HS(bugfix)
                        if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H  //x2_1 = x1_3;
                        {
                            hitcounter2 = 1;
                            hitcounter1 = 3;
                            x2_1 = 0;
                            x1_3 = -200;
                            a1_3.Visible = false;
                            a2_1.Visible = false;
                            misscounter += 1;
                            indi1.Visible = true;
                            indi1.Text = "Miss";
                            onestimercounter = 2;
                            combocounter = 0;
                            textdelay = true;
                            if (indicatorled == true)
                            {
                                try
                                {
                                    port1.Open();
                                    port1.Write("miss2");
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
                            maintimer.Start();
                            energyvaluechecker = energybar1.Value - hitdecreasecounter;
                            if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                            {
                                energybar1.Value -= hitdecreasecounter;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }

                            if (energyvaluechecker < 0 && energymultipliercounter == 0)
                            {
                                energybar1.Value = 0;
                                energymultipliercounter = 0;
                                energymulti1.Text = "x" + energymultipliercounter;
                            }
                            if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                            {
                                energymultipliercounter--;
                                energymulti1.Text = "x" + energymultipliercounter;
                                if (energymultipliercounter < 0)
                                {
                                    energymultipliercounter = 0;
                                    energymulti1.Text = "x" + energymultipliercounter;
                                }
                            }
                        }
                        #endregion
                    }
                   if(sequencecounter == 2 && hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 ==2)
                   {
                       hitcounter1 = 0;
                       hitcounter2 = 0;
                       hitcounter4 = 0;
                       n1.Stop();
                       n2.Stop();
                       n4.Stop();
                       sequencecounter++;
                       
                   }
                   if (sequencecounter == 3) //HB-HB-HS-H
                   {   beatcounter1 = 4;
                       beatcounter2 = 1;
                       beatcounter4 = 2;

                       x4_1 = x1_1 + 35;
                       x4_2 = x1_2 + 35;
                       x2_1 = x1_3 + 35;

                       n1.Start();
                       n2.Start();
                       n4.Start();

                       #region HB1(bugfix)
                       if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                       {
                           hitcounter4 = 1;
                           hitcounter1 = 1;
                           x4_1 = 0;
                           x1_1 = 0;
                           a4_1.Visible = false;
                           a1_1.Visible = false;
                           misscounter += 1;
                           indi1.Visible = true;
                           indi1.Text = "Miss";
                           onestimercounter = 2;
                           combocounter = 0;
                           textdelay = true;
                           if (indicatorled == true)
                           {
                               try
                               {
                                   port1.Open();
                                   port1.Write("miss4");
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
                           maintimer.Start();
                           energyvaluechecker = energybar1.Value - hitdecreasecounter;
                           if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                           {
                               energybar1.Value -= hitdecreasecounter;
                               energymultipliercounter = 0;
                               energymulti1.Text = "x" + energymultipliercounter;
                           }

                           if (energyvaluechecker < 0 && energymultipliercounter == 0)
                           {
                               energybar1.Value = 0;
                               energymultipliercounter = 0;
                               energymulti1.Text = "x" + energymultipliercounter;
                           }
                           if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                           {
                               energymultipliercounter--;
                               energymulti1.Text = "x" + energymultipliercounter;
                               if (energymultipliercounter < 0)
                               {
                                   energymultipliercounter = 0;
                                   energymulti1.Text = "x" + energymultipliercounter;
                               }
                           }
                       }
                       #endregion

                       #region HB2(bugfix)
                       if (x4_2 == x1_2 + 35 && hitcounter4 == 1 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                       {
                           hitcounter4 = 2;
                           hitcounter1 = 2;
                           x4_2 = -100;
                           x1_2 = -100;
                           a4_2.Visible = false;
                           a1_2.Visible = false;
                           misscounter += 1;
                           indi1.Visible = true;
                           indi1.Text = "Miss";
                           onestimercounter = 2;
                           combocounter = 0;
                           textdelay = true;
                           if (indicatorled == true)
                           {
                               try
                               {
                                   port1.Open();
                                   port1.Write("miss4");
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
                           maintimer.Start();
                           energyvaluechecker = energybar1.Value - hitdecreasecounter;
                           if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                           {
                               energybar1.Value -= hitdecreasecounter;
                               energymultipliercounter = 0;
                               energymulti1.Text = "x" + energymultipliercounter;
                           }

                           if (energyvaluechecker < 0 && energymultipliercounter == 0)
                           {
                               energybar1.Value = 0;
                               energymultipliercounter = 0;
                               energymulti1.Text = "x" + energymultipliercounter;
                           }
                           if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                           {
                               energymultipliercounter--;
                               energymulti1.Text = "x" + energymultipliercounter;
                               if (energymultipliercounter < 0)
                               {
                                   energymultipliercounter = 0;
                                   energymulti1.Text = "x" + energymultipliercounter;
                               }
                           }
                       }
                       #endregion

                       #region HS(bugfix)
                       if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H  //x2_1 = x1_3;
                       {
                           hitcounter2 = 1;
                           hitcounter1 = 3;
                           x2_1 = 0;
                           x1_3 = -200;
                           a1_3.Visible = false;
                           a2_1.Visible = false;
                           misscounter += 1;
                           indi1.Visible = true;
                           indi1.Text = "Miss";
                           onestimercounter = 2;
                           combocounter = 0;
                           textdelay = true;
                           if (indicatorled == true)
                           {
                               try
                               {
                                   port1.Open();
                                   port1.Write("miss2");
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
                           maintimer.Start();
                           energyvaluechecker = energybar1.Value - hitdecreasecounter;
                           if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                           {
                               energybar1.Value -= hitdecreasecounter;
                               energymultipliercounter = 0;
                               energymulti1.Text = "x" + energymultipliercounter;
                           }

                           if (energyvaluechecker < 0 && energymultipliercounter == 0)
                           {
                               energybar1.Value = 0;
                               energymultipliercounter = 0;
                               energymulti1.Text = "x" + energymultipliercounter;
                           }
                           if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                           {
                               energymultipliercounter--;
                               energymulti1.Text = "x" + energymultipliercounter;
                               if (energymultipliercounter < 0)
                               {
                                   energymultipliercounter = 0;
                                   energymulti1.Text = "x" + energymultipliercounter;
                               }
                           }
                       }
                       #endregion
                   }
                   if(sequencecounter == 3 & hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 ==2)
                   {
                       hitcounter1 = 0;
                       hitcounter2 = 0;
                       hitcounter4 = 0;
                       n1.Stop();
                       n2.Stop();
                       n4.Stop();
                       sequencecounter++;
                   }
                   if (sequencecounter == 4) //HB-H-HS-H
                  {
                      beatcounter1 = 4;
                      beatcounter2 = 1;
                      beatcounter4 = 1;

                      x4_1 = x1_1 + 35;
                      x2_1 = x1_3 + 35;

                      n1.Start();
                      n2.Start();
                      n4.Start();

                      #region HB(bugfix)
                      if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                      {
                          hitcounter4 = 1;
                          hitcounter1 = 1;
                          x4_1 = 0;
                          x1_1 = 0;
                          a4_1.Visible = false;
                          a1_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                      #region HS(bugfix)
                      if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H //x2_1 = x1_3;
                      {
                          hitcounter2 = 1;
                          hitcounter1 = 3;
                          x2_1 = 0;
                          x1_3 = -200;
                          a2_1.Visible = false;
                          a1_3.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss2");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion
                  }
                  if (sequencecounter == 4 & hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 1)
                  {
                      hitcounter1 = 0;
                      hitcounter2 = 0;
                      hitcounter4 = 0;
                      n1.Stop();
                      n2.Stop();
                      n4.Stop();
                      sequencecounter++;
                  }
                  if (sequencecounter == 5) //HB-HB-HS-H
                  {
                      beatcounter1 = 4;
                      beatcounter2 = 1;
                      beatcounter4 = 2;

                      x4_1 = x1_1 + 35;
                      x4_2 = x1_2 + 35;
                      x2_1 = x1_3 + 35;
                      n1.Start();
                      n2.Start();
                      n4.Start();

                      #region HB1(bugfix)
                      if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                      {
                          hitcounter4 = 1;
                          hitcounter1 = 1;
                          x4_1 = 0;
                          x1_1 = 0;
                          a4_1.Visible = false;
                          a1_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                      #region HB2(bugfix)
                      if (x4_2 == x1_2 + 35 && hitcounter4 == 1 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                      {
                          hitcounter4 = 2;
                          hitcounter1 = 2;
                          x4_2 = -100;
                          x1_2 = -100;
                          a4_2.Visible = false;
                          a1_2.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                      #region HS(bugfix)
                      if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H  //x2_1 = x1_3;
                      {
                          hitcounter2 = 1;
                          hitcounter1 = 3;
                          x2_1 = 0;
                          x1_3 = -200;
                          a1_3.Visible = false;
                          a2_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss2");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                  }
                  if (sequencecounter == 5 & hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 2)
                  {
                      hitcounter1 = 0;
                      hitcounter2 = 0;
                      hitcounter4 = 0;
                      n1.Stop();
                      n2.Stop();
                      n4.Stop();
                      sequencecounter++;
                  }
                  if (sequencecounter == 6) //HB-HB-HS-H
                  {
                      beatcounter1 = 4;
                      beatcounter2 = 1;
                      beatcounter4 = 2;

                      x4_1 = x1_1 + 35;
                      x4_2 = x1_2 + 35;
                      x2_1 =x1_3  + 35;

                      n1.Start();
                      n2.Start();
                      n4.Start();

                      #region HB1(bugfix)
                      if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                      {
                          hitcounter4 = 1;
                          hitcounter1 = 1;
                          x4_1 = 0;
                          x1_1 = 0;
                          a4_1.Visible = false;
                          a1_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                      #region HB2(bugfix)
                      if (x4_2 == x1_2 + 35 && hitcounter4 == 1 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                      {
                          hitcounter4 = 2;
                          hitcounter1 = 2;
                          x4_2 = -100;
                          x1_2 = -100;
                          a4_2.Visible = false;
                          a1_2.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                      #region HS(bugfix)
                      if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H  //x2_1 = x1_3;
                      {
                          hitcounter2 = 1;
                          hitcounter1 = 3;
                          x2_1 = 0;
                          x1_3 = -200;
                          a1_3.Visible = false;
                          a2_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss2");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                  }
                  if (sequencecounter == 6 & hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 2)
                  {
                      hitcounter1 = 0;
                      hitcounter2 = 0;
                      hitcounter4 = 0;
                      n1.Stop();
                      n2.Stop();
                      n4.Stop();
                      sequencecounter++;
                  }
                  if (sequencecounter == 7) //HB-H-HS-HB
                  {
                      beatcounter1 = 4;
                      beatcounter2 = 1;
                      beatcounter4 = 2;

                      x4_1 = x1_1 + 35;
                      x4_2 = x1_4 + 35;
                      x2_1 = x1_3 + 35;

                      n1.Start();
                      n2.Start();
                      n4.Start();

                      #region HB1(bugfix)
                      if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                      {
                          hitcounter4 = 1;
                          hitcounter1 = 1;
                          x4_1 = 0;
                          x1_1 = 0;
                          a4_1.Visible = false;
                          a1_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion
                      
                      #region HS(bugfix)
                      if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H  //x2_1 = x1_3;
                      {
                          hitcounter2 = 1;
                          hitcounter1 = 3;
                          x2_1 = 0;
                          x1_3 = -200;
                          a1_3.Visible = false;
                          a2_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss2");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                      #region HB2(bugfix)
                      if (x4_2 == x1_4 + 35 && hitcounter4 == 1 && hitcounter1 == 4) //HB-H-HS-H //x4_1 = x1_1;
                      {
                          hitcounter4 = 2;
                          hitcounter1 = 2;
                          x4_2 = -100;
                          x1_4 = -300;
                          a4_2.Visible = false;
                          a1_4.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                      
                  }
                  if (sequencecounter == 7 & hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 2)
                  {
                      hitcounter1 = 0;
                      hitcounter2 = 0;
                      hitcounter4 = 0;
                      n1.Stop();
                      n2.Stop();
                      n4.Stop();
                      sequencecounter++;
                  }
                  if (sequencecounter == 8)
                  {
                      beatcounter1 = 4;
                      beatcounter2 = 1;
                      beatcounter4 = 1;

                      x4_1 = x1_1 + 35;
                      x2_1 = x1_3 + 35;

                      n1.Start();
                      n2.Start();
                      n4.Start();

                      #region HB(bugfix)
                      if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                      {
                          hitcounter4 = 1;
                          hitcounter1 = 1;
                          x4_1 = 0;
                          x1_1 = 0;
                          a4_1.Visible = false;
                          a1_1.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss4");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion

                      #region HS(bugfix)
                      if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H //x2_1 = x1_3;
                      {
                          hitcounter2 = 1;
                          hitcounter1 = 3;
                          x2_1 = 0;
                          x1_3 = -200;
                          a2_1.Visible = false;
                          a1_3.Visible = false;
                          misscounter += 1;
                          indi1.Visible = true;
                          indi1.Text = "Miss";
                          onestimercounter = 2;
                          combocounter = 0;
                          textdelay = true;
                          if (indicatorled == true)
                          {
                              try
                              {
                                  port1.Open();
                                  port1.Write("miss2");
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
                          maintimer.Start();
                          energyvaluechecker = energybar1.Value - hitdecreasecounter;
                          if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                          {
                              energybar1.Value -= hitdecreasecounter;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }

                          if (energyvaluechecker < 0 && energymultipliercounter == 0)
                          {
                              energybar1.Value = 0;
                              energymultipliercounter = 0;
                              energymulti1.Text = "x" + energymultipliercounter;
                          }
                          if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                          {
                              energymultipliercounter--;
                              energymulti1.Text = "x" + energymultipliercounter;
                              if (energymultipliercounter < 0)
                              {
                                  energymultipliercounter = 0;
                                  energymulti1.Text = "x" + energymultipliercounter;
                              }
                          }
                      }
                      #endregion
                  }
                  if (sequencecounter == 8 & hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 1)
                  {
                      hitcounter1 = 0;
                      hitcounter2 = 0;
                      hitcounter4 = 0;
                      n1.Stop();
                      n2.Stop();
                      n4.Stop();
                      patterncounter++;
                      indi1.Visible = false;
                      sequencecounter = 1;
                  }
                } 
                if(patterncounter > 12)
                {
                    n1.Stop();
                    n2.Stop();
                    n3.Stop();
                    n4.Stop();
                }
            }
            #endregion 

            #region classic 

            if(classicflag == true)
            {
            if(patterncounter <=9)
            {
            if(sequencecounter == 1) //HB-H-HS-H
            {
                beatcounter1 = 4;
                beatcounter2 = 1;
                beatcounter4 = 1;

                x4_1 = x1_1 + 35;
                x2_1 = x1_3 + 35;

                n1.Start();
                n2.Start();
                n4.Start();

                #region HB(bugfix)
                if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 1;
                    x4_1 = 0;
                    x1_1 = 0;
                    a4_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS(bugfix)
                if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H //x2_1 = x1_3;
                {
                    hitcounter2 = 1;
                    hitcounter1 = 3;
                    x2_1 = 0;
                    x1_3 = -200;
                    a2_1.Visible = false;
                    a1_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

            }
            if (sequencecounter == 1 && hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 1) 
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 2) //HB-HB-HS-H
            {
                beatcounter1 = 4;
                beatcounter2 = 1;
                beatcounter4 = 2;

                x4_1 = x1_1 + 35;
                x4_2 = x1_2 + 35;
                x2_1 = x1_3 + 35;

                n1.Start();
                n2.Start();
                n4.Start();
                #region HB1(bugfix)
                if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 1;
                    x4_1 = 0;
                    x1_1 = 0;
                    a4_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB2(bugfix)
                if (x4_2 == x1_2 + 35 && hitcounter4 == 1 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 2;
                    hitcounter1 = 2;
                    x4_2 = -100;
                    x1_2 = -100;
                    a4_2.Visible = false;
                    a1_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS(bugfix)
                if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H  //x2_1 = x1_3;
                {
                    hitcounter2 = 1;
                    hitcounter1 = 3;
                    x2_1 = 0;
                    x1_3 = -200;
                    a1_3.Visible = false;
                    a2_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 2 && hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 2)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if(sequencecounter ==3 ) //HB-H-HS-HB
            {
                beatcounter1 = 4;
                beatcounter2 = 1;
                beatcounter4 = 2;

                x4_1 = x1_1 + 35;
                x2_1 = x1_3 + 35;
                x4_2 = x1_4 + 35;
                
                n1.Start();
                n2.Start();
                n4.Start();

                #region HB1(bugfix)
                if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 1;
                    x4_1 = 0;
                    x1_1 = 0;
                    a4_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS(bugfix)
                if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H  //x2_1 = x1_3;
                {
                    hitcounter2 = 1;
                    hitcounter1 = 3;
                    x2_1 = 0;
                    x1_3 = -200;
                    a1_3.Visible = false;
                    a2_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB2(bugfix)
                if (x4_2 == x1_4 + 35 && hitcounter2 == 1 && hitcounter1 == 4) //HB-H-HS-H  //x2_1 = x1_3;
                {
                    hitcounter4 = 2;
                    hitcounter1 = 4;
                    x4_2 = -100;
                    x1_4 = -300;
                    a4_2.Visible = false;
                    a1_4.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 3 && hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 2)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 4) // HS-HB-HB-HS
            {
                beatcounter1 = 4;
                beatcounter2 = 2;
                beatcounter4 = 2;

                x2_1 = x1_1 + 35;
                x4_1 = x1_2 + 35;
                x4_2 = x1_3 + 35;
                x2_2 = x1_4 + 35;

                n1.Start();
                n2.Start();
                n4.Start();

                #region HS1(bugfix)
                if (x2_1 == x1_1 + 35 && hitcounter2 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter2 = 1;
                    hitcounter1 = 1;
                    x2_1 = 0;
                    x1_1 = 0;
                    a2_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB1(bugfix)
                if (x4_1 == x1_2 + 35 && hitcounter4 == 0 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 2;
                    x4_1 = 0;
                    x1_2 = -100;
                    a4_1.Visible = false;
                    a1_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB2(bugfix)
                if (x4_2 == x1_3 + 35 && hitcounter4 == 1 && hitcounter1 == 3) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 2;
                    hitcounter1 = 3;
                    x4_2 = -100;
                    x1_3 = -200;
                    a4_2.Visible = false;
                    a1_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS2(bugfix)
                if (x2_2 == x1_4 + 35 && hitcounter2 == 1 && hitcounter1 == 4) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter2 = 2;
                    hitcounter1 = 4;
                    x2_2 = -100;
                    x1_4 = -300;
                    a2_2.Visible = false;
                    a1_4.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

            }
            if (sequencecounter == 4 && hitcounter1 == 4 && hitcounter2 == 2 && hitcounter4 == 2)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if (sequencecounter == 5) // HB-H-HS-H
            {
                beatcounter1 = 4;
                beatcounter2 = 1;
                beatcounter4 = 1;

                x4_1 = x1_1 + 35;
                x2_1 = x1_3 + 35;

                n1.Start();
                n2.Start();
                n4.Start();

                #region HB(bugfix)
                if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 1;
                    x4_1 = 0;
                    x1_1 = 0;
                    a4_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS(bugfix)
                if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H //x2_1 = x1_3;
                {
                    hitcounter2 = 1;
                    hitcounter1 = 3;
                    x2_1 = 0;
                    x1_3 = -200;
                    a2_1.Visible = false;
                    a1_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

            }
            if (sequencecounter == 5 && hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 1)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 6) // HB-HS-HS-HB
            {
                beatcounter1 = 4;
                beatcounter2 = 2;
                beatcounter4 = 2;

                x4_1 = x1_1 + 35; 
                x2_1 = x1_2 + 35;
                x2_2 = x1_3 + 35;
                x4_2 = x1_4 + 35;
               
               

                n1.Start();
                n2.Start();
                n4.Start();

                #region HB(bugfix)
                if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 1;
                    x4_1 = 0;
                    x1_1 = 0;
                    a4_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS(bugfix)
                if (x2_1 == x1_2 + 35 && hitcounter2 == 0 && hitcounter1 == 2) //HB-H-HS-H //x2_1 = x1_3;
                {
                    hitcounter2 = 1;
                    hitcounter1 = 2;
                    x2_1 = 0;
                    x1_2 = -100;
                    a2_1.Visible = false;
                    a1_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS(bugfix)
                if (x2_2 == x1_3 + 35 && hitcounter2 == 1 && hitcounter1 == 3) //HB-H-HS-H //x2_1 = x1_3;
                {
                    hitcounter2 = 2;
                    hitcounter1 = 3;
                    x2_2 = -100;
                    x1_3 = -200;
                    a2_1.Visible = false;
                    a1_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB(bugfix)
                if (x4_2 == x1_4 + 35 && hitcounter4 == 1 && hitcounter1 == 4) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 2;
                    hitcounter1 = 4;
                    x4_2 = -100;
                    x1_4 = -200;
                    a1_4.Visible = false;
                    a4_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion


            }
            if (sequencecounter == 6 && hitcounter1 == 4 && hitcounter2 == 2 && hitcounter4 == 2)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if (sequencecounter == 7) //HB-H-HS-H
            {
                beatcounter1 = 4;
                beatcounter2 = 1;
                beatcounter4 = 1;

                x4_1 = x1_1 + 35;
                x2_1 = x1_3 + 35;

                n1.Start();
                n2.Start();
                n4.Start();

                #region HB(bugfix)
                if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 1;
                    x4_1 = 0;
                    x1_1 = 0;
                    a4_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS(bugfix)
                if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3) //HB-H-HS-H //x2_1 = x1_3;
                {
                    hitcounter2 = 1;
                    hitcounter1 = 3;
                    x2_1 = 0;
                    x1_3 = -200;
                    a2_1.Visible = false;
                    a1_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 7 && hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 1)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 8) //HB-HS-HS-HS
            {
                beatcounter1 = 4;
                beatcounter2 = 3;
                beatcounter4 = 1;

                x4_1 = x1_1 + 35;
                x2_1 = x1_2 + 35;
                x2_2 = x1_3 + 35;
                x2_3 = x1_4 + 35;

                n1.Start();
                n2.Start();
                n4.Start();

                #region HB(bugfix)
                if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 1;
                    x4_1 = 0;
                    x1_1 = 0;
                    a4_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS1(bugfix)
                if (x2_1 == x1_2 + 35 && hitcounter2 == 0 && hitcounter1 == 2) 
                {
                    hitcounter2 = 1;
                    hitcounter1 = 2;
                    x2_1 = 0;
                    x1_2 = -100;
                    a2_1.Visible = false;
                    a1_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS2(bugfix)
                if (x2_2 == x1_3 + 35 && hitcounter2 == 1 && hitcounter1 == 3) //HB-H-HS-H //x2_1 = x1_3;
                {
                    hitcounter2 = 2;
                    hitcounter1 = 3;
                    x2_2 = -100;
                    x1_3 = -200;
                    a2_1.Visible = false;
                    a1_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS3(bugfix)
                if (x2_3 == x1_4 + 35 && hitcounter2 == 2 && hitcounter1 == 4) //HB-H-HS-H //x2_1 = x1_3;
                {
                    hitcounter2 = 3;
                    hitcounter1 = 4;
                    x2_3 = -200;
                    x1_4 = -300;
                    a2_3.Visible = false;
                    a1_4.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 8 && hitcounter1 == 4 && hitcounter2 == 3 && hitcounter4 == 1)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 9)// HB-HB-HS-HB
            {
                beatcounter1 = 4;
                beatcounter2 = 1;
                beatcounter4 = 3;

                x4_1 = x1_1 + 35;
                x4_2 = x1_2 + 35;
                x2_1 = x1_3 + 35;
                x4_3 = x1_4 + 35;
               

                n1.Start();
                n2.Start();
                n4.Start();

                #region HB1(bugfix)
                if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 1;
                    x4_1 = 0;
                    x1_1 = 0;
                    a4_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB2(bugfix)
                if (x4_2 == x1_2 + 35 && hitcounter4 == 1 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 2;
                    hitcounter1 = 2;
                    x4_2 = -100;
                    x1_2 = -100;
                    a4_2.Visible = false;
                    a1_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS(bugfix)
                if (x2_1 == x1_3 + 35 && hitcounter2 == 0 && hitcounter1 == 3)
                {
                    hitcounter2 = 1;
                    hitcounter1 = 3;
                    x2_1 = 0;
                    x1_3 = -200;
                    a2_1.Visible = false;
                    a1_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB3(bugfix)
                if (x4_3 == x1_4 + 35 && hitcounter4 == 2 && hitcounter1 == 4) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 3;
                    hitcounter1 = 4;
                    x4_3 = -200;
                    x1_4 = -300;
                    a4_3.Visible = false;
                    a1_4.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion


            }
            if (sequencecounter == 9 && hitcounter1 == 4 && hitcounter2 == 1 && hitcounter4 == 3)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 10 ) //HB-HB-HB-HB
            {
                beatcounter1 = 4;
                beatcounter4 = 4;
                x4_1 = x1_1 + 35;
                x4_2 = x1_2 + 35;
                x4_3 = x1_3 + 35;
                x4_4 = x1_4 + 35;

                n1.Start();
                n4.Start();

                #region HB1(bugfix)
                if (x4_1 == x1_1 + 35 && hitcounter4 == 0 && hitcounter1 == 1) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 1;
                    x4_1 = 0;
                    x1_1 = 0;
                    a4_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB2(bugfix)
                if (x4_2 == x1_2 + 35 && hitcounter4 == 1 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 2;
                    hitcounter1 = 2;
                    x4_2 = -100;
                    x1_2 = -100;
                    a4_2.Visible = false;
                    a1_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB3(bugfix)
                if (x4_3 == x1_3 + 35 && hitcounter4 == 2 && hitcounter1 == 3) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 3;
                    hitcounter1 = 3;
                    x4_3 = -200;
                    x1_3 = -200;
                    a4_3.Visible = false;
                    a1_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB3(bugfix)
                if (x4_4 == x1_4 + 35 && hitcounter4 == 3 && hitcounter1 == 4) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 4;
                    hitcounter1 = 4;
                    x4_4 = -300;
                    x1_4 = -300;
                    a4_4.Visible = false;
                    a1_4.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 10 && hitcounter1 == 4 && hitcounter4 == 4)
            {
                hitcounter1 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 11) // HS-HB-HS-HB
            {
                beatcounter1 = 4;
                beatcounter2 = 2;
                beatcounter4 = 2;

                x2_1 = x1_1 + 35;
                x4_1 = x1_2 + 35;
                x2_2 = x1_3 + 35;
                x4_2 = x1_4 + 35;

                n1.Start();
                n2.Start();
                n4.Start();

                #region HS(bugfix)
                if (x2_1 == x1_1 + 35 && hitcounter2 == 0 && hitcounter1 == 1)
                {
                    hitcounter2 = 1;
                    hitcounter1 = 1;
                    x2_1 = 0;
                    x1_1 = 0;
                    a2_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB1(bugfix)
                if (x4_1 == x1_2 + 35 && hitcounter4 == 0 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 2;
                    x4_1 = 0;
                    x1_2 = -100;
                    a4_1.Visible = false;
                    a1_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS2(bugfix)
                if (x2_2 == x1_3 + 35 && hitcounter2 == 1 && hitcounter1 == 3)
                {
                    hitcounter2 = 2;
                    hitcounter1 = 3;
                    x2_2 = -100;
                    x1_3 = -200;
                    a2_2.Visible = false;
                    a1_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB2(bugfix)
                if (x4_2 == x1_4 + 35 && hitcounter4 == 1 && hitcounter1 == 4) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 2;
                    hitcounter1 = 4;
                    x4_2 = -100;
                    x1_4 = -300;
                    a4_2.Visible = false;
                    a1_4.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 11 && hitcounter1 == 4 && hitcounter2 == 2 && hitcounter4 == 2)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter++;
            }
            if (sequencecounter == 12)
            {
                beatcounter4 = 1;
                n4.Start();
            }
            if (sequencecounter == 12 && hitcounter4 == 1)
            {
                hitcounter4 = 0;
                n4.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 13)// HS-HB-HS-H
            {
                beatcounter1 = 4;
                beatcounter2 = 2;
                beatcounter4 = 1;

                x2_1 = x1_1 + 35;
                x2_2 = x1_3 + 35;
                x4_1 = x1_2 + 35;

                n1.Start();
                n2.Start();
                n4.Start();

                #region HS(bugfix)
                if (x2_1 == x1_1 + 35 && hitcounter2 == 0 && hitcounter1 == 1)
                {
                    hitcounter2 = 1;
                    hitcounter1 = 1;
                    x2_1 = 0;
                    x1_1 = 0;
                    a2_1.Visible = false;
                    a1_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HB(bugfix)
                if (x4_1 == x1_2 + 35 && hitcounter4 == 0 && hitcounter1 == 2) //HB-H-HS-H //x4_1 = x1_1;
                {
                    hitcounter4 = 1;
                    hitcounter1 = 2;
                    x4_1 = 0;
                    x1_2 = -100;
                    a4_1.Visible = false;
                    a1_2.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region HS2(bugfix)
                if (x2_2 == x1_3 + 35 && hitcounter2 == 1 && hitcounter1 == 3)
                {
                    hitcounter2 = 2;
                    hitcounter1 = 3;
                    x2_2 = -100;
                    x1_3 = -200;
                    a2_2.Visible = false;
                    a1_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 13 && hitcounter1 == 4 && hitcounter2 == 2 && hitcounter4 == 1)
            {
                hitcounter1 = 0;
                hitcounter2 = 0;
                hitcounter4 = 0;
                n1.Stop();
                n2.Stop();
                n4.Stop();
                sequencecounter=1;
                patterncounter++;
                indi1.Visible = false;
            }
            }
            if (patterncounter > 9)
            {
                n1.Stop();
                n2.Stop();
                n3.Stop();
                n4.Stop();
            }
            }
            #endregion

            #region jazz
            if(jazzflag == true)
            {
            if(patterncounter <=9 )
            {
            if(sequencecounter == 1) //BR-R-RS-R
            {   beatcounter2 = 1; 
                beatcounter4 = 1;
                beatcounter7 = 4;

                x4_1 = x7_1 + 35;
                x2_1 = x7_3 + 35;

                n2.Start();
                n4.Start();
                n7.Start();

                #region BR(bugfix)
                if (x4_1 == x7_1 + 35 && hitcounter4 == 0 && hitcounter7 == 1)
                {
                    hitcounter4 = 1;
                    hitcounter7 = 1;
                    x4_1 = 0;
                    x7_1 = 0;
                    a4_1.Visible = false;
                    a7_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region RS(bugfix)
                if (x2_1 == x7_3 + 35 && hitcounter2 == 0 && hitcounter7 == 3)
                {
                    hitcounter2 = 1;
                    hitcounter7 = 3;
                    x2_1 = 0;
                    x7_3 = -200;
                    a2_1.Visible = false;
                    a7_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

            }
            if(sequencecounter == 1 && hitcounter2 == 1 && hitcounter4 == 1 && hitcounter7 == 4)
            {
               
                hitcounter2 = 0;
                hitcounter4 = 0;
                hitcounter7 = 0;
                n2.Stop();
                n4.Stop();
                n7.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 2)//RS-R-RB
            {
                beatcounter7 = 3;
                beatcounter2 = 1;
                beatcounter4 = 1;
                
                x2_1 = x7_1 + 35;
                x4_1 = x7_3 + 35;
              
                n2.Start();
                n4.Start();
                n7.Start();

                #region RS(bugfix)
                if (x2_1 == x7_1 + 35 && hitcounter2 == 0 && hitcounter7 == 1)
                {
                    hitcounter2 = 1;
                    hitcounter7 = 1;
                    x2_1 = 0;
                    x7_1 = 0;
                    a2_1.Visible = false;
                    a7_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region RB(bugfix)
                if (x4_1 == x7_3 + 35 && hitcounter4 == 0 && hitcounter7 == 3)
                {
                    hitcounter4 = 1;
                    hitcounter7 = 3;
                    x4_1 = 0;
                    x7_3 = -200;
                    a4_1.Visible = false;
                    a7_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 2 && hitcounter2 == 1 && hitcounter4 == 1 && hitcounter7 == 3)
            {
                hitcounter2 = 0;
                hitcounter4 = 0;
                hitcounter7 = 0;

                n2.Stop();
                n4.Stop();
                n7.Stop();

                sequencecounter++;
            }
       
            if(sequencecounter == 3)
            {
                beatcounter2 = 3;
                n2.Start();
            }
            if(sequencecounter == 3 && hitcounter2 == 3)
            {
                hitcounter2 = 0;
                n2.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 4)
            {
                beatcounter6 = 2;
                n6.Start();
            }
            if (sequencecounter == 4 && hitcounter6 == 2)
            {
                hitcounter6 = 0;
                n6.Stop();
                sequencecounter++;
            }
            if (sequencecounter == 5)
            {
                beatcounter8 = 3;
                n8.Start();
            }
            if (sequencecounter == 5 && hitcounter8 == 3)
            {
                hitcounter8 = 0;
                n8.Stop();
                sequencecounter++;
            }

            if (sequencecounter == 6) // BR-R-RS-R
            {
                beatcounter2 = 1;
                beatcounter4 = 1;
                beatcounter7 = 4;

                x4_1 = x7_1 + 35;
                x2_1 = x7_3 + 35;

                n2.Start();
                n4.Start();
                n7.Start();

                #region BR(bugfix)
                if (x4_1 == x7_1 + 35 && hitcounter4 == 0 && hitcounter7 == 1)
                {
                    hitcounter4 = 1;
                    hitcounter7 = 1;
                    x4_1 = 0;
                    x7_1 = 0;
                    a4_1.Visible = false;
                    a7_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region RS(bugfix)
                if (x2_1 == x7_3 + 35 && hitcounter2 == 0 && hitcounter7 == 3)
                {
                    hitcounter2 = 1;
                    hitcounter7 = 3;
                    x2_1 = 0;
                    x7_3 = -200;
                    a2_1.Visible = false;
                    a7_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

            }
            if (sequencecounter == 6 && hitcounter2 == 1 && hitcounter4 == 1 && hitcounter7 == 4)
            {
                hitcounter2 = 0;
                hitcounter4 = 0;
                hitcounter7 = 0;

                n2.Stop();
                n4.Stop();
                n7.Stop();

                sequencecounter++;
            }
            if (sequencecounter == 7)// RS-R-RB
            {
                beatcounter7 = 3;
                beatcounter2 = 1;
                beatcounter4 = 1;

                x2_1 = x7_1 + 35;
                x4_1 = x7_3 + 35;

                n2.Start();
                n4.Start();
                n7.Start();

                #region RS(bugfix)
                if (x2_1 == x7_1 + 35 && hitcounter2 == 0 && hitcounter7 == 1)
                {
                    hitcounter2 = 1;
                    hitcounter7 = 1;
                    x2_1 = 0;
                    x7_1 = 0;
                    a2_1.Visible = false;
                    a7_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region RB(bugfix)
                if (x4_1 == x7_3 + 35 && hitcounter4 == 0 && hitcounter7 == 3)
                {
                    hitcounter4 = 1;
                    hitcounter7 = 3;
                    x4_1 = 0;
                    x7_3 = -200;
                    a4_1.Visible = false;
                    a7_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 7 && hitcounter2 == 1 && hitcounter4 == 1 && hitcounter7 == 3)
            {
                hitcounter2 = 0;
                hitcounter4 = 0;
                hitcounter7 = 0;

                n2.Stop();
                n4.Stop();
                n7.Stop();

                sequencecounter++;
            }
            if (sequencecounter == 8)
            {
                beatcounter2 = 4;
                n2.Start();
            }
            if (sequencecounter == 8 && hitcounter2 == 4)
            {
                hitcounter2 = 0;
                n2.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 9)
            {

                beatcounter4 = 1;
                n4.Start();

            }
            if(sequencecounter == 9 && hitcounter4 == 1)
            {
                hitcounter4 = 0;
                n4.Stop();
                sequencecounter++;
            }
            if (sequencecounter == 10)
            {
                beatcounter2 = 1;

                n2.Start();

            }
            if (sequencecounter == 10 && hitcounter2 == 1 )
            {
                hitcounter2 = 0;
                n2.Stop();
                sequencecounter++;
            }
            if (sequencecounter == 11)
            {

                beatcounter8 = 3;
                n8.Start();

            }
            if (sequencecounter == 11 && hitcounter8 == 3)
            {
                hitcounter8 = 0;
                n8.Stop();
                sequencecounter++;
            }
            if (sequencecounter == 12) //RB-R-RS-R
            {
                beatcounter2 = 1;
                beatcounter4 = 1;
                beatcounter7 = 4;

                x4_1 = x7_1 + 35;
                x2_1 = x7_3 + 35;

                n2.Start();
                n4.Start();
                n7.Start();

                #region RB(bugfix)
                if (x4_1 == x7_1 + 35 && hitcounter4 == 0 && hitcounter7 == 1)
                {
                    hitcounter4 = 1;
                    hitcounter7 = 1;
                    x4_1 = 0;
                    x7_1 = -200;
                    a4_1.Visible = false;
                    a7_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region RS(bugfix)
                if (x2_1 == x7_3 + 35 && hitcounter2 == 0 && hitcounter7 == 3)
                {
                    hitcounter2 = 1;
                    hitcounter7 = 3;
                    x2_1 = 0;
                    x7_3 = -200;
                    a2_1.Visible = false;
                    a7_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

             
            }
            if (sequencecounter == 12 && hitcounter2 == 1 && hitcounter4 == 1 && hitcounter7 == 4)
            {
                hitcounter2 = 0;
                hitcounter4 = 0;
                hitcounter7 = 0;

                n2.Stop();
                n4.Stop();
                n7.Stop();

                sequencecounter++;
            }
            if (sequencecounter == 13) //RS-R-RB-R
            {
                beatcounter7 = 4;
                beatcounter2 = 1;
                beatcounter4 = 1;

                x2_1 = x7_1 + 35;
                x4_1 = x7_3 + 35;

                n2.Start();
                n4.Start();
                n7.Start();

                #region RS(bugfix)
                if (x2_1 == x7_1 + 35 && hitcounter2 == 0 && hitcounter7 == 1)
                {
                    hitcounter2 = 1;
                    hitcounter7 = 1;
                    x2_1 = 0;
                    x7_1 = 0;
                    a2_1.Visible = false;
                    a7_1.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion

                #region RB(bugfix)
                if (x4_1 == x7_3 + 35 && hitcounter4 == 0 && hitcounter7 == 3)
                {
                    hitcounter4 = 1;
                    hitcounter7 = 3;
                    x4_1 = 0;
                    x7_3 = -200;
                    a4_1.Visible = false;
                    a7_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 13 && hitcounter2 == 1 && hitcounter4 == 1 && hitcounter7 == 4)
            {
                hitcounter2 = 0;
                hitcounter4 = 0;
                hitcounter7 = 0;

                n2.Stop();
                n4.Stop();
                n7.Stop();

                sequencecounter++;
            }
            if(sequencecounter == 14) //RB-R
            {
                beatcounter4 = 1;
                beatcounter7 = 2;

                x4_1 = x7_1  + 35;
                n4.Start();
                n7.Start();

                #region RB(bugfix)
                if (x4_1 == x7_1 + 35 && hitcounter4 == 0 && hitcounter7 == 1)
                {
                    hitcounter4 = 1;
                    hitcounter7 = 1;
                    x4_1 = 0;
                    x7_1 = 0;
                    a4_1.Visible = false;
                    a7_3.Visible = false;
                    misscounter += 1;
                    indi1.Visible = true;
                    indi1.Text = "Miss";
                    onestimercounter = 2;
                    combocounter = 0;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("miss4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value - hitdecreasecounter;
                    if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                    {
                        energybar1.Value -= hitdecreasecounter;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                    if (energyvaluechecker < 0 && energymultipliercounter == 0)
                    {
                        energybar1.Value = 0;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                    if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                    {
                        energymultipliercounter--;
                        energymulti1.Text = "x" + energymultipliercounter;
                        if (energymultipliercounter < 0)
                        {
                            energymultipliercounter = 0;
                            energymulti1.Text = "x" + energymultipliercounter;
                        }
                    }
                }
                #endregion
            }
            if (sequencecounter == 14 && hitcounter4 == 1 && hitcounter7 == 2)
            {
                hitcounter4 = 0;
                hitcounter7 = 0;

                n4.Stop();
                n7.Stop();

                sequencecounter++;
            }
            if(sequencecounter == 15)
            {
                beatcounter4 = 2;


                n4.Start();

            }
            if(sequencecounter == 15 && hitcounter4 == 2 )
            {
                hitcounter4 = 0;
                n4.Stop();
                sequencecounter++;
            }
            if (sequencecounter == 16)
            {

                beatcounter6 = 2;

                n6.Start();
            }
            if (sequencecounter == 16 && hitcounter6 == 2)
            {
                hitcounter6 = 0;
                n6.Stop();
                sequencecounter++;
            }
            if(sequencecounter == 17)
            {
                beatcounter8 = 2;
                n8.Start();
            }
            if(sequencecounter == 17 && hitcounter8 == 2)
            {
                hitcounter8 = 0;
                n8.Stop();
                sequencecounter = 1;
                patterncounter++;
                indi1.Visible = false;
            }
            }
            if (patterncounter > 9)
            {
                n2.Stop();
                n4.Stop();
                n6.Stop();
                n7.Stop();
            }
            }
            #endregion
        }

        public void starting_val() 
        {
            if (restartflag == true)
            {
                misscounter = 0;
                perfectcounter = 0;
                greatcounter = 0;
                goodcounter = 0;
                combocounter = 0;
                energymultipliercounter = 0;
                scorecounter = 0;
                patterncounter = 1;
                sequencecounter = 1;
                sequenceloopflag = false;
                energymultipliercounter = 0;
                energymulti1.Text = "x" + energymultipliercounter;
                restartflag = false;
                pausemenuflag = false;
                mainchoicemenucounter = 0;

            }
            else 
            {
                misscounter = 0;
                perfectcounter = 0;
                greatcounter = 0;
                goodcounter = 0;
                combocounter = 0;
                energymultipliercounter = 0;
                scorecounter = 0;
                patterncounter = 1;
                sequencecounter = 1;
                sequenceloopflag = false;
                energymultipliercounter = 0;
                energymulti1.Text = "x" + energymultipliercounter;
                restartflag = false;
            }
            if(mode == false)
            {
                pnlgreat.Location = new Point(3, 519);
            }
            else 
            {
             pnlgreat.Location = new Point(3, 540);
            }
        }

        public void starting_speeds()
        {
        
            
            if(basicbeats1flag ==true)
            {
            if (patterncounter >= 1)
            {
                maxscoreperhit = 3;
                currtempo.Text = "Slow";
                hitdecreasecounter = 5;
                hitincreasecounter = 3;
                n1.Interval = 50;
                n2.Interval = 50;
                n3.Interval = 50;
                n4.Interval = 50;
            }
            if (patterncounter >= 3)
            {
                maxscoreperhit = 5;
                currtempo.Text = "Medium";
                hitdecreasecounter = 10;
                hitincreasecounter = 4;
                n1.Interval = 25;
                n2.Interval = 25;
                n3.Interval = 25;
                n4.Interval = 25;
            }
            if (patterncounter >= 6)
            {
                maxscoreperhit = 7;
                currtempo.Text = "Fast";
                hitdecreasecounter = 15;
                hitincreasecounter = 5;
                n1.Interval = 18;
                n2.Interval = 18;
                n3.Interval = 18;
                n4.Interval = 18;
            }
            }
            if (basicbeats2flag == true)
            {
                if (patterncounter >= 1)
                {
                    maxscoreperhit = 3;
                    currtempo.Text = "Slow";
                    hitdecreasecounter = 5;
                    hitincreasecounter = 3;
                    n1.Interval = 50;
                    n2.Interval = 50;
                    n3.Interval = 50;
                    n4.Interval = 50;
                }
                if (patterncounter >= 3)
                {
                    maxscoreperhit = 5;
                    currtempo.Text = "Medium";
                    hitdecreasecounter = 10;
                    hitincreasecounter = 4;
                    n1.Interval = 25;
                    n2.Interval = 25;
                    n3.Interval = 25;
                    n4.Interval = 25;
                }
                if (patterncounter >= 6)
                {
                    maxscoreperhit = 7;
                    currtempo.Text = "Fast";
                    hitdecreasecounter = 15;
                    hitincreasecounter = 5;
                    n1.Interval = 18;
                    n2.Interval = 18;
                    n3.Interval = 18;
                    n4.Interval = 18;
                }
            }
            if(rockflag == true)
            {
             if(patterncounter >= 1  )
             {
                 maxscoreperhit = 3;
                 currtempo.Text = "Slow";
                 hitdecreasecounter = 5;
                 hitincreasecounter = 3;
                 n1.Interval = 50;
                 n2.Interval = 50;
                 n4.Interval = 50;
             }
             if (patterncounter >= 4)
             {
                 maxscoreperhit = 5;
                 currtempo.Text = "Medium";
                 hitdecreasecounter = 10;
                 hitincreasecounter = 4;
                 n1.Interval = 25;
                 n2.Interval = 25;
                 n4.Interval = 25;
             }
             if (patterncounter >= 8)
             {
                 maxscoreperhit = 7;
                 currtempo.Text = "Fast";
                 hitdecreasecounter = 15;
                 hitincreasecounter = 5;
                 n1.Interval = 18;
                 n2.Interval = 18;
                 n4.Interval = 18;
             }
            }

            if (classicflag == true)
            {
                if (patterncounter >= 1)
                {
                    maxscoreperhit = 3;
                    currtempo.Text = "Slow";
                    hitdecreasecounter = 5;
                    hitincreasecounter = 3;
                    n1.Interval = 50;
                    n2.Interval = 50;
                    n4.Interval = 50;
                }
                if (patterncounter >= 3)
                {
                    maxscoreperhit = 5;
                    currtempo.Text = "Medium";
                    hitdecreasecounter = 10;
                    hitincreasecounter = 4;
                    n1.Interval = 25;
                    n2.Interval = 25;
                    n4.Interval = 25;
                }
                if (patterncounter >= 6)
                {
                    maxscoreperhit = 7;
                    currtempo.Text = "Fast";
                    hitdecreasecounter = 15;
                    hitincreasecounter = 5;
                    n1.Interval = 18;
                    n2.Interval = 18;
                    n4.Interval = 18;
                }
            }
            if (jazzflag == true)
            {
                if (patterncounter >= 1)
                {
                    maxscoreperhit = 3;
                    currtempo.Text = "Slow";
                    hitdecreasecounter = 5;
                    hitincreasecounter = 3;
                    n1.Interval = 50;
                    n2.Interval = 50;
                    n4.Interval = 50;
                }
                if (patterncounter >= 3)
                {
                    maxscoreperhit = 5;
                    currtempo.Text = "Medium";
                    hitdecreasecounter = 10;
                    hitincreasecounter = 4;
                    n1.Interval = 25;
                    n2.Interval = 25;
                    n4.Interval = 25;
                }
                if (patterncounter >= 6)
                {
                    maxscoreperhit = 7;
                    currtempo.Text = "Fast";
                    hitdecreasecounter = 15;
                    hitincreasecounter = 5;
                    n1.Interval = 18;
                    n2.Interval = 18;
                    n4.Interval = 18;
                }
            }
        }

        public void pausemenuhighlight(int mainchoicecounter1) 
        {
            switch(mainchoicecounter1)
            {
                case 1:
                    {
                        lbl1.Visible = false;
                        btnno.Visible = false;
                        btnyes.Visible = false;
                        btnresume1.Visible = true;
                        btnrestart1.Visible = true;
                        btnquit1.Visible = true;
                        btnresume1.Size = new Size(280, 80);
                        btnrestart1.Size = new Size(235, 53);
                        btnquit1.Size = new Size(235, 53);
                        break;
                    }
                case 2:
                    {
                        lbl1.Visible = false;
                        btnno.Visible = false;
                        btnyes.Visible = false;
                        btnresume1.Visible = true;
                        btnrestart1.Visible = true;
                        btnquit1.Visible = true;
                        btnrestart1.Size = new Size(280, 80);
                        btnresume1.Size = new Size(235, 53);
                        btnquit1.Size = new Size(235, 53);

                        break;
                    }
                case 3:
                    {
                        lbl1.Visible = false;
                        btnno.Visible = false;
                        btnyes.Visible = false;
                        btnresume1.Visible = true;
                        btnrestart1.Visible = true;
                        btnquit1.Visible = true;
                        btnquit1.Size = new Size(280, 80);
                        btnresume1.Size = new Size(235, 53);
                        btnrestart1.Size = new Size(235, 53);
                        break;
                    }
            }
        
        }

        public void subpausemenuhighlight(int submainchoicecounter) 
        {
            switch (subchoicemenucounter)
            {
  
                case 1:
                    {
                        lbl1.Visible = true;
                        btnno.Visible = true;
                        btnyes.Visible = true;
                        btnno.Size = new Size(280, 80);
                        btnyes.Size = new Size(235, 53);
                        btnresume1.Visible = false;
                        btnrestart1.Visible = false;
                        btnquit1.Visible = false;
                        break;
                    }
                case 2:
                    {
                        lbl1.Visible = true;
                        btnno.Visible = true;
                        btnyes.Visible = true;
                        btnyes.Size = new Size(280, 80);
                        btnno.Size = new Size(235, 53);
                        btnresume1.Visible = false;
                        btnrestart1.Visible = false;
                        btnquit1.Visible = false;
                        break;
                    }
            }
        }

        #endregion
     
        #region controls

        public void buttonactive1() 
        {
            if (mode == true)
            {
                if (a1_1.Bounds.IntersectsWith(pnlgreat.Bounds) && a1_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;

                    x1_1 = 0;

                    a1_1.Location = new Point(12, x1_1);
                    hitcounter1 += 1;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    perfectcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    maintimer.Start();
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a1_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;

                    x1_1 = 0;

                    a1_1.Location = new Point(12, x1_1);
                    hitcounter1 += 1;
                    combocounter += 1;
                    greatcounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    maintimer.Start();
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }

                else if (a1_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }


                if (a1_2.Bounds.IntersectsWith(pnlgreat.Bounds) && a1_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_2.Visible = false;
                    indi1.Visible = true;

                    x1_2 = -100;

                    a1_2.Location = new Point(12, x1_2);
                    hitcounter1 += 1;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    perfectcounter += 1;
                    onestimercounter = 2;

                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a1_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_2.Visible = false;
                    indi1.Visible = true;

                    x1_2 = -100;

                    a1_2.Location = new Point(12, x1_2);
                    hitcounter1 += 1;
                    combocounter += 1;
                    greatcounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    perfectcounter += 1;
                    onestimercounter = 2;

                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();


                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }

                else if (a1_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_2.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }

                if (a1_3.Bounds.IntersectsWith(pnlgreat.Bounds) && a1_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;

                    x1_3 = -200;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_3.Location = new Point(12, x1_3);
                    hitcounter1 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }

                if (a1_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;

                    x1_3 = -200;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    a1_3.Location = new Point(12, x1_3);
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    hitcounter1 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a1_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_3.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }

                if (a1_4.Bounds.IntersectsWith(pnlgreat.Bounds) && a1_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_4.Visible = false;
                    indi1.Visible = true;

                    x1_4 = -300;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_4.Location = new Point(12, x1_4);
                    hitcounter1 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a1_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_4.Visible = false;
                    indi1.Visible = true;

                    x1_4 = -300;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_4.Location = new Point(12, x1_4);
                    hitcounter1 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a1_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_4.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    x1_4 = -300;
                    a1_4.Location = new Point(12, x1_4);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }

                if (a1_5.Bounds.IntersectsWith(pnlgreat.Bounds) && a1_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_5.Visible = false;
                    indi1.Visible = true;
                    x1_5 = -400;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_5.Location = new Point(12, x1_5);
                    hitcounter1 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a1_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_5.Visible = false;
                    indi1.Visible = true;
                    x1_5 = -400;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_5.Location = new Point(12, x1_5);
                    hitcounter1 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a1_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_5.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    x1_5 = -400;
                    a1_5.Location = new Point(12, x1_5);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }
            }
            //student
            else 
            {
                if ( a1_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;

                    x1_1 = 0;

                    a1_1.Location = new Point(12, x1_1);
                    hitcounter1 += 1;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    perfectcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a1_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;

                    x1_1 = 0;

                    a1_1.Location = new Point(12, x1_1);
                    hitcounter1 += 1;
                    combocounter += 1;
                    greatcounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();


                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }

                else if (a1_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }


                if ( a1_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_2.Visible = false;
                    indi1.Visible = true;

                    x1_2 = -100;

                    a1_2.Location = new Point(12, x1_2);
                    hitcounter1 += 1;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    perfectcounter += 1;
                    onestimercounter = 2;

                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a1_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_2.Visible = false;
                    indi1.Visible = true;

                    x1_2 = -100;

                    a1_2.Location = new Point(12, x1_2);
                    hitcounter1 += 1;
                    combocounter += 1;
                    greatcounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    perfectcounter += 1;
                    onestimercounter = 2;

                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();


                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }

                else if (a1_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_2.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x1_2 = -100;
                    a1_2.Location = new Point(12, x1_2);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }

                if (a1_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;

                    x1_3 = -200;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_3.Location = new Point(12, x1_3);
                    hitcounter1 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }

                if (a1_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_1.Visible = false;
                    indi1.Visible = true;

                    x1_3 = -200;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    a1_3.Location = new Point(12, x1_3);
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    hitcounter1 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a1_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_3.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    x1_3 = -200;
                    a1_3.Location = new Point(12, x1_3);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }

                if ( a1_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_4.Visible = false;
                    indi1.Visible = true;

                    x1_4 = -300;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_4.Location = new Point(12, x1_4);
                    hitcounter1 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a1_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_4.Visible = false;
                    indi1.Visible = true;

                    x1_4 = -300;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_4.Location = new Point(12, x1_4);
                    hitcounter1 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a1_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_4.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    x1_4 = -300;
                    a1_4.Location = new Point(12, x1_4);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }

                if ( a1_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a1_5.Visible = false;
                    indi1.Visible = true;
                    x1_5 = -400;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_5.Location = new Point(12, x1_5);
                    hitcounter1 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a1_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a1_5.Visible = false;
                    indi1.Visible = true;
                    x1_5 = -400;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a1_5.Location = new Point(12, x1_5);
                    hitcounter1 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a1_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a1_5.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    x1_5 = -400;
                    a1_5.Location = new Point(12, x1_5);
                    hitcounter1 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit1");
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
                    maintimer.Start();
                }
            }

        } 

        public void buttonactive2() 
        {
            if (mode == true)
            {
                if (a2_1.Bounds.IntersectsWith(pnlgreat.Bounds) && a2_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    maintimer.Start();

                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a2_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }


                if (a2_2.Bounds.IntersectsWith(pnlgreat.Bounds) && a2_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_2.Visible = false;
                    indi1.Visible = true;

                    x2_2 = -100;

                    a2_2.Location = new Point(89, x2_2);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_2.Visible = false;
                    indi1.Visible = true;

                    x2_2 = -100;

                    a2_2.Location = new Point(89, x2_2);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a2_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_2.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }

                if (a2_3.Bounds.IntersectsWith(pnlgreat.Bounds) && a2_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;

                    x2_3 = -200;

                    a2_3.Location = new Point(89, x2_3);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;

                    x2_3 = -200;

                    a2_3.Location = new Point(89, x2_3);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_3.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_3 = -200;
                    a2_3.Location = new Point(89, x2_3);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }

                if (a2_4.Bounds.IntersectsWith(pnlgreat.Bounds) && a2_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_4.Visible = false;
                    indi1.Visible = true;

                    x2_4 = -300;

                    a2_4.Location = new Point(89, x2_4);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_4.Visible = false;
                    indi1.Visible = true;

                    x2_4 = -300;

                    a2_4.Location = new Point(89, x2_4);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a2_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_4.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_4 = -300;
                    a2_4.Location = new Point(89, x2_4);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }

                if (a2_5.Bounds.IntersectsWith(pnlgreat.Bounds) && a2_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_5.Visible = false;
                    indi1.Visible = true;
                    x2_5 = -400;

                    a2_5.Location = new Point(89, x2_5);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_5.Visible = false;
                    indi1.Visible = true;
                    x2_5 = -400;

                    a2_5.Location = new Point(89, x2_5);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a2_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_5.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_5 = -400;
                    a2_5.Location = new Point(89, x1_5);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }
            }
            //student
            else  
            {
                if (a2_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a2_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }


                if ( a2_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_2.Visible = false;
                    indi1.Visible = true;

                    x2_2 = -100;

                    a2_2.Location = new Point(89, x2_2);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_2.Visible = false;
                    indi1.Visible = true;

                    x2_2 = -100;

                    a2_2.Location = new Point(89, x2_2);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a2_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_2.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_2 = -100;
                    a2_2.Location = new Point(89, x2_2);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }

                if ( a2_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;

                    x2_3 = -200;

                    a2_3.Location = new Point(89, x2_3);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_1.Visible = false;
                    indi1.Visible = true;

                    x2_3 = -200;

                    a2_3.Location = new Point(89, x2_3);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_3.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_3 = -200;
                    a2_3.Location = new Point(89, x2_3);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }

                if ( a2_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_4.Visible = false;
                    indi1.Visible = true;

                    x2_4 = -300;

                    a2_4.Location = new Point(89, x2_4);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_4.Visible = false;
                    indi1.Visible = true;

                    x2_4 = -300;

                    a2_4.Location = new Point(89, x2_4);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a2_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_4.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_4 = -300;
                    a2_4.Location = new Point(89, x2_4);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }

                if ( a2_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a2_5.Visible = false;
                    indi1.Visible = true;
                    x2_5 = -400;

                    a2_5.Location = new Point(89, x2_5);
                    hitcounter2 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a2_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a2_5.Visible = false;
                    indi1.Visible = true;
                    x2_5 = -400;

                    a2_5.Location = new Point(89, x2_5);
                    hitcounter2 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a2_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a2_5.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";

                    x2_5 = -400;
                    a2_5.Location = new Point(89, x1_5);
                    hitcounter2 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit2");
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
                    maintimer.Start();
                }
            }
        }

        public void buttonactive3() 
        {
            if (mode == true)
            {
                if (a3_1.Bounds.IntersectsWith(pnlgreat.Bounds) && a3_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_1 = 0;

                    a3_1.Location = new Point(163, x3_1);
                    hitcounter3 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_1 = 0;

                    a3_1.Location = new Point(163, x3_1);
                    hitcounter3 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);
                    hitcounter3 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                }


                if (a3_2.Bounds.IntersectsWith(pnlgreat.Bounds) && a3_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_2 = -100;

                    a3_2.Location = new Point(163, x3_2);
                    hitcounter3 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a3_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_2 = -100;

                    a3_2.Location = new Point(163, x3_2);
                    hitcounter3 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);
                    hitcounter3 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();

                }

                if (a3_3.Bounds.IntersectsWith(pnlgreat.Bounds) && a3_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_3 = -200;

                    a3_3.Location = new Point(163, x3_3);
                    hitcounter3 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a3_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_3 = -200;

                    a3_3.Location = new Point(163, x3_3);
                    hitcounter3 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_3 = -200;
                    a3_3.Location = new Point(163, x3_3);
                    hitcounter3 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                }

                if (a3_4.Bounds.IntersectsWith(pnlgreat.Bounds) && a3_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_4 = -300;

                    a3_4.Location = new Point(163, x3_4);
                    hitcounter3 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a3_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_4 = -300;

                    a3_4.Location = new Point(163, x3_4);
                    hitcounter3 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_4 = -300;
                    a3_4.Location = new Point(163, x3_4);
                    hitcounter3 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                }

                if (a3_5.Bounds.IntersectsWith(pnlgreat.Bounds) && a3_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_5 = -400;

                    a3_5.Location = new Point(163, x3_5);
                    hitcounter3 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a3_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_5 = -400;

                    a3_5.Location = new Point(163, x3_5);
                    hitcounter3 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_5 = -400;
                    a3_5.Location = new Point(163, x3_5);
                    hitcounter3 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                }
        
            }
            //student
            else 
            {
                if (a3_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_1 = 0;

                    a3_1.Location = new Point(163, x3_1);
                    hitcounter3 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_1 = 0;

                    a3_1.Location = new Point(163, x3_1);
                    hitcounter3 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);
                    hitcounter3 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                }


                if (a3_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_2 = -100;

                    a3_2.Location = new Point(163, x3_2);
                    hitcounter3 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a3_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_2 = -100;

                    a3_2.Location = new Point(163, x3_2);
                    hitcounter3 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);
                    hitcounter3 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();

                }

                if (a3_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_3 = -200;

                    a3_3.Location = new Point(163, x3_3);
                    hitcounter3 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a3_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_3 = -200;

                    a3_3.Location = new Point(163, x3_3);
                    hitcounter3 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_3 = -200;
                    a3_3.Location = new Point(163, x3_3);
                    hitcounter3 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                }

                if (a3_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_4 = -300;

                    a3_4.Location = new Point(163, x3_4);
                    hitcounter3 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a3_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_4 = -300;

                    a3_4.Location = new Point(163, x3_4);
                    hitcounter3 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_4 = -300;
                    a3_4.Location = new Point(163, x3_4);
                    hitcounter3 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                }

                if (a3_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a3_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_5 = -400;

                    a3_5.Location = new Point(163, x3_5);
                    hitcounter3 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a3_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a3_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x3_5 = -400;

                    a3_5.Location = new Point(163, x3_5);
                    hitcounter3 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a3_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a3_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x3_5 = -400;
                    a3_5.Location = new Point(163, x3_5);
                    hitcounter3 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit3");
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
                    maintimer.Start();
                }
        
            }

           
        }
        
        public void buttonactive4() 
        {
            if (mode == true)
            {
                if (a4_1.Bounds.IntersectsWith(pnlgreat.Bounds) && a4_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_1 = 0;

                    a4_1.Location = new Point(239, x4_1);
                    hitcounter4 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a4_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_1 = 0;

                    a4_1.Location = new Point(239, x4_1);
                    hitcounter4 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a4_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    hitcounter4 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }

                if (a4_2.Bounds.IntersectsWith(pnlgreat.Bounds) && a4_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_2 = -100;

                    a4_2.Location = new Point(239, x4_2);

                    hitcounter4 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a4_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_2 = -100;

                    a4_2.Location = new Point(239, x4_2);

                    hitcounter4 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a4_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);
                    hitcounter4 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }
                if (a4_3.Bounds.IntersectsWith(pnlgreat.Bounds) && a4_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_3.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);
                    hitcounter4 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a4_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_3.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);
                    hitcounter4 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a4_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);

                    hitcounter4 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }
                if (a4_4.Bounds.IntersectsWith(pnlgreat.Bounds) && a4_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_4.Visible = false;
                    indi1.Visible = true;

                    x4_4 = -300;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a4_4.Location = new Point(239, x4_4);
                    hitcounter4 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a4_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_4.Visible = false;
                    indi1.Visible = true;

                    x4_4 = -300;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a4_4.Location = new Point(239, x4_4);
                    hitcounter4 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a4_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_4.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_4 = -300;
                    a4_4.Location = new Point(239, x4_4);
                    hitcounter4 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }

                if (a4_5.Bounds.IntersectsWith(pnlgreat.Bounds) && a4_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_5.Visible = false;
                    indi1.Visible = true;
                    x4_5 = -400;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a4_5.Location = new Point(239, x4_5);
                    hitcounter4 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a4_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_5.Visible = false;
                    indi1.Visible = true;
                    x4_5 = -400;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a4_5.Location = new Point(239, x4_5);
                    hitcounter4 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a4_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_5.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    x4_5 = -400;
                    a4_5.Location = new Point(239, x4_5);
                    hitcounter4 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }

            }
            //student
            else 
            {
                if (a4_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_1 = 0;

                    a4_1.Location = new Point(239, x4_1);
                    hitcounter4 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a4_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_1 = 0;

                    a4_1.Location = new Point(239, x4_1);
                    hitcounter4 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a4_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    hitcounter4 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }

                if ( a4_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_2 = -100;

                    a4_2.Location = new Point(239, x4_2);

                    hitcounter4 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a4_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_2 = -100;

                    a4_2.Location = new Point(239, x4_2);

                    hitcounter4 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a4_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);
                    hitcounter4 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }
                if ( a4_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_3.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);
                    hitcounter4 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a4_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_3.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);
                    hitcounter4 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a4_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_3 = -200;
                    a4_3.Location = new Point(239, x4_3);

                    hitcounter4 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }
                if ( a4_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_4.Visible = false;
                    indi1.Visible = true;

                    x4_4 = -300;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a4_4.Location = new Point(239, x4_4);
                    hitcounter4 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a4_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_4.Visible = false;
                    indi1.Visible = true;

                    x4_4 = -300;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a4_4.Location = new Point(239, x4_4);
                    hitcounter4 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a4_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_4.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x4_4 = -300;
                    a4_4.Location = new Point(239, x4_4);
                    hitcounter4 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }

                if (a4_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a4_5.Visible = false;
                    indi1.Visible = true;
                    x4_5 = -400;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a4_5.Location = new Point(239, x4_5);
                    hitcounter4 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a4_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a4_5.Visible = false;
                    indi1.Visible = true;
                    x4_5 = -400;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    a4_5.Location = new Point(239, x4_5);
                    hitcounter4 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                else if (a4_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a4_5.Visible = false;
                    indi1.Visible = true;
                    indi1.Text = "Good";
                    x4_5 = -400;
                    a4_5.Location = new Point(239, x4_5);
                    hitcounter4 += 1;
                    goodcounter += 1;
                    combocounter = 0;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit4");
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
                    maintimer.Start();
                }

            }
        }

        public void buttonactive5()
        {
            if (mode == true)
            {

                if (a5_1.Bounds.IntersectsWith(pnlgreat.Bounds) && a5_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_1 = 0;

                    a5_1.Location = new Point(12, x1_1);
                    hitcounter5 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_1 = 0;

                    a5_1.Location = new Point(12, x1_1);
                    hitcounter5 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x5_1 = 0;
                    a5_1.Location = new Point(12, x1_1);
                    hitcounter5 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();

                }


                if (a5_2.Bounds.IntersectsWith(pnlgreat.Bounds) && a5_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_2 = -100;

                    a5_2.Location = new Point(12, x1_2);
                    hitcounter5 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_2 = -100;

                    a5_2.Location = new Point(12, x1_2);
                    hitcounter5 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x5_2 = -100;
                    a5_2.Location = new Point(12, x1_2);
                    hitcounter5 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                }

                if (a5_3.Bounds.IntersectsWith(pnlgreat.Bounds) && a5_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_3 = -200;

                    a5_3.Location = new Point(12, x1_3);
                    hitcounter5 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a5_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_3 = -200;

                    a5_3.Location = new Point(12, x1_3);
                    hitcounter5 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x5_3 = -200;
                    a5_3.Location = new Point(12, x1_3);
                    hitcounter5 += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                }

                if (a5_4.Bounds.IntersectsWith(pnlgreat.Bounds) && a5_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_4 = -300;

                    a5_4.Location = new Point(12, x1_4);
                    hitcounter5 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_4 = -300;

                    a5_4.Location = new Point(12, x1_4);
                    hitcounter5 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x5_4 = -300;
                    a5_4.Location = new Point(12, x1_4);
                    hitcounter5 += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                }

                if (a5_5.Bounds.IntersectsWith(pnlgreat.Bounds) && a5_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_5 = -400;

                    a5_5.Location = new Point(12, x1_5);
                    hitcounter5 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a5_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_5 = -400;

                    a5_5.Location = new Point(12, x1_5);
                    hitcounter5 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a5_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_5 = -400;
                    a5_5.Location = new Point(12, x1_5);
                    hitcounter5 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                }
            }
            //student
            else 
            {

                if (a5_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_1 = 0;

                    a5_1.Location = new Point(12, x1_1);
                    hitcounter5 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_1 = 0;

                    a5_1.Location = new Point(12, x1_1);
                    hitcounter5 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x5_1 = 0;
                    a5_1.Location = new Point(12, x1_1);
                    hitcounter5 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();

                }


                if ( a5_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_2 = -100;

                    a5_2.Location = new Point(12, x1_2);
                    hitcounter5 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_2 = -100;

                    a5_2.Location = new Point(12, x1_2);
                    hitcounter5 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x5_2 = -100;
                    a5_2.Location = new Point(12, x1_2);
                    hitcounter5 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                }

                if ( a5_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_3 = -200;

                    a5_3.Location = new Point(12, x1_3);
                    hitcounter5 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a5_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_3 = -200;

                    a5_3.Location = new Point(12, x1_3);
                    hitcounter5 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x5_3 = -200;
                    a5_3.Location = new Point(12, x1_3);
                    hitcounter5 += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    goodcounter += 1;
                    onestimercounter = 2;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    textdelay = true;
                    maintimer.Start();
                }

                if ( a5_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_4 = -300;

                    a5_4.Location = new Point(12, x1_4);
                    hitcounter5 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_4 = -300;

                    a5_4.Location = new Point(12, x1_4);
                    hitcounter5 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a5_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x5_4 = -300;
                    a5_4.Location = new Point(12, x1_4);
                    hitcounter5 += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                }

                if ( a5_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a5_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_5 = -400;

                    a5_5.Location = new Point(12, x1_5);
                    hitcounter5 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a5_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a5_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_5 = -400;

                    a5_5.Location = new Point(12, x1_5);
                    hitcounter5 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a5_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a5_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x5_5 = -400;
                    a5_5.Location = new Point(12, x1_5);
                    hitcounter5 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit5");
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
                    maintimer.Start();
                }
            }
        } 

        public void buttonactive6()
        {
            if (mode == true)
            {
                if (a6_1.Bounds.IntersectsWith(pnlgreat.Bounds) && a6_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_1 = 0;

                    a6_1.Location = new Point(12, x1_1);
                    hitcounter6 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a6_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_1 = 0;

                    a6_1.Location = new Point(12, x1_1);
                    hitcounter6 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }

                if (a6_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x6_1 = 0;
                    a6_1.Location = new Point(12, x1_1);
                    hitcounter6 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }


                if (a6_2.Bounds.IntersectsWith(pnlgreat.Bounds) && a6_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_2 = -100;

                    a6_2.Location = new Point(12, x1_2);
                    hitcounter6 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_2 = -100;

                    a6_2.Location = new Point(12, x1_2);
                    hitcounter6 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a6_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x6_2 = -100;
                    a6_2.Location = new Point(12, x1_2);
                    hitcounter6 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }

                if (a6_3.Bounds.IntersectsWith(pnlgreat.Bounds) && a6_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_3 = -200;

                    a6_3.Location = new Point(12, x1_3);
                    hitcounter6 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_3 = -200;

                    a6_3.Location = new Point(12, x1_3);
                    hitcounter6 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x6_3 = -200;
                    a6_3.Location = new Point(12, x1_3);
                    hitcounter6 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }

                if (a6_4.Bounds.IntersectsWith(pnlgreat.Bounds) && a6_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_4 = -300;

                    a6_4.Location = new Point(12, x1_4);
                    hitcounter6 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_4 = -300;

                    a6_4.Location = new Point(12, x1_4);
                    hitcounter6 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a6_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_4 = -300;
                    a6_4.Location = new Point(12, x1_4);
                    hitcounter6 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }

                if (a6_5.Bounds.IntersectsWith(pnlgreat.Bounds) && a6_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_5 = -400;

                    a6_5.Location = new Point(12, x1_5);
                    hitcounter6 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_5 = -400;

                    a6_5.Location = new Point(12, x1_5);
                    hitcounter6 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a6_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x6_5 = -400;
                    a6_5.Location = new Point(12, x1_5);
                    hitcounter6 += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }
            }
            //student
            else 
            {
                if ( a6_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_1 = 0;

                    a6_1.Location = new Point(12, x1_1);
                    hitcounter6 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a6_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_1 = 0;

                    a6_1.Location = new Point(12, x1_1);
                    hitcounter6 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }

                if (a6_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x6_1 = 0;
                    a6_1.Location = new Point(12, x1_1);
                    hitcounter6 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }


                if ( a6_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_2 = -100;

                    a6_2.Location = new Point(12, x1_2);
                    hitcounter6 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_2 = -100;

                    a6_2.Location = new Point(12, x1_2);
                    hitcounter6 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a6_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x6_2 = -100;
                    a6_2.Location = new Point(12, x1_2);
                    hitcounter6 += 1;
                    goodcounter += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }

                if ( a6_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_3 = -200;

                    a6_3.Location = new Point(12, x1_3);
                    hitcounter6 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_3 = -200;

                    a6_3.Location = new Point(12, x1_3);
                    hitcounter6 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x6_3 = -200;
                    a6_3.Location = new Point(12, x1_3);
                    hitcounter6 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }

                if ( a6_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_4 = -300;

                    a6_4.Location = new Point(12, x1_4);
                    hitcounter6 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_4 = -300;

                    a6_4.Location = new Point(12, x1_4);
                    hitcounter6 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a6_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_4 = -300;
                    a6_4.Location = new Point(12, x1_4);
                    hitcounter6 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }

                if ( a6_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a6_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_5 = -400;

                    a6_5.Location = new Point(12, x1_5);
                    hitcounter6 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a6_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a6_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x6_5 = -400;

                    a6_5.Location = new Point(12, x1_5);
                    hitcounter6 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a6_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a6_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x6_5 = -400;
                    a6_5.Location = new Point(12, x1_5);
                    hitcounter6 += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit6");
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
                    maintimer.Start();
                }
            }
        }

        public void buttonactive7()
        {
            if (mode == true)
            {

                if (a7_1.Bounds.IntersectsWith(pnlgreat.Bounds) && a7_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_1 = 0;

                    a7_1.Location = new Point(12, x1_1);
                    hitcounter7 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a7_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_1 = 0;

                    a7_1.Location = new Point(12, x1_1);
                    hitcounter7 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_1 = 0;
                    a7_1.Location = new Point(12, x1_1);
                    hitcounter7 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }


                if (a7_2.Bounds.IntersectsWith(pnlgreat.Bounds) && a7_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_2 = -100;

                    a7_2.Location = new Point(12, x1_2);
                    hitcounter7 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_2 = -100;

                    a7_2.Location = new Point(12, x1_2);
                    hitcounter7 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a7_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_2 = -100;
                    a7_2.Location = new Point(12, x1_2);
                    hitcounter7 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }

                if (a7_3.Bounds.IntersectsWith(pnlgreat.Bounds) && a7_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_3 = -200;

                    a7_3.Location = new Point(12, x1_3);
                    hitcounter7 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_3 = -200;

                    a7_3.Location = new Point(12, x1_3);
                    hitcounter7 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a7_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_3 = -200;
                    a7_3.Location = new Point(12, x1_3);
                    hitcounter7 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }

                if (a7_4.Bounds.IntersectsWith(pnlgreat.Bounds) && a7_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_4 = -300;

                    a7_4.Location = new Point(12, x1_4);
                    hitcounter7 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_4 = -300;

                    a7_4.Location = new Point(12, x1_4);
                    hitcounter7 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_4 = -300;
                    a7_4.Location = new Point(12, x1_4);
                    hitcounter7 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }

                if (a7_5.Bounds.IntersectsWith(pnlgreat.Bounds) && a7_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_5 = -400;

                    a7_5.Location = new Point(12, x1_5);
                    hitcounter7 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_5 = -400;

                    a7_5.Location = new Point(12, x1_5);
                    hitcounter7 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a7_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x7_5 = -400;
                    a7_5.Location = new Point(12, x1_5);
                    hitcounter7 += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }
            }
            //student
            else 
            {

                if (a7_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_1 = 0;

                    a7_1.Location = new Point(12, x1_1);
                    hitcounter7 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a7_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_1 = 0;

                    a7_1.Location = new Point(12, x1_1);
                    hitcounter7 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();

                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_1 = 0;
                    a7_1.Location = new Point(12, x1_1);
                    hitcounter7 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }


                if (a7_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_2 = -100;

                    a7_2.Location = new Point(12, x1_2);
                    hitcounter7 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_2 = -100;

                    a7_2.Location = new Point(12, x1_2);
                    hitcounter7 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a7_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_2 = -100;
                    a7_2.Location = new Point(12, x1_2);
                    hitcounter7 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }

                if (a7_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_3 = -200;

                    a7_3.Location = new Point(12, x1_3);
                    hitcounter7 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_3 = -200;

                    a7_3.Location = new Point(12, x1_3);
                    hitcounter7 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a7_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_3 = -200;
                    a7_3.Location = new Point(12, x1_3);
                    hitcounter7 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }

                if ( a7_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_4 = -300;

                    a7_4.Location = new Point(12, x1_4);
                    hitcounter7 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_4 = -300;

                    a7_4.Location = new Point(12, x1_4);
                    hitcounter7 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_4 = -300;
                    a7_4.Location = new Point(12, x1_4);
                    hitcounter7 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }

                if ( a7_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a7_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_5 = -400;

                    a7_5.Location = new Point(12, x1_5);
                    hitcounter7 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a7_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a7_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x7_5 = -400;

                    a7_5.Location = new Point(12, x1_5);
                    hitcounter7 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a7_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a7_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";

                    x7_5 = -400;
                    a7_5.Location = new Point(12, x1_5);
                    hitcounter7 += 1;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit7");
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
                    maintimer.Start();
                }
            }
        }

        public void buttonactive8()
        {
            if (mode == true)
            {

                if (a8_1.Bounds.IntersectsWith(pnlgreat.Bounds) && a8_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_1 = 0;

                    a8_1.Location = new Point(12, x1_1);
                    hitcounter8 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a8_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_1 = 0;

                    a8_1.Location = new Point(12, x1_1);
                    hitcounter8 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_1 = 0;
                    a8_1.Location = new Point(12, x1_1);
                    hitcounter8 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }


                if (a8_2.Bounds.IntersectsWith(pnlgreat.Bounds) && a8_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_2 = -100;

                    a8_2.Location = new Point(12, x1_2);
                    hitcounter8 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_2 = -100;

                    a8_2.Location = new Point(12, x1_2);
                    hitcounter8 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a8_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_2 = -100;
                    a8_2.Location = new Point(12, x1_2);
                    hitcounter8 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }

                if (a8_3.Bounds.IntersectsWith(pnlgreat.Bounds) && a8_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_3 = -200;

                    a8_3.Location = new Point(12, x1_3);
                    hitcounter8 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a8_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_3 = -200;

                    a8_3.Location = new Point(12, x1_3);
                    hitcounter8 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_3 = -200;
                    a8_3.Location = new Point(12, x1_3);
                    hitcounter8 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }

                if (a8_4.Bounds.IntersectsWith(pnlgreat.Bounds) && a8_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_4 = -300;

                    a8_4.Location = new Point(12, x1_4);
                    hitcounter8 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a8_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_4 = -300;

                    a8_4.Location = new Point(12, x1_4);
                    hitcounter8 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_4 = -300;
                    a8_4.Location = new Point(12, x1_4);
                    hitcounter8 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }

                if (a8_5.Bounds.IntersectsWith(pnlgreat.Bounds) && a8_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_5 = -400;

                    a8_5.Location = new Point(12, x1_5);
                    hitcounter8 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a8_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_5 = -400;

                    a8_5.Location = new Point(12, x1_5);
                    hitcounter8 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_5 = -400;
                    a8_5.Location = new Point(12, x1_5);
                    hitcounter8 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }
            }
            //student
            else 
            {

                if ( a8_1.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_1 = 0;

                    a8_1.Location = new Point(12, x1_1);
                    hitcounter8 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }

                }
                if (a8_1.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_1 = 0;

                    a8_1.Location = new Point(12, x1_1);
                    hitcounter8 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_1.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_1 = 0;
                    a8_1.Location = new Point(12, x1_1);
                    hitcounter8 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }


                if ( a8_2.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_2 = -100;

                    a8_2.Location = new Point(12, x1_2);
                    hitcounter8 += 1;
                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_2.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_2.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_2 = -100;

                    a8_2.Location = new Point(12, x1_2);
                    hitcounter8 += 1;
                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a8_2.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_2.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_2 = -100;
                    a8_2.Location = new Point(12, x1_2);
                    hitcounter8 += 1;
                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }

                if ( a8_3.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_3 = -200;

                    a8_3.Location = new Point(12, x1_3);
                    hitcounter8 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a8_3.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_1.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_3 = -200;

                    a8_3.Location = new Point(12, x1_3);
                    hitcounter8 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_3.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_3.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_3 = -200;
                    a8_3.Location = new Point(12, x1_3);
                    hitcounter8 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }

                if ( a8_4.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_4 = -300;

                    a8_4.Location = new Point(12, x1_4);
                    hitcounter8 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a8_4.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_4.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_4 = -300;

                    a8_4.Location = new Point(12, x1_4);
                    hitcounter8 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_4.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_4.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_4 = -300;
                    a8_4.Location = new Point(12, x1_4);
                    hitcounter8 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }

                if ( a8_5.Bounds.IntersectsWith(pnl1.Bounds))
                {
                    a8_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Perfect x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_5 = -400;

                    a8_5.Location = new Point(12, x1_5);
                    hitcounter8 += 1;

                    perfectcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
                if (a8_5.Bounds.IntersectsWith(pnlgreat.Bounds))
                {
                    a8_5.Visible = false;
                    indi1.Visible = true;
                    combocounter += 1;
                    indi1.Text = "Great x" + combocounter;
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_5 = -400;

                    a8_5.Location = new Point(12, x1_5);
                    hitcounter8 += 1;

                    greatcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                    energyvaluechecker = energybar1.Value + hitincreasecounter;

                    if (energyvaluechecker < maxenergy && energymultipliercounter <= 0)
                    {
                        energybar1.Value += hitincreasecounter;
                    }
                    if (energyvaluechecker > maxenergy)
                    {
                        energybar1.Value = maxenergy;
                    }
                    if (combocounter % 3 == 0 && energybar1.Value == maxenergy)
                    {
                        energymultipliercounter += 1;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }

                if (a8_5.Bounds.IntersectsWith(pnl2.Bounds))
                {
                    a8_5.Visible = false;
                    indi1.Visible = true;
                    combocounter = 0;
                    indi1.Text = "Good";
                    scorecounter += maxscoreperhit;
                    score1.Text = scorecounter.ToString();
                    x8_5 = -400;
                    a8_5.Location = new Point(12, x1_5);
                    hitcounter8 += 1;

                    goodcounter += 1;
                    onestimercounter = 2;
                    textdelay = true;
                    if (indicatorled == true)
                    {
                        try
                        {
                            port1.Open();
                            port1.Write("hit8");
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
                    maintimer.Start();
                }
            }
        } 

        #endregion 

        public drumstutos()
        {
            InitializeComponent();
            sticks = new SoundPlayer(drumtuto_main.Properties.Resources.countdown);
            snare = new SoundPlayer(drumtuto_main.Properties.Resources.snare);
            assessmentrestartflag = assessmentform.restartflag;

            rockflag = menu2.rockflag;
            classicflag = menu2.classicflag;
            jazzflag = menu2.jazzflag;
            basicbeats1flag = menu2.basicbeats1flag;
            basicbeats2flag = menu2.basicbeats2flag;
            basicbeats3flag = menu2.basicbeats3flag;
            mode = Settings.mode;
            indicatorled = Settings.indicatorled;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region designs
            groupBox2.BackColor = Color.FromArgb(170, Color.Black);
            drumpic.BackColor = Color.FromArgb(120, Color.Black);
            panel1.BackColor = Color.FromArgb(170, Color.Black);
            pausetab.BackColor = Color.FromArgb(170, Color.Black);
           
            drumpic.BackgroundImage = drumtuto_main.Properties.Resources.drumset;
            indi1.Parent = panel1;
  
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

            watch5_1 = Stopwatch.StartNew();
            watch5_2 = Stopwatch.StartNew();
            watch5_3 = Stopwatch.StartNew();
            watch5_4 = Stopwatch.StartNew();
            watch5_5 = Stopwatch.StartNew();
            watch5_6 = Stopwatch.StartNew();
            watch5_7 = Stopwatch.StartNew();
            watch5_8 = Stopwatch.StartNew();

            watch6_1 = Stopwatch.StartNew();
            watch6_2 = Stopwatch.StartNew();
            watch6_3 = Stopwatch.StartNew();
            watch6_4 = Stopwatch.StartNew();
            watch6_5 = Stopwatch.StartNew();
            watch6_6 = Stopwatch.StartNew();
            watch6_7 = Stopwatch.StartNew();
            watch6_8 = Stopwatch.StartNew();

            watch7_1 = Stopwatch.StartNew();
            watch7_2 = Stopwatch.StartNew();
            watch7_3 = Stopwatch.StartNew();
            watch7_4 = Stopwatch.StartNew();
            watch7_5 = Stopwatch.StartNew();
            watch7_6 = Stopwatch.StartNew();
            watch7_7 = Stopwatch.StartNew();
            watch7_8 = Stopwatch.StartNew();

            watch8_1 = Stopwatch.StartNew();
            watch8_2 = Stopwatch.StartNew();
            watch8_3 = Stopwatch.StartNew();
            watch8_4 = Stopwatch.StartNew();
            watch8_5 = Stopwatch.StartNew();
            watch8_6 = Stopwatch.StartNew();
            watch8_7 = Stopwatch.StartNew();
            watch8_8 = Stopwatch.StartNew();

            #endregion

            #region startingdes
            durations.Stop();
            starting_val();
            n1.Stop();
            n2.Stop();
            n3.Stop();
            n4.Stop();
            n5.Stop();
            n6.Stop();
            n7.Stop();
            n8.Stop();
            maintimer.Start();
            //Tutorials();            
            energybar1.Maximum = maxenergy;
            energybar1.Value = energybar1.Maximum;
            #endregion

        }

        private void p1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string p1s = p1.ReadExisting().ToString();

            if (p1s.StartsWith("X"))

            {
                Button.CheckForIllegalCrossThreadCalls = false;
                buttonactive2();
                //a1.BackgroundImage = drumtuto_main.Properties.Resources.b1activated;
                //b1.Visible = true;

            }
       

        }

        private void durations_Tick(object sender, EventArgs e)
        {
            starting_speeds();
            Tutorials();
            indi1.SendToBack();
            //end of gameover
         
            if (jazzflag == true && patterncounter > 9)
            {
                patterncounter = 1;
                sequencecounter = 1;
                sequenceloopflag = false;
                a1_1.Visible = false;
                a1_2.Visible = false;
                a1_3.Visible = false;
                a1_4.Visible = false;
                a1_5.Visible = false;

                a2_1.Visible = false;
                a2_2.Visible = false;
                a2_3.Visible = false;
                a2_4.Visible = false;
                a2_5.Visible = false;

                a3_1.Visible = false;
                a3_2.Visible = false;
                a3_3.Visible = false;
                a3_4.Visible = false;
                a3_5.Visible = false;

                a4_1.Visible = false;
                a4_2.Visible = false;
                a4_3.Visible = false;
                a4_4.Visible = false;
                a4_5.Visible = false;

                a5_1.Visible = false;
                a5_2.Visible = false;
                a5_3.Visible = false;
                a5_4.Visible = false;
                a5_5.Visible = false;

                a6_1.Visible = false;
                a6_2.Visible = false;
                a6_3.Visible = false;
                a6_4.Visible = false;
                a6_5.Visible = false;

                a7_1.Visible = false;
                a7_2.Visible = false;
                a7_3.Visible = false;
                a7_4.Visible = false;
                a7_5.Visible = false;

                a8_1.Visible = false;
                a8_2.Visible = false;
                a8_3.Visible = false;
                a8_4.Visible = false;
                a8_5.Visible = false;

                n1.Stop();
                n2.Stop();
                n3.Stop();
                n4.Stop();
                n5.Stop();
                n6.Stop();
                n7.Stop();
                n8.Stop();
                durations.Interval = 150;

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
                gameoverflag = true;

            }
            if (classicflag == true && patterncounter>9)
            {
                patterncounter = 1;
                sequencecounter = 1;
                sequenceloopflag = false;
                a1_1.Visible = false;
                a1_2.Visible = false;
                a1_3.Visible = false;
                a1_4.Visible = false;
                a1_5.Visible = false;

                a2_1.Visible = false;
                a2_2.Visible = false;
                a2_3.Visible = false;
                a2_4.Visible = false;
                a2_5.Visible = false;

                a3_1.Visible = false;
                a3_2.Visible = false;
                a3_3.Visible = false;
                a3_4.Visible = false;
                a3_5.Visible = false;

                a4_1.Visible = false;
                a4_2.Visible = false;
                a4_3.Visible = false;
                a4_4.Visible = false;
                a4_5.Visible = false;

                a5_1.Visible = false;
                a5_2.Visible = false;
                a5_3.Visible = false;
                a5_4.Visible = false;
                a5_5.Visible = false;

                a6_1.Visible = false;
                a6_2.Visible = false;
                a6_3.Visible = false;
                a6_4.Visible = false;
                a6_5.Visible = false;

                a7_1.Visible = false;
                a7_2.Visible = false;
                a7_3.Visible = false;
                a7_4.Visible = false;
                a7_5.Visible = false;

                a8_1.Visible = false;
                a8_2.Visible = false;
                a8_3.Visible = false;
                a8_4.Visible = false;
                a8_5.Visible = false;

                n1.Stop();
                n2.Stop();
                n3.Stop();
                n4.Stop();
                n5.Stop();
                n6.Stop();
                n7.Stop();
                n8.Stop();
                durations.Interval = 150;

                if(indicatorled == true)
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
                gameoverflag = true;
            }
            if (rockflag==true && patterncounter >12)
            {
                a1_1.Visible = false;
                a1_2.Visible = false;
                a1_3.Visible = false;
                a1_4.Visible = false;
                a1_5.Visible = false;

                a2_1.Visible = false;
                a2_2.Visible = false;
                a2_3.Visible = false;
                a2_4.Visible = false;
                a2_5.Visible = false;

                a3_1.Visible = false;
                a3_2.Visible = false;
                a3_3.Visible = false;
                a3_4.Visible = false;
                a3_5.Visible = false;

                a4_1.Visible = false;
                a4_2.Visible = false;
                a4_3.Visible = false;
                a4_4.Visible = false;
                a4_5.Visible = false;

                a5_1.Visible = false;
                a5_2.Visible = false;
                a5_3.Visible = false;
                a5_4.Visible = false;
                a5_5.Visible = false;

                a6_1.Visible = false;
                a6_2.Visible = false;
                a6_3.Visible = false;
                a6_4.Visible = false;
                a6_5.Visible = false;

                a7_1.Visible = false;
                a7_2.Visible = false;
                a7_3.Visible = false;
                a7_4.Visible = false;
                a7_5.Visible = false;

                a8_1.Visible = false;
                a8_2.Visible = false;
                a8_3.Visible = false;
                a8_4.Visible = false;
                a8_5.Visible = false;

                n1.Stop();
                n2.Stop();
                n3.Stop();
                n4.Stop();
                n5.Stop();
                n6.Stop();
                n7.Stop();
                n8.Stop();
                durations.Interval = 150;
                if(indicatorled == true)
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
                gameoverflag = true;
            }
            if (basicbeats2flag==true && patterncounter > 9)
            {
                patterncounter = 1;
                sequencecounter = 1;
                sequenceloopflag = false;
                a1_1.Visible = false;
                a1_2.Visible = false;
                a1_3.Visible = false;
                a1_4.Visible = false;
                a1_5.Visible = false;

                a2_1.Visible = false;
                a2_2.Visible = false;
                a2_3.Visible = false;
                a2_4.Visible = false;
                a2_5.Visible = false;

                a3_1.Visible = false;
                a3_2.Visible = false;
                a3_3.Visible = false;
                a3_4.Visible = false;
                a3_5.Visible = false;

                a4_1.Visible = false;
                a4_2.Visible = false;
                a4_3.Visible = false;
                a4_4.Visible = false;
                a4_5.Visible = false;

                a5_1.Visible = false;
                a5_2.Visible = false;
                a5_3.Visible = false;
                a5_4.Visible = false;
                a5_5.Visible = false;

                a6_1.Visible = false;
                a6_2.Visible = false;
                a6_3.Visible = false;
                a6_4.Visible = false;
                a6_5.Visible = false;

                a7_1.Visible = false;
                a7_2.Visible = false;
                a7_3.Visible = false;
                a7_4.Visible = false;
                a7_5.Visible = false;

                a8_1.Visible = false;
                a8_2.Visible = false;
                a8_3.Visible = false;
                a8_4.Visible = false;
                a8_5.Visible = false;

                n1.Stop();
                n2.Stop();
                n3.Stop();
                n4.Stop();
                n5.Stop();
                n6.Stop();
                n7.Stop();
                n8.Stop();
                durations.Interval = 150;
                if(indicatorled == true)
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
                gameoverflag = true;
            }
            if (basicbeats1flag == true && patterncounter > 9)
            {
                patterncounter = 1;
                sequencecounter = 1;
                sequenceloopflag = false;
                a1_1.Visible = false;
                a1_2.Visible = false;
                a1_3.Visible = false;
                a1_4.Visible = false;
                a1_5.Visible = false;

                a2_1.Visible = false;
                a2_2.Visible = false;
                a2_3.Visible = false;
                a2_4.Visible = false;
                a2_5.Visible = false;

                a3_1.Visible = false;
                a3_2.Visible = false;
                a3_3.Visible = false;
                a3_4.Visible = false;
                a3_5.Visible = false;

                a4_1.Visible = false;
                a4_2.Visible = false;
                a4_3.Visible = false;
                a4_4.Visible = false;
                a4_5.Visible = false;

                a5_1.Visible = false;
                a5_2.Visible = false;
                a5_3.Visible = false;
                a5_4.Visible = false;
                a5_5.Visible = false;

                a6_1.Visible = false;
                a6_2.Visible = false;
                a6_3.Visible = false;
                a6_4.Visible = false;
                a6_5.Visible = false;

                a7_1.Visible = false;
                a7_2.Visible = false;
                a7_3.Visible = false;
                a7_4.Visible = false;
                a7_5.Visible = false;

                a8_1.Visible = false;
                a8_2.Visible = false;
                a8_3.Visible = false;
                a8_4.Visible = false;
                a8_5.Visible = false;

                n1.Stop();
                n2.Stop();
                n3.Stop();
                n4.Stop();
                n5.Stop();
                n6.Stop();
                n7.Stop();
                n8.Stop();
                durations.Interval = 150;
                if(indicatorled == true)
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
                gameoverflag = true;
            }
            if(energybar1.Value <= 0)
            {
                patterncounter = 1;
                sequencecounter = 1;
                sequenceloopflag = false;
                failedflag = true;
                a1_1.Visible = false;
                a1_2.Visible = false;
                a1_3.Visible = false;
                a1_4.Visible = false;
                a1_5.Visible = false;

                a2_1.Visible = false;
                a2_2.Visible = false;
                a2_3.Visible = false;
                a2_4.Visible = false;
                a2_5.Visible = false;

                a3_1.Visible = false;
                a3_2.Visible = false;
                a3_3.Visible = false;
                a3_4.Visible = false;
                a3_5.Visible = false;

                a4_1.Visible = false;
                a4_2.Visible = false;
                a4_3.Visible = false;
                a4_4.Visible = false;
                a4_5.Visible = false;

                a5_1.Visible = false;
                a5_2.Visible = false;
                a5_3.Visible = false;
                a5_4.Visible = false;
                a5_5.Visible = false;

                a6_1.Visible = false;
                a6_2.Visible = false;
                a6_3.Visible = false;
                a6_4.Visible = false;
                a6_5.Visible = false;

                a7_1.Visible = false;
                a7_2.Visible = false;
                a7_3.Visible = false;
                a7_4.Visible = false;
                a7_5.Visible = false;

                a8_1.Visible = false;
                a8_2.Visible = false;
                a8_3.Visible = false;
                a8_4.Visible = false;
                a8_5.Visible = false;

                n1.Stop();
                n2.Stop();
                n3.Stop();
                n4.Stop();
                n5.Stop();
                n6.Stop();
                n7.Stop();
                n8.Stop();
                durations.Interval = 150;
                if(indicatorled == true)
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
                gameoverflag = true;

            }
            if(gameoverflag == true)
            {
                Opacity -= 0.5;

                if(Opacity <=0)
                {
                    assessmentform assess = new assessmentform();
                    durations.Stop();
                    assess.Show();
                    assess.Focus();
                    this.Hide();
                }
            }
        }

        private void n1_Tick(object sender, EventArgs e)
        {

            if (beatcounter1 == 1)
            {
                if (hitcounter1 == 0)
                {
                    a1_1.Visible = true;
                    x1_1 += 3080 / 577;
                    a1_1.Location = new Point(12, x1_1);
                }
                if (hitcounter1 == 1)
                {
                    a1_1.Visible = false;
                    x1_1 = 0;
                    a1_1.Location = new Point(12, x1_1);
                    n1.Stop();
                }
            }
            if (beatcounter1 == 2)
            {
                if (hitcounter1 == 0)
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
                if (hitcounter1 == 2)
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
            if (beatcounter1 == 3)
            {
                if (hitcounter1 == 0)
                {
                    a1_1.Visible = true;
                    x1_1 += 3080 / 577;
                    a1_1.Location = new Point(12, x1_1);
                }
                if (hitcounter1 == 1)
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
                if (hitcounter1 == 2)
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

                if (hitcounter1 == 3)
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
            if (beatcounter1 == 4)
            {
                if (hitcounter1 == 0)
                {
                    a1_1.Visible = true;
                    x1_1 += 3080 / 577;
                    a1_1.Location = new Point(12, x1_1);
                }
                if (hitcounter1 == 1)
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
                if (hitcounter1 == 2)
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

                if (hitcounter1 == 3)
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
                if (hitcounter1 == 4)
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
            if (beatcounter1 == 5)
            {
                if (hitcounter1 == 0)
                {
                    a1_1.Visible = true;
                    x1_1 += 3080 / 577;
                    a1_1.Location = new Point(12, x1_1);
                }
                if (hitcounter1 == 1)
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
                if (hitcounter1 == 2)
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

                if (hitcounter1 == 3)
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
                if (hitcounter1 == 4)
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

                if (hitcounter1 == 5)
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
                misscounter += 1;
                hitcounter1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2; 
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss1");
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
                maintimer.Start();
                combocounter = 0;
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if(energymultipliercounter >=1 && energymultipliercounter <=maxenergy)
                {
                    energymultipliercounter --;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if(energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
 
            }
            if (a1_2.Bounds.IntersectsWith(pnl3.Bounds))
            {

                x1_2 = -100;

                a1_2.Visible = false;
                indi1.Visible = false;
                a1_2.Location = new Point(12, x1_2);
                misscounter += 1;
                hitcounter1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss1");
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
                maintimer.Start();
                combocounter = 0;

                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
               
            }
            if (a1_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_3 = -200;

                a1_3.Visible = false;
                indi1.Visible = false;
                a1_3.Location = new Point(12, x1_3);
                misscounter += 1;
                hitcounter1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss1");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
               
                
            }
            if (a1_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_4 = -300;

                a1_4.Visible = false;
                indi1.Visible = false;
                a1_4.Location = new Point(12, x1_4);
                misscounter += 1;
                hitcounter1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss1");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
             

            }
            if (a1_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x1_5 = -400;

                a1_5.Visible = false;
                indi1.Visible = false;
                a1_5.Location = new Point(12, x1_5);
                misscounter += 1;
                hitcounter1 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss1");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
                

            }


        }

        private void n2_Tick(object sender, EventArgs e)
        {
          
            if (beatcounter2 == 1)
            {
                if (hitcounter2 == 0)
                {
                    a2_1.Visible = true;
                    x2_1 += 3080 / 577;
                    a2_1.Location = new Point(89, x2_1);
                }
                if (hitcounter2 == 1)
                {
                    a2_1.Visible = false;
                    x2_1 = 0;
                    a2_1.Location = new Point(89, x2_1);
                    n2.Stop();
                }
            }
            if (beatcounter2 == 2)
            {
                if (hitcounter2 == 0)
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
                if (hitcounter2 == 2)
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
            if (beatcounter2 == 3)
            {
                if (hitcounter2 == 0)
                {
                    a2_1.Visible = true;
                    x2_1 += 3080 / 577;
                    a2_1.Location = new Point(89, x2_1);
                }
                if (hitcounter2 == 1)
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
                if (hitcounter2 == 2)
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

                if (hitcounter2 == 3)
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

            if (beatcounter2 == 4)
            {
                if (hitcounter2 == 0)
                {
                    a2_1.Visible = true;
                    x2_1 += 3080 / 577;
                    a2_1.Location = new Point(89, x2_1);
                }
                if (hitcounter2 == 1)
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
                if (hitcounter2 == 2)
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

                if (hitcounter2 == 3)
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
                if (hitcounter2 == 4)
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
            if (beatcounter2 == 5)
            {
                if (hitcounter2 == 0)
                {
                    a2_1.Visible = true;
                    x2_1 += 3080 / 577;
                    a2_1.Location = new Point(89, x2_1);
                }
                if (hitcounter2 == 1)
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
                if (hitcounter2 == 2)
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

                if (hitcounter2 == 3)
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
                if (hitcounter2 == 4)
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

                if (hitcounter2 == 5)
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
                misscounter += 1;
                hitcounter2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss2");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
         
                
                //n3.Stop();
            }
            if (a2_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x2_2 = -100;

                a2_2.Visible = false;
                indi1.Visible = false;
                a2_2.Location = new Point(89, x2_2);
                misscounter += 1;
                hitcounter2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss2");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               

                
                //n3.Stop();
            }
            if (a2_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x2_3 = -200;

                a2_3.Visible = false;
                indi1.Visible = false;
                a2_3.Location = new Point(89, x2_3);
                misscounter += 1;
                hitcounter2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;   
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss2");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
                //n3.Stop();
            }
            if (a2_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x2_4 = -300;

                a2_4.Visible = false;
                indi1.Visible = false;
                a2_4.Location = new Point(89, x2_4);
                misscounter += 1;
                hitcounter2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss2");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
                //n3.Stop();
            }
            if (a2_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x2_5 = -400;

                a2_5.Visible = false;
                indi1.Visible = false;
                a2_5.Location = new Point(89, x2_5);
                misscounter += 1;
                hitcounter2 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss2");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }


        }

        private void n3_Tick(object sender, EventArgs e)
        {
            if (energybar1.Value <= 0)
            {
                energybar1.Value = 0;
            }
            if (beatcounter3 == 1)
            {
                if (hitcounter3 == 0)
                {
                    a3_1.Visible = true;
                    x3_1 += 3080 / 577;
                    a3_1.Location = new Point(163, x3_1);
                }
                if (hitcounter3 == 1)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);
                    n3.Stop();
                }
            }
            if (beatcounter3 == 2)
            {
                if (hitcounter3 == 0)
                {
                    a3_1.Visible = true;
                    x3_1 += 3080 / 577;
                    a3_1.Location = new Point(163, x3_1);
                }
                if (watch3_1.ElapsedMilliseconds > 15)
                {
                    a3_2.Visible = true;
                    x3_2 += 3080 / 577;
                    a3_2.Location = new Point(163, x3_2);
                }
                watch3_1 = Stopwatch.StartNew();
                if (hitcounter3 == 2)
                {
                    a3_1.Visible = false;
                    x3_1 = 0;
                    a3_1.Location = new Point(163, x3_1);

                    a3_2.Visible = false;
                    x3_2 = -100;
                    a3_2.Location = new Point(163, x3_2);
                    n3.Stop();
                }


            }
            if (beatcounter3 == 3)
            {
                if (hitcounter3 == 0)
                {
                    a3_1.Visible = true;
                    x3_1 += 3080 / 577;
                    a3_1.Location = new Point(163, x3_1);
                }
                if (hitcounter3 == 1)
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
                if (hitcounter3 == 2)
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

                if (hitcounter3 == 3)
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
            if (beatcounter3 == 4)
            {
                if (hitcounter3 == 0)
                {
                    a3_1.Visible = true;
                    x3_1 += 3080 / 577;
                    a3_1.Location = new Point(163, x3_1);
                }
                if (hitcounter3 == 1)
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
                if (hitcounter3 == 2)
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

                if (hitcounter3 == 3)
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
                if (hitcounter3 == 4)
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
            if (beatcounter3 == 5)
            {
                if (hitcounter3 == 0)
                {
                    a3_1.Visible = true;
                    x3_1 += 3080 / 577;
                    a3_1.Location = new Point(163, x3_1);
                }
                if (hitcounter3 == 1)
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
                if (hitcounter3 == 2)
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

                if (hitcounter3 == 3)
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
                if (hitcounter3 == 4)
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

                if (watch3_4.ElapsedMilliseconds > 15)
                {
                    a3_5.Visible = true;
                    x3_5 += 3080 / 577;
                    a3_5.Location = new Point(163, x3_5);
                }
                watch3_4 = Stopwatch.StartNew();

                if (hitcounter3 == 5)
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
                x3_1 = 0;

                a3_1.Visible = false;
                indi1.Visible = false;
                a3_1.Location = new Point(163, x3_1);
                misscounter += 1;
                hitcounter3 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss3");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
                //n3.Stop();
            }
            if (a3_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x3_2 = -100;

                a3_2.Visible = false;
                indi1.Visible = false;
                a3_2.Location = new Point(163, x3_2);
                misscounter += 1;
                hitcounter3 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;      
 
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss3");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
                //n3.Stop();
            }
            if (a3_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x3_3 = -200;

                a3_3.Visible = false;
                indi1.Visible = false;
                a3_3.Location = new Point(163, x3_3);
                misscounter += 1;
                hitcounter3 += 1;
                onestimercounter = 2;
                combocounter = 0;
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss3");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
             
                //n3.Stop();
            }
            if (a3_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x3_4 = -300;

                a3_4.Visible = false;
                indi1.Visible = false;
                a3_4.Location = new Point(163, x3_4);
                misscounter += 1;
                hitcounter3 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss3");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
                //n3.Stop();
            }
            if (a3_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x3_5 = -400;

                a3_5.Visible = false;
                indi1.Visible = false;
                a3_5.Location = new Point(163, x3_5);
                misscounter += 1;
                hitcounter3 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss3");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }

        }

        private void n4_Tick(object sender, EventArgs e)
        {
            if (energybar1.Value <= 0)
            {
                energybar1.Value = 0;
            }
            if (beatcounter4 == 1)
            {
                if (hitcounter4 == 0)
                {
                    a4_1.Visible = true;
                    x4_1 += 3080 / 577;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (hitcounter4 == 1)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);
                    n4.Stop();
                }
            }
            if (beatcounter4 == 2)
            {
                if (hitcounter4 == 0)
                {
                    a4_1.Visible = true;
                    x4_1 += 3080 / 577;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (hitcounter4 == 1)
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

                if (hitcounter4 == 2)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                    a4_2.Visible = false;
                    x4_2 = -100;
                    a4_2.Location = new Point(239, x4_2);
                    n4.Stop();
                }
            }
            if (beatcounter4 == 3)
            {
                if (hitcounter4 == 0)
                {
                    a4_1.Visible = true;
                    x4_1 += 3080 / 577;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (hitcounter4 == 1)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                }
                if (hitcounter4 == 1)
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
                if (hitcounter4 == 2)
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


                if (hitcounter4 == 3)
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

                    n4.Stop();
                }
            }
            if (beatcounter4 == 4)
            {
                if (hitcounter4 == 0)
                {
                    a4_1.Visible = true;
                    x4_1 += 3080 / 577;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (hitcounter4 == 1)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                }
                if (hitcounter4 == 1)
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
                if (hitcounter4 == 2)
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


                if (hitcounter4 == 3)
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
                if (hitcounter4 == 4)
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
            if (beatcounter4 == 5)
            {
                if (hitcounter4 == 0)
                {
                    a4_1.Visible = true;
                    x4_1 += 3080 / 577;
                    a4_1.Location = new Point(239, x4_1);
                }
                if (hitcounter4 == 1)
                {
                    a4_1.Visible = false;
                    x4_1 = 0;
                    a4_1.Location = new Point(239, x4_1);

                }
                if (hitcounter4 == 1)
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
                if (hitcounter4 == 2)
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


                if (hitcounter4 == 3)
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
                if (hitcounter4 == 4)
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

                if (watch4_4.ElapsedMilliseconds > 15)
                {
                    a4_5.Visible = true;
                    x4_5 += 3080 / 577;
                    a4_5.Location = new Point(239, x4_5);
                }

                if (hitcounter4 == 5)
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
                x4_1 = 0;

                a4_1.Visible = false;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_1);
                misscounter += 1;
                hitcounter4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("hit4");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
               
 
            }
            if (a4_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x4_2 = -100;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_2);
                misscounter += 1;
                hitcounter4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss4");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a4_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x4_3 = -200;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_3);
                misscounter += 1;
                hitcounter4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss4");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
 
            }
            if (a4_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x4_4 = -300;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_4);
                misscounter += 1;
                hitcounter4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss4");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a4_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x4_5 = -400;
                indi1.Visible = false;
                a4_1.Location = new Point(239, x4_5);
                misscounter += 1;
                hitcounter4 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss4");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
        }

        private void n5_Tick(object sender, EventArgs e)
        {
            if (energybar1.Value <= 0)
            {
                energybar1.Value = 0;
            }

            if (beatcounter5 == 1)
            {
                if (hitcounter5 == 0)
                {
                    a5_1.Visible = true;
                    x5_1 += 3080 / 577;
                    a5_1.Location = new Point(315, x5_1);
                }
                if (hitcounter5 == 1)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);
                    n5.Stop();
                }
            }
            if (beatcounter5 == 2)
            {
                if (hitcounter5 == 0)
                {
                    a5_1.Visible = true;
                    x5_1 += 3080 / 577;
                    a5_1.Location = new Point(315, x5_1);
                }
                if (watch5_1.ElapsedMilliseconds > 15)
                {
                    a5_2.Visible = true;
                    x5_2 += 3080 / 577;
                    a5_2.Location = new Point(315, x5_2);
                }
                watch5_1 = Stopwatch.StartNew();
                if (hitcounter5 == 2)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);
                    n5.Stop();
                }


            }
            if (beatcounter5 == 3)
            {
                if (hitcounter5 == 0)
                {
                    a5_1.Visible = true;
                    x5_1 += 3080 / 577;
                    a5_1.Location = new Point(315, x5_1);
                }
                if (hitcounter5 == 1)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);
                }


                if (watch5_1.ElapsedMilliseconds > 15)
                {
                    a5_2.Visible = true;
                    x5_2 += 3080 / 577;
                    a5_2.Location = new Point(315, x5_2);
                }
                watch5_1 = Stopwatch.StartNew();
                if (hitcounter5 == 2)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);
                }
                if (watch5_2.ElapsedMilliseconds > 15)
                {
                    a5_3.Visible = true;
                    x5_3 += 3080 / 577;
                    a5_3.Location = new Point(315, x5_3);
                }
                watch5_2 = Stopwatch.StartNew();

                if (hitcounter5 == 3)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);

                    a5_3.Visible = false;
                    x5_3 = -200;
                    a5_3.Location = new Point(315, x5_3);

                    n5.Stop();

                }
            }
            if (beatcounter5 == 4)
            {
                if (hitcounter5 == 0)
                {
                    a5_1.Visible = true;
                    x5_1 += 3080 / 577;
                    a5_1.Location = new Point(315, x5_1);
                }
                if (hitcounter5 == 1)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);
                }


                if (watch5_1.ElapsedMilliseconds > 15)
                {
                    a5_2.Visible = true;
                    x5_2 += 3080 / 577;
                    a5_2.Location = new Point(315, x5_2);
                }
                watch5_1 = Stopwatch.StartNew();
                if (hitcounter5 == 2)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);

                }
                if (watch5_2.ElapsedMilliseconds > 15)
                {
                    a5_3.Visible = true;
                    x5_3 += 3080 / 577;
                    a5_3.Location = new Point(315, x5_3);
                }
                watch5_2 = Stopwatch.StartNew();

                if (hitcounter5 == 3)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);

                    a5_3.Visible = false;
                    x5_3 = -200;
                    a5_3.Location = new Point(315, x5_3);
                }

                if (watch5_3.ElapsedMilliseconds > 15)
                {
                    a5_4.Visible = true;
                    x5_4 += 3080 / 577;
                    a5_4.Location = new Point(315, x5_4);
                }
                if (hitcounter5 == 4)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);

                    a5_3.Visible = false;
                    x5_3 = -200;
                    a5_3.Location = new Point(315, x5_3);

                    a5_4.Visible = false;
                    x5_4 = -300;
                    a5_4.Location = new Point(315, x5_4);
                    n5.Stop();
                }
            }
            if (beatcounter5 == 5)
            {
                if (hitcounter5 == 0)
                {
                    a5_1.Visible = true;
                    x5_1 += 3080 / 577;
                    a5_1.Location = new Point(315, x5_1);
                }
                if (hitcounter5 == 1)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);
                }


                if (watch5_1.ElapsedMilliseconds > 15)
                {
                    a5_2.Visible = true;
                    x5_2 += 3080 / 577;
                    a5_2.Location = new Point(315, x5_2);
                }
                watch5_1 = Stopwatch.StartNew();
                if (hitcounter5 == 2)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);
                }
                if (watch5_2.ElapsedMilliseconds > 15)
                {
                    a5_3.Visible = true;
                    x5_3 += 3080 / 577;
                    a5_3.Location = new Point(315, x5_3);
                }
                watch5_2 = Stopwatch.StartNew();

                if (hitcounter5 == 3)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);

                    a5_3.Visible = false;
                    x5_3 = -200;
                    a5_3.Location = new Point(315, x5_3);
                }

                if (watch5_3.ElapsedMilliseconds > 15)
                {
                    a5_4.Visible = true;
                    x5_4 += 3080 / 577;
                    a5_4.Location = new Point(315, x5_4);
                }
                watch5_3 = Stopwatch.StartNew();
                if (hitcounter5 == 4)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);

                    a5_3.Visible = false;
                    x5_3 = -200;
                    a5_3.Location = new Point(315, x5_3);

                    a5_4.Visible = false;
                    x5_4 = -300;
                    a5_4.Location = new Point(315, x5_4);
                }

                if (watch5_4.ElapsedMilliseconds > 15)
                {
                    a5_5.Visible = true;
                    x5_5 += 3080 / 577;
                    a5_5.Location = new Point(315, x5_5);
                }
                watch5_4 = Stopwatch.StartNew();

                if (hitcounter5 == 5)
                {
                    a5_1.Visible = false;
                    x5_1 = 0;
                    a5_1.Location = new Point(315, x5_1);

                    a5_2.Visible = false;
                    x5_2 = -100;
                    a5_2.Location = new Point(315, x5_2);

                    a5_3.Visible = false;
                    x5_3 = -200;
                    a5_3.Location = new Point(315, x5_3);

                    a5_4.Visible = false;
                    x5_4 = -300;
                    a5_4.Location = new Point(315, x5_4);

                    a5_5.Visible = false;
                    x5_5 = -400;
                    a5_5.Location = new Point(315, x5_5);
                    n5.Stop();
                }
            }
            if (a5_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x5_1 = 0;

                a5_1.Visible = false;
                indi1.Visible = false;
                a5_1.Location = new Point(12, x1_1);
                misscounter += 1;
                hitcounter5 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss5");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a5_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x5_2 = -100;

                a5_2.Visible = false;
                indi1.Visible = false;
                a5_2.Location = new Point(12, x1_2);
                misscounter += 1;
                hitcounter5 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss5");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a5_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x5_3 = -200;

                a5_3.Visible = false;
                indi1.Visible = false;
                a5_3.Location = new Point(12, x1_3);
                misscounter += 1;
                hitcounter5 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss5");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a5_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x5_4 = -300;

                a5_4.Visible = false;
                indi1.Visible = false;
                a5_4.Location = new Point(12, x1_4);
                misscounter += 1;
                hitcounter5 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss5");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a5_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x5_5 = -400;

                a5_5.Visible = false;
                indi1.Visible = false;
                a5_5.Location = new Point(12, x1_5);
                misscounter += 1;
                hitcounter5 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss5");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
        }

        private void n6_Tick(object sender, EventArgs e)
        {

            if (energybar1.Value <= 0)
            {
                energybar1.Value = 0;
            }
            if (beatcounter6 == 1)
            {
                if (hitcounter6 == 0)
                {
                    a6_1.Visible = true;
                    x6_1 += 3080 / 577;
                    a6_1.Location = new Point(389, x6_1);
                }
                if (hitcounter6 == 1)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);
                    n6.Stop();
                }
            }
            if (beatcounter6 == 2)
            {
                if (hitcounter6 == 0)
                {
                    a6_1.Visible = true;
                    x6_1 += 3080 / 577;
                    a6_1.Location = new Point(389, x6_1);
                }
                if (watch6_1.ElapsedMilliseconds > 15)
                {
                    a6_2.Visible = true;
                    x6_2 += 3080 / 577;
                    a6_2.Location = new Point(389, x6_2);
                }
                watch6_1 = Stopwatch.StartNew();
                if (hitcounter6 == 2)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);
                    n6.Stop();
                }


            }
            if (beatcounter6 == 3)
            {
                if (hitcounter6 == 0)
                {
                    a6_1.Visible = true;
                    x6_1 += 3080 / 577;
                    a6_1.Location = new Point(389, x6_1);
                }
                if (hitcounter6 == 1)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);
                }


                if (watch6_1.ElapsedMilliseconds > 15)
                {
                    a6_2.Visible = true;
                    x6_2 += 3080 / 577;
                    a6_2.Location = new Point(389, x6_2);
                }
                watch6_1 = Stopwatch.StartNew();
                if (hitcounter6 == 2)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);
                }
                if (watch6_2.ElapsedMilliseconds > 15)
                {
                    a6_3.Visible = true;
                    x6_3 += 3080 / 577;
                    a6_3.Location = new Point(389, x6_3);
                }
                watch6_2 = Stopwatch.StartNew();

                if (hitcounter6 == 3)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);

                    a6_3.Visible = false;
                    x6_3 = -200;
                    a6_3.Location = new Point(389, x6_3);

                    n6.Stop();

                }
            }
            if (beatcounter6 == 4)
            {
                if (hitcounter6 == 0)
                {
                    a6_1.Visible = true;
                    x6_1 += 3080 / 577;
                    a6_1.Location = new Point(389, x6_1);
                }
                if (hitcounter6 == 1)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);
                }


                if (watch6_1.ElapsedMilliseconds > 15)
                {
                    a6_2.Visible = true;
                    x6_2 += 3080 / 577;
                    a6_2.Location = new Point(389, x6_2);
                }
                watch6_1 = Stopwatch.StartNew();
                if (hitcounter6 == 2)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);

                }
                if (watch6_2.ElapsedMilliseconds > 15)
                {
                    a6_3.Visible = true;
                    x6_3 += 3080 / 577;
                    a6_3.Location = new Point(389, x6_3);
                }
                watch6_2 = Stopwatch.StartNew();

                if (hitcounter6 == 3)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);

                    a6_3.Visible = false;
                    x6_3 = -200;
                    a6_3.Location = new Point(389, x6_3);
                }

                if (watch6_3.ElapsedMilliseconds > 15)
                {
                    a6_4.Visible = true;
                    x6_4 += 3080 / 577;
                    a6_4.Location = new Point(389, x6_4);
                }
                if (hitcounter6 == 4)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);

                    a6_3.Visible = false;
                    x6_3 = -200;
                    a6_3.Location = new Point(389, x6_3);

                    a6_4.Visible = false;
                    x6_4 = -300;
                    a6_4.Location = new Point(389, x6_4);
                    n6.Stop();
                }
            }
            if (beatcounter6 == 5)
            {
                if (hitcounter6 == 0)
                {
                    a6_1.Visible = true;
                    x6_1 += 3080 / 577;
                    a6_1.Location = new Point(389, x6_1);
                }
                if (hitcounter6 == 1)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);
                }


                if (watch6_1.ElapsedMilliseconds > 15)
                {
                    a6_2.Visible = true;
                    x6_2 += 3080 / 577;
                    a6_2.Location = new Point(389, x6_2);
                }
                watch6_1 = Stopwatch.StartNew();
                if (hitcounter6 == 2)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);
                }
                if (watch6_2.ElapsedMilliseconds > 15)
                {
                    a6_3.Visible = true;
                    x6_3 += 3080 / 577;
                    a6_3.Location = new Point(389, x6_3);
                }
                watch6_2 = Stopwatch.StartNew();

                if (hitcounter6 == 3)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);

                    a6_3.Visible = false;
                    x6_3 = -200;
                    a6_3.Location = new Point(389, x6_3);
                }

                if (watch6_3.ElapsedMilliseconds > 15)
                {
                    a6_4.Visible = true;
                    x6_4 += 3080 / 577;
                    a6_4.Location = new Point(389, x6_4);
                }
                watch6_3 = Stopwatch.StartNew();
                if (hitcounter6 == 4)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);

                    a6_3.Visible = false;
                    x6_3 = -200;
                    a6_3.Location = new Point(389, x6_3);

                    a6_4.Visible = false;
                    x6_4 = -300;
                    a6_4.Location = new Point(389, x6_4);
                }

                if (watch6_4.ElapsedMilliseconds > 15)
                {
                    a6_5.Visible = true;
                    x6_5 += 3080 / 577;
                    a6_5.Location = new Point(389, x6_5);
                }
                watch6_4 = Stopwatch.StartNew();

                if (hitcounter6 == 5)
                {
                    a6_1.Visible = false;
                    x6_1 = 0;
                    a6_1.Location = new Point(389, x6_1);

                    a6_2.Visible = false;
                    x6_2 = -100;
                    a6_2.Location = new Point(389, x6_2);

                    a6_3.Visible = false;
                    x6_3 = -200;
                    a6_3.Location = new Point(389, x6_3);

                    a6_4.Visible = false;
                    x6_4 = -300;
                    a6_4.Location = new Point(389, x6_4);

                    a6_5.Visible = false;
                    x6_5 = -400;
                    a6_5.Location = new Point(389, x6_5);
                    n6.Stop();
                }
            }
            if (a6_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x6_1 = 0;

                a6_1.Visible = false;
                indi1.Visible = false;
                a6_1.Location = new Point(12, x1_1);
                misscounter += 1;
                hitcounter6 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss6");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a6_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x6_2 = -100;

                a6_2.Visible = false;
                indi1.Visible = false;
                a6_2.Location = new Point(12, x1_2);
                misscounter += 1;
                hitcounter6 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss6");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a6_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x6_3 = -200;

                a6_3.Visible = false;
                indi1.Visible = false;
                a6_3.Location = new Point(12, x1_3);
                misscounter += 1;
                hitcounter6 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss6");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a6_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x6_4 = -300;

                a6_4.Visible = false;
                indi1.Visible = false;
                a6_4.Location = new Point(12, x1_4);
                misscounter += 1;
                hitcounter6 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss6");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a6_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x6_5 = -400;

                a6_5.Visible = false;
                indi1.Visible = false;
                a6_5.Location = new Point(12, x1_5);
                misscounter += 1;
                hitcounter6 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss6");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
        }

        private void n7_Tick(object sender, EventArgs e)
        {
            if (energybar1.Value <= 0)
            {
                energybar1.Value = 0;
            }

            if (beatcounter7 == 1)
            {
                if (hitcounter7 == 0)
                {
                    a7_1.Visible = true;
                    x7_1 += 3080 / 577;
                    a7_1.Location = new Point(465, x7_1);
                }
                if (hitcounter7 == 1)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);
                    n7.Stop();
                }
            }
            if (beatcounter7 == 2)
            {
                if (hitcounter7 == 0)
                {
                    a7_1.Visible = true;
                    x7_1 += 3080 / 577;
                    a7_1.Location = new Point(465, x7_1);
                }
                if (watch7_1.ElapsedMilliseconds > 15)
                {
                    a7_2.Visible = true;
                    x7_2 += 3080 / 577;
                    a7_2.Location = new Point(465, x7_2);
                }
                watch7_1 = Stopwatch.StartNew();
                if (hitcounter7 == 2)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x7_2);
                    n7.Stop();
                }


            }
            if (beatcounter7 == 3)
            {
                if (hitcounter7 == 0)
                {
                    a7_1.Visible = true;
                    x7_1 += 3080 / 577;
                    a7_1.Location = new Point(465, x7_1);
                }
                if (hitcounter7 == 1)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);
                }


                if (watch7_1.ElapsedMilliseconds > 15)
                {
                    a7_2.Visible = true;
                    x7_2 += 3080 / 577;
                    a7_2.Location = new Point(465, x7_2);
                }
                watch7_1 = Stopwatch.StartNew();
                if (hitcounter7 == 2)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x1_2);
                }
                if (watch7_2.ElapsedMilliseconds > 15)
                {
                    a7_3.Visible = true;
                    x7_3 += 3080 / 577;
                    a7_3.Location = new Point(465, x7_3);
                }
                watch7_2 = Stopwatch.StartNew();

                if (hitcounter7 == 3)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x7_2);

                    a7_3.Visible = false;
                    x7_3 = -200;
                    a7_3.Location = new Point(465, x7_3);

                    n7.Stop();

                }
            }
            if (beatcounter7 == 4)
            {
                if (hitcounter7 == 0)
                {
                    a7_1.Visible = true;
                    x7_1 += 3080 / 577;
                    a7_1.Location = new Point(465, x7_1);
                }
                if (hitcounter7 == 1)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);
                }


                if (watch7_1.ElapsedMilliseconds > 15)
                {
                    a7_2.Visible = true;
                    x7_2 += 3080 / 577;
                    a7_2.Location = new Point(465, x7_2);
                }
                watch7_1 = Stopwatch.StartNew();
                if (hitcounter7 == 2)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x7_2);

                }
                if (watch7_2.ElapsedMilliseconds > 15)
                {
                    a7_3.Visible = true;
                    x7_3 += 3080 / 577;
                    a7_3.Location = new Point(465, x7_3);
                }
                watch7_2 = Stopwatch.StartNew();

                if (hitcounter7 == 3)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x7_2);

                    a7_3.Visible = false;
                    x7_3 = -200;
                    a7_3.Location = new Point(465, x7_3);
                }

                if (watch7_3.ElapsedMilliseconds > 15)
                {
                    a7_4.Visible = true;
                    x7_4 += 3080 / 577;
                    a7_4.Location = new Point(465, x7_4);
                }
                if (hitcounter7 == 4)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x7_2);

                    a7_3.Visible = false;
                    x7_3 = -200;
                    a7_3.Location = new Point(465, x7_3);

                    a7_4.Visible = false;
                    x7_4 = -300;
                    a7_4.Location = new Point(465, x7_4);
                    n7.Stop();
                }
            }
            if (beatcounter7 == 5)
            {
                if (hitcounter7 == 0)
                {
                    a7_1.Visible = true;
                    x7_1 += 3080 / 577;
                    a7_1.Location = new Point(465, x7_1);
                }
                if (hitcounter7 == 1)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);
                }


                if (watch7_1.ElapsedMilliseconds > 15)
                {
                    a7_2.Visible = true;
                    x7_2 += 3080 / 577;
                    a7_2.Location = new Point(465, x7_2);
                }
                watch7_1 = Stopwatch.StartNew();
                if (hitcounter7 == 2)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x7_2);
                }
                if (watch7_2.ElapsedMilliseconds > 15)
                {
                    a7_3.Visible = true;
                    x7_3 += 3080 / 577;
                    a7_3.Location = new Point(465, x7_3);
                }
                watch7_2 = Stopwatch.StartNew();

                if (hitcounter7 == 3)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x7_2);

                    a7_3.Visible = false;
                    x7_3 = -200;
                    a7_3.Location = new Point(465, x7_3);
                }

                if (watch7_3.ElapsedMilliseconds > 15)
                {
                    a7_4.Visible = true;
                    x7_4 += 3080 / 577;
                    a7_4.Location = new Point(465, x7_4);
                }
                watch7_3 = Stopwatch.StartNew();
                if (hitcounter7 == 4)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x7_2);

                    a7_3.Visible = false;
                    x7_3 = -200;
                    a7_3.Location = new Point(465, x7_3);

                    a7_4.Visible = false;
                    x7_4 = -300;
                    a7_4.Location = new Point(465, x7_4);
                }

                if (watch7_4.ElapsedMilliseconds > 15)
                {
                    a7_5.Visible = true;
                    x7_5 += 3080 / 577;
                    a7_5.Location = new Point(465, x7_5);
                }
                watch7_4 = Stopwatch.StartNew();

                if (hitcounter7 == 5)
                {
                    a7_1.Visible = false;
                    x7_1 = 0;
                    a7_1.Location = new Point(465, x7_1);

                    a7_2.Visible = false;
                    x7_2 = -100;
                    a7_2.Location = new Point(465, x7_2);

                    a7_3.Visible = false;
                    x7_3 = -200;
                    a7_3.Location = new Point(465, x7_3);

                    a7_4.Visible = false;
                    x7_4 = -300;
                    a7_4.Location = new Point(465, x7_4);

                    a7_5.Visible = false;
                    x7_5 = -400;
                    a7_5.Location = new Point(465, x7_5);
                    n7.Stop();
                }
            }
            if (a7_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x7_1 = 0;

                a7_1.Visible = false;
                indi1.Visible = false;
                a7_1.Location = new Point(12, x1_1);
                misscounter += 1;
                hitcounter7 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss7");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               

            }
            if (a7_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x7_2 = -100;

                a7_2.Visible = false;
                indi1.Visible = false;
                a7_2.Location = new Point(12, x1_2);
                misscounter += 1;
                hitcounter7 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss7");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a7_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x7_3 = -200;

                a7_3.Visible = false;
                indi1.Visible = false;
                a7_3.Location = new Point(12, x1_3);
                misscounter += 1;
                hitcounter7 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss7");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a7_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x7_4 = -300;

                a7_4.Visible = false;
                indi1.Visible = false;
                a7_4.Location = new Point(12, x1_4);
                misscounter += 1;
                hitcounter7 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss7");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a7_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x7_5 = -400;

                a7_5.Visible = false;
                indi1.Visible = false;
                a7_5.Location = new Point(12, x1_5);
                misscounter += 1;
                hitcounter7 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss7");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
        }

        private void n8_Tick(object sender, EventArgs e)
        {

            if (energybar1.Value <= 0)
            {
                energybar1.Value = 0;
            }
            if (beatcounter8 == 1)
            {
                if (hitcounter8 == 0)
                {
                    a8_1.Visible = true;
                    x8_1 += 3080 / 577;
                    a8_1.Location = new Point(541, x8_1);
                }
                if (hitcounter8 == 1)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);
                    n8.Stop();
                }
            }
            if (beatcounter8 == 2)
            {
                if (hitcounter8 == 0)
                {
                    a8_1.Visible = true;
                    x8_1 += 3080 / 577;
                    a8_1.Location = new Point(541, x8_1);
                }
                if (watch8_1.ElapsedMilliseconds > 15)
                {
                    a8_2.Visible = true;
                    x8_2 += 3080 / 577;
                    a8_2.Location = new Point(541, x8_2);
                }
                watch8_1 = Stopwatch.StartNew();
                if (hitcounter8 == 2)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);
                    n8.Stop();
                }


            }
            if (beatcounter8 == 3)
            {
                if (hitcounter8 == 0)
                {
                    a8_1.Visible = true;
                    x8_1 += 3080 / 577;
                    a8_1.Location = new Point(541, x8_1);
                }
                if (hitcounter8 == 1)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);
                }


                if (watch8_1.ElapsedMilliseconds > 15)
                {
                    a8_2.Visible = true;
                    x8_2 += 3080 / 577;
                    a8_2.Location = new Point(541, x8_2);
                }
                watch8_1 = Stopwatch.StartNew();
                if (hitcounter8 == 2)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);
                }
                if (watch8_2.ElapsedMilliseconds > 15)
                {
                    a8_3.Visible = true;
                    x8_3 += 3080 / 577;
                    a8_3.Location = new Point(541, x8_3);
                }
                watch8_2 = Stopwatch.StartNew();

                if (hitcounter8 == 3)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);

                    a8_3.Visible = false;
                    x8_3 = -200;
                    a8_3.Location = new Point(541, x8_3);

                    n8.Stop();

                }
            }
            if (beatcounter8 == 4)
            {
                if (hitcounter8 == 0)
                {
                    a8_1.Visible = true;
                    x8_1 += 3080 / 577;
                    a8_1.Location = new Point(541, x8_1);
                }
                if (hitcounter8 == 1)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);
                }


                if (watch8_1.ElapsedMilliseconds > 15)
                {
                    a8_2.Visible = true;
                    x8_2 += 3080 / 577;
                    a8_2.Location = new Point(541, x8_2);
                }
                watch8_1 = Stopwatch.StartNew();
                if (hitcounter8 == 2)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);

                }
                if (watch8_2.ElapsedMilliseconds > 15)
                {
                    a8_3.Visible = true;
                    x8_3 += 3080 / 577;
                    a8_3.Location = new Point(541, x8_3);
                }
                watch8_2 = Stopwatch.StartNew();

                if (hitcounter8 == 3)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);

                    a8_3.Visible = false;
                    x8_3 = -200;
                    a8_3.Location = new Point(541, x8_3);
                }

                if (watch8_3.ElapsedMilliseconds > 15)
                {
                    a8_4.Visible = true;
                    x8_4 += 3080 / 577;
                    a8_4.Location = new Point(541, x8_4);
                }
                if (hitcounter8 == 4)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);

                    a8_3.Visible = false;
                    x8_3 = -200;
                    a8_3.Location = new Point(541, x8_3);

                    a8_4.Visible = false;
                    x8_4 = -300;
                    a8_4.Location = new Point(541, x8_4);
                    n8.Stop();
                }
            }
            if (beatcounter8 == 5)
            {
                if (hitcounter8 == 0)
                {
                    a8_1.Visible = true;
                    x8_1 += 3080 / 577;
                    a8_1.Location = new Point(541, x8_1);
                }
                if (hitcounter8 == 1)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);
                }


                if (watch8_1.ElapsedMilliseconds > 15)
                {
                    a8_2.Visible = true;
                    x8_2 += 3080 / 577;
                    a8_2.Location = new Point(541, x8_2);
                }
                watch8_1 = Stopwatch.StartNew();
                if (hitcounter8 == 2)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);
                }
                if (watch8_2.ElapsedMilliseconds > 15)
                {
                    a8_3.Visible = true;
                    x8_3 += 3080 / 577;
                    a8_3.Location = new Point(541, x8_3);
                }
                watch8_2 = Stopwatch.StartNew();

                if (hitcounter8 == 3)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);

                    a8_3.Visible = false;
                    x8_3 = -200;
                    a8_3.Location = new Point(541, x8_3);
                }

                if (watch8_3.ElapsedMilliseconds > 15)
                {
                    a8_4.Visible = true;
                    x8_4 += 3080 / 577;
                    a8_4.Location = new Point(541, x8_4);
                }
                watch8_3 = Stopwatch.StartNew();
                if (hitcounter8 == 4)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);

                    a8_3.Visible = false;
                    x8_3 = -200;
                    a8_3.Location = new Point(541, x8_3);

                    a8_4.Visible = false;
                    x8_4 = -300;
                    a8_4.Location = new Point(541, x8_4);
                }

                if (watch8_4.ElapsedMilliseconds > 15)
                {
                    a8_5.Visible = true;
                    x8_5 += 3080 / 577;
                    a8_5.Location = new Point(541, x8_5);
                }
                watch8_4 = Stopwatch.StartNew();

                if (hitcounter8 == 5)
                {
                    a8_1.Visible = false;
                    x8_1 = 0;
                    a8_1.Location = new Point(541, x8_1);

                    a8_2.Visible = false;
                    x8_2 = -100;
                    a8_2.Location = new Point(541, x8_2);

                    a8_3.Visible = false;
                    x8_3 = -200;
                    a8_3.Location = new Point(541, x8_3);

                    a8_4.Visible = false;
                    x8_4 = -300;
                    a8_4.Location = new Point(541, x8_4);

                    a8_5.Visible = false;
                    x8_5 = -400;
                    a8_5.Location = new Point(541, x8_5);
                    n8.Stop();
                }
            }
            if (a8_1.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x8_1 = 0;

                a8_1.Visible = false;
                indi1.Visible = false;
                a8_1.Location = new Point(12, x1_1);
                misscounter += 1;
                hitcounter8 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss8");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a8_2.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x8_2 = -100;

                a8_2.Visible = false;
                indi1.Visible = false;
                a8_2.Location = new Point(12, x1_2);
                misscounter += 1;
                hitcounter8 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss8");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a8_3.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x8_3 = -200;

                a8_3.Visible = false;
                indi1.Visible = false;
                a8_3.Location = new Point(12, x1_3);
                misscounter += 1;
                hitcounter8 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss8");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a8_4.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x8_4 = -300;

                a8_4.Visible = false;
                indi1.Visible = false;
                a8_4.Location = new Point(12, x1_4);
                misscounter += 1;
                hitcounter8 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;             
            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss8");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
            if (a8_5.Bounds.IntersectsWith(pnl3.Bounds))
            {
                x8_5 = -400;

                a8_5.Visible = false;
                indi1.Visible = false;
                a8_5.Location = new Point(12, x1_5);
                misscounter += 1;
                hitcounter8 += 1;
                indi1.Visible = true;
                indi1.Text = "Miss";
                onestimercounter = 2;
                combocounter = 0;            
                textdelay = true;
                if (indicatorled == true)
                {
                    try
                    {
                        port1.Open();
                        port1.Write("miss8");
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
                maintimer.Start();
                energyvaluechecker = energybar1.Value - hitdecreasecounter;
                if (energyvaluechecker <= maxenergy && energyvaluechecker > 0 && energymultipliercounter <= 0)
                {
                    energybar1.Value -= hitdecreasecounter;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }

                if (energyvaluechecker < 0 && energymultipliercounter == 0)
                {
                    energybar1.Value = 0;
                    energymultipliercounter = 0;
                    energymulti1.Text = "x" + energymultipliercounter;
                }
                if (energymultipliercounter >= 1 && energymultipliercounter <= maxenergy)
                {
                    energymultipliercounter--;
                    energymulti1.Text = "x" + energymultipliercounter;
                    if (energymultipliercounter < 0)
                    {
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;
                    }
                }
               
            }
        }

        private void buttonscont(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'q' && pausemenuflag==false)
            {
               
                pausetab.Visible = true;
                pausetab.BringToFront();
                pausemenuflag = true;
                mainchoicemenucounter = 1;
                subchoicemenucounter = 0;
                pausemenuhighlight(mainchoicemenucounter);
                n1.Stop();
                n2.Stop();
                n3.Stop();
                n4.Stop();
                n5.Stop();
                n6.Stop();
                n7.Stop();
                n8.Stop(); 
                durations.Stop();
                maintimer.Stop();
                paustimer1.Stop();
            }
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

                if(pausemenuflag == true)
                {
                    
                    if(mainchoicemenucounter >=1 && subchoicemenucounter==0)
                    {
                    mainchoicemenucounter++;
                    pausemenuhighlight(mainchoicemenucounter);
                 
                    if(mainchoicemenucounter>3)
                    {
                        mainchoicemenucounter = 1;
                        pausemenuhighlight(mainchoicemenucounter);
                        //subenterfunction = true;
                    }
                }
                    if(subchoicemenucounter>=1)
                    {
                        subchoicemenucounter++;
                        //subenterfunction = true;
                        subpausemenuhighlight(subchoicemenucounter);
                        
                        if (subchoicemenucounter > 2)
                        {
                            subchoicemenucounter = 1;
                            subpausemenuhighlight(subchoicemenucounter);
                        }
                    }
                }
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
                if (pausemenuflag == true && mainchoicemenucounter == 1)
                {
                    mainchoicemenucounter = 1;
                    pausetab.Visible = false;
                    n1.Stop();
                    n2.Stop();
                    n3.Stop();
                    n4.Stop();
                    n5.Stop();
                    n6.Stop();
                    n7.Stop();
                    n8.Stop();
                    pausetimecounter = 4;
                    pausemenuflag = false;
                    unpause = true;
                    paustimer1.Start();
                    pausedelay = false;
                    maintimer.Stop();
                   
                }
                if (mainchoicemenucounter == 2 && subchoicemenucounter == 0 && enterswitchcounter == 0)
                {
                    lbl1.Visible = true;
                    btnno.Visible = true;
                    btnyes.Visible = true;
                    subchoicemenucounter = 1;
                    enterswitchcounter += 1;
                    subpausemenuhighlight(subchoicemenucounter);
                    lbl1.Text = "Do you really want to restart the tutorial?, \nThe tutorial progress will not be saved.";
                   
                }
                if (mainchoicemenucounter == 3 && subchoicemenucounter==0 && enterswitchcounter==0)
                {
                    lbl1.Visible = true;
                    btnno.Visible = true;
                    btnyes.Visible = true;
                    subchoicemenucounter = 1;
                    enterswitchcounter += 1;
                    subpausemenuhighlight(subchoicemenucounter);
                    lbl1.Text = "Do you really want to quit the tutorial?, \nThe tutorial progress will not be saved.";
                    
                }
                if (lbl1.Text.StartsWith("Do you really want to quit the tutorial?, \nThe tutorial progress will not be saved.") && subchoicemenucounter==1)
                {
                   
                    enterswitchcounter += 1;
                    if (enterswitchcounter > 2)
                    {
                     subchoicemenucounter = 0;
                    pausemenuhighlight(mainchoicemenucounter);
                    enterswitchcounter = 0;
                    }
                }

                if (lbl1.Text.StartsWith("Do you really want to restart the tutorial?, \nThe tutorial progress will not be saved.") && subchoicemenucounter == 1)
                {
                    enterswitchcounter += 1;
                    if (enterswitchcounter > 2)
                    {
                        subchoicemenucounter = 0;
                        pausemenuhighlight(mainchoicemenucounter);
                        enterswitchcounter = 0;
                    }
                    
                }
                if (lbl1.Text.StartsWith("Do you really want to quit the tutorial?, \nThe tutorial progress will not be saved.")  && subchoicemenucounter == 2)
                {
                    enterswitchcounter += 1;
                    if (enterswitchcounter > 2)
                    {
                    durations.Dispose();
                    maintimer.Dispose();
                    paustimer1.Dispose();
                    enterswitchcounter = 0;
                    menu2 b = new menu2();
                    b.Show();
                    b.Focus();
                    this.Close();
                    }
                 }
                if (lbl1.Text.StartsWith("Do you really want to restart the tutorial?, \nThe tutorial progress will not be saved.")  && subchoicemenucounter == 2)
                {

                    enterswitchcounter += 1;
                    if(enterswitchcounter > 2)
                    {
                        mainchoicemenucounter = 1;
                        misscounter = 0;
                        perfectcounter = 0;
                        greatcounter = 0;
                        goodcounter = 0;
                        combocounter = 0;
                        scorecounter = 0;
                        patterncounter = 1;
                        sequencecounter = 1;
                        sequenceloopflag = false;
                        energymultipliercounter = 0;
                        energymulti1.Text = "x" + energymultipliercounter;

                        pausetab.Visible = false;
                        n1.Stop();
                        n2.Stop();
                        n3.Stop();
                        n4.Stop();
                        n5.Stop();
                        n6.Stop();
                        n7.Stop();
                        n8.Stop();
                        a1_1.Visible = false;
                        a1_2.Visible = false;
                        a1_3.Visible = false;
                        a1_4.Visible = false;
                        a1_5.Visible = false;

                        a2_1.Visible = false;
                        a2_2.Visible = false;
                        a2_3.Visible = false;
                        a2_4.Visible = false;
                        a2_5.Visible = false;

                        a3_1.Visible = false;
                        a3_2.Visible = false;
                        a3_3.Visible = false;
                        a3_4.Visible = false;
                        a3_5.Visible = false;

                        a4_1.Visible = false;
                        a4_2.Visible = false;
                        a4_3.Visible = false;
                        a4_4.Visible = false;
                        a4_5.Visible = false;

                        a5_1.Visible = false;
                        a5_2.Visible = false;
                        a5_3.Visible = false;
                        a5_4.Visible = false;
                        a5_5.Visible = false;

                        a6_1.Visible = false;
                        a6_2.Visible = false;
                        a6_3.Visible = false;
                        a6_4.Visible = false;
                        a6_5.Visible = false;

                        a7_1.Visible = false;
                        a7_2.Visible = false;
                        a7_3.Visible = false;
                        a7_4.Visible = false;
                        a7_5.Visible = false;

                        a8_1.Visible = false;
                        a8_2.Visible = false;
                        a8_3.Visible = false;
                        a8_4.Visible = false;
                        a8_5.Visible = false;

                        x1_1 = 0;
                        x1_2 = -100;
                        x1_3 = -200;
                        x1_4 = -300;
                        x1_5 = -400;


                        x2_1 = 0;
                        x2_2 = -100;
                        x2_3 = -200;
                        x2_4 = -300;
                        x2_5 = -400;



                        x3_1 = 0;
                        x3_2 = -100;
                        x3_3 = -200;
                        x3_4 = -300;
                        x3_5 = -400;

                        x4_1 = 0;
                        x4_2 = -100;
                        x4_3 = -200;
                        x4_4 = -300;
                        x4_5 = -400;

                        x5_1 = 0;
                        x5_2 = -100;
                        x5_3 = -200;
                        x5_4 = -300;
                        x5_5 = -400;

                        x6_1 = 0;
                        x6_2 = -100;
                        x6_3 = -200;
                        x6_4 = -300;
                        x6_5 = -400;

                        x7_1 = 0;
                        x7_2 = -100;
                        x7_3 = -200;
                        x7_4 = -300;
                        x7_5 = -400;

                        x8_1 = 0;
                        x8_2 = -100;
                        x8_3 = -200;
                        x8_4 = -300;
                        x8_5 = -400;
                        enterswitchcounter = 0;
                        restarttimercounter = 4;
                        pausemenuflag = false;
                        unpause = true;
                        restartflag = true;
                        paustimer1.Start();
                    }
                }

                
                
            }
            if (e.KeyChar == 'b')
            {
                buttonactive5();
                a5.BackgroundImage = drumtuto_main.Properties.Resources.b5activated;
                b5.Visible = true;

            }
            if (e.KeyChar == 'n')
            {
                buttonactive6();
                a6.BackgroundImage = drumtuto_main.Properties.Resources.b6activated;
                b6.Visible = true;

            }
            if (e.KeyChar == 'm')
            {
                buttonactive7();
                a7.BackgroundImage = drumtuto_main.Properties.Resources.b7activated;
                b7.Visible = true;

            }
            if (e.KeyChar == ',')
            {
                buttonactive8();
                a8.BackgroundImage = drumtuto_main.Properties.Resources.b8activated;
                b8.Visible = true;

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
            if (e.KeyCode == Keys.B)
            {
                a5.BackgroundImage = drumtuto_main.Properties.Resources.b5inactives;
                b5.Visible = false;
            }
            if (e.KeyCode == Keys.N)
            {
                a6.BackgroundImage = drumtuto_main.Properties.Resources.b6inactives;
                b6.Visible = false;
            }
            if (e.KeyCode == Keys.M)
            {
                a7.BackgroundImage = drumtuto_main.Properties.Resources.b7inactives;
                b7.Visible = false;
            }
            if (e.KeyCode == Keys.Oemcomma)
            {
                a8.BackgroundImage = drumtuto_main.Properties.Resources.b8inactives;
                b8.Visible = false;
            }
        }

        private void maintimer_Tick(object sender, EventArgs e)
        {

            if (textdelay == true && basicbeats2flag == true && sequencecounter == 1)
            {
                onestimercounter--;
                if (onestimercounter <= 0)
                {
                    n2.Start();
                    textdelay = false;
                    maintimer.Stop();
                    onestimercounter = 4;
                }
            }
            if (textdelay == true && basicbeats2flag == true && sequencecounter == 2 )
            {
                onestimercounter--;
                if (onestimercounter <= 0)
                {
                    n2.Start();
                    textdelay = false;
                    maintimer.Stop();
                    onestimercounter = 4;
                }
            }
           
            if(textdelay == true && basicbeats1flag == true && sequencecounter == 1)
            {
                onestimercounter--;
                if(onestimercounter <= 0)
                {
                    n1.Start();
                    n2.Start();
                    textdelay = false;
                    maintimer.Stop();
                    onestimercounter = 4;
                }
            }
           
            if(textdelay == true) //hardware off light implmentation
            {
                onestimercounter--;
            if(onestimercounter == 0)
            {
                if(indicatorled == true)
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
                indi1.Location = new Point(145, 283);
                indi1.Visible = false;
                maintimer.Stop();
                textdelay = false;
                onestimercounter = 4;
            }

            }
            if(pausedelay == true)
            {
                onestimercounter--;
                sticks.Play();
                indi1.Text = onestimercounter.ToString();
                indi1.Location = new Point(251, 280);
                indi1.Visible = true;

                indi1.BringToFront();

                if (onestimercounter >= 4)
                {
                    durations.Stop();
                }

                if (onestimercounter == 0)
                {
                    durations.Start();
                    sticks.Stop();
                    indi1.Location = new Point(145, 283);
                    indi1.Visible = false;
                    //textstuto();
                    maintimer.Stop();
                    pausedelay = false;
                    onestimercounter = 4;
                }

            }

    
        }

        private void paustimer1_Tick(object sender, EventArgs e)
        {
 
            if (unpause == true && pausedelay == false)
            {

                pausetimecounter--;
                sticks.Play();
                indi1.Text = pausetimecounter.ToString();
                indi1.Location = new Point(251, 280);
                indi1.Visible = true;


                if (pausetimecounter == 0)
                {
                    
                    Tutorials();
                    sticks.Stop();
                    indi1.Location = new Point(145, 283);
                    indi1.Visible = false;
                    //textstuto();
                  
                    pausedelay = false;
                    unpause = false;
                    pausetimecounter = 4; 
                    durations.Start();
                  
                    paustimer1.Stop();
                }
            }
            if (unpause == true && restartflag == true)
            {

                restarttimercounter--;
                sticks.Play();
                indi1.Text = restarttimercounter.ToString();
                indi1.Location = new Point(251, 280);
                indi1.Visible = true;


                if (restarttimercounter == 0)
                {    
                    restarttimercounter = 4;
                    sequencecounter = 1;
                    patterncounter = 1;
                    durations.Start();
                    sticks.Stop();
                    indi1.Location = new Point(145, 283);
                    indi1.Visible = false;
                    //textstuto();

                    pausedelay = false;
                    unpause = false;
                   
                    paustimer1.Stop();
                }
            }
        }

    
    }
}

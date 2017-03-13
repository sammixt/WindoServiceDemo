using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleService
{
    class Scheduler
    {
        System.Timers.Timer oTimer = null;
        double interval = 20000;
     
        public void Start()
        {
            oTimer = new System.Timers.Timer(interval);
            oTimer.AutoReset = true;
            oTimer.Enabled = true;
            oTimer.Start();

            oTimer.Elapsed += new System.Timers.ElapsedEventHandler(oTimer_Elapsed);

        }

        private void oTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            FIleCreation();
        }

        void FIleCreation()
        {
            string sFilePath = @"C:\Users\scezeala\Documents\SampleService\SampleFile.txt";
            string sDateTime = DateTime.Now.ToString();

            using (StreamWriter oFileWrite = new StreamWriter(sFilePath, true))
            {
                oFileWrite.WriteLine(sDateTime);
            }
            
        }
    }
}

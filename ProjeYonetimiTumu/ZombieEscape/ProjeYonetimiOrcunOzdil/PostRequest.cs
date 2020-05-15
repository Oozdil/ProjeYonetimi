using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeYonetimiOrcunOzdil
{
    public class PostRequest
    {
       
        public PostRequest()
        {
            
        }





        SetupConfig setupConfig = new SetupConfig();
        internal object ZombieTrainRequest(string sensorsActive)
        {
            string fileName = setupConfig.PythonPath;
            string arguments = setupConfig.ZombieModelCreator+sensorsActive;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        internal object ZombiePredictionRequest(string _predictionData)
        {
            
            string data= _predictionData.Replace(",",".").Replace(";",",");

            string fileName = setupConfig.PythonPath;
            string arguments = setupConfig.ZombieModelPredictor + data;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }
    }
}

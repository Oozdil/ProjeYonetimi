using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetimiOrcunOzdil
{
    public class SetupConfig
    {
      
        public string RPSUserModelPath { get; set; }
        public string RPSDefaultDataPath { get; set; }
        public string RPSImageToPredict { get; set; }

        public string RPSModelCreator { get; set; }
        public string RPSModelPredictor { get; set; }
        public string PythonPath { get; set; }

        public SetupConfig()
        {
            RPSDefaultDataPath = "PythonServer/RockPaperSic/gnb_RPSDefault.sav";
            RPSUserModelPath = "PythonServer/RockPaperSic/gnb_RPS.sav";
            RPSImageToPredict = @"PythonServer\RockPaperSic\dataset\single_prediction\" + "ImageToPredict.jpg";

            RPSModelCreator = "PythonServer\\RockPaperSic\\createCnnUser.py ";
            RPSModelPredictor = "PythonServer\\RockPaperSic\\RPS_Predictor.py ";
            PythonPath = "C:\\Python36\\python.exe";
        }
    }
}

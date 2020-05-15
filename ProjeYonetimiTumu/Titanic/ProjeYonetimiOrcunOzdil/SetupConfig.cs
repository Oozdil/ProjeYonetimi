using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetimiOrcunOzdil
{
    public class SetupConfig
    {

        public string TitanicUserDataPath { get; set; }
        public string TitanicDefaultDataPath { get; set; }
        public string TitanicUserModelPath { get; set; }
        public string TitanicDefaultModelPath { get; set; }
        public string TitanicModelCreator { get; set; }
        public string TitanicModelPredictor { get; set; }
        public string PythonPath { get; set; }

        public SetupConfig()
        {

            TitanicUserDataPath = "PythonServer/Titanic/TitanicUserValues.csv";
            TitanicDefaultDataPath = "PythonServer/Titanic/TitanicDefaultValues.csv";
            TitanicUserModelPath = "PythonServer/Titanic/gnb.sav";
            TitanicDefaultModelPath = "PythonServer/Titanic/gnbDefault.sav";
            TitanicModelCreator = "PythonServer\\Titanic\\TitanicModelcreator.py ";
            TitanicModelPredictor = "PythonServer\\Titanic\\TitanicPredictorServer.py ";
            PythonPath = "C:\\Python36\\python.exe";

        }
    }
}

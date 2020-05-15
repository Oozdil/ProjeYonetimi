using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeYonetimiOrcunOzdil
{
    public class SetupConfig
    {
     

        public string ZombieDefaultDataPath { get; set; }
        public List<Double> ZombieMinMax { get; set; }

        public string ZombieModelCreator { get; set; }
        public string ZombieModelPredictor { get; set; }
        public string PythonPath { get; set; }
        public SetupConfig()
        {
            ZombieModelCreator = "PythonServer\\Zombie\\ZombieRoomsModelcreatorWithArgs.py ";
            ZombieModelPredictor = "PythonServer\\Zombie\\ZombieRoomPredictor.py ";
            PythonPath = "C:\\Python36\\python.exe";

            ZombieDefaultDataPath = "PythonServer/Zombie/RoomData.csv";
            ZombieMinMax = new List<double>(){
            38000,159000,
            800,15800,
            0,16600,
            6000,658000,
            90,6110,
            10000,2890000,
            60000,4400000,
            9871,10390,
            27200,40100,
            2200,20000,
            80000,149000,
            30000,90000
            };


          

        }
    }
}

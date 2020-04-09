/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace Hoodstrats.Core
{
    public static class SaveController
    {
        //this will create the file in the program's folder
        static string _savePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/FarmLog.txt";
        static string _dataToSave;
        static DateTime _currentDate;

        public static void GetInfo(string elapsedTime, string farmName, string runs, string drops, string kept, string percent)
        {
            if (DateTime.Now.Day != _currentDate.Day)
            {
                _currentDate = DateTime.Now;
                _dataToSave = DateTime.Now.ToString("MM/dd/yyyy") + "\n" + "Farming:" + farmName + "  " + "Elapsed Time:" + elapsedTime + "\n" + "Runs:" + runs + "  " + "Drops:" + drops + "  " + "Keepers:" + kept + "  " + "Percent:" + percent + "%" + "\n\n";
            }
            else
            {
                _dataToSave = "Farming:" + farmName + "  " + "Elapsed Time:" + elapsedTime + "\n" + "Runs:" + runs + "  " + "Drops:" + drops + "  " + "Keepers:" + kept + "  " + "Percent:" + percent + "%" + "\n\n";
            }

            SaveFarm();
        }
        public static void SaveFarm()
        {
            if (!File.Exists(_savePath))
            {
                File.WriteAllText(_savePath, "FARMING LOG \n\n");
            }
            File.AppendAllText(_savePath, _dataToSave);
        }
        public static void OpenLog()
        {
            if (!File.Exists(_savePath))
                return;
            else
                Process.Start(_savePath);
        }
    }
}

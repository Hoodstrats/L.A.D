/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Hood.Core
{
    public static class SaveController
    {
        //ref our main prog we set thru getinfo
        static Companion _comp;
        //this will create the file in the program's folder
        static string _savePath;
        static string _saveFile;
        static string _dataToSave;
        static string _streamerData;
        static DateTime _currentDate;

        //have the program check if there's a another farmlog (FarmLog2) and set the _savepath to that instead
        //increase this index if the user decides to make a new farm log
        static int _logIndex = 0;

        static bool _newFile = false;

        static JsonConfig json = new JsonConfig();

        //call this when the program inits to make sure that the latest file is set
        public static void SetCurrentFile()
        {
            var p = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var d = Directory.CreateDirectory(Path.Combine(p, "Logs"));
            _savePath = d.ToString();

            if (File.Exists(_savePath + "/config.json"))
            {
                json = JsonConvert.DeserializeObject<JsonConfig>(File.ReadAllText(_savePath + "/config.json"));
                _logIndex = json._logIndex;
                _saveFile = json._saveFile;
            }
            else
            {
                File.WriteAllText(_savePath + "/config.json", JsonConvert.SerializeObject(json));
            }
        }
        //get info from main prog
        public static void GetInfo(Companion c)
        {
            _comp = c;

            //essentially next time you open the program it will be considered a new "Session" so will add datetime above farm
            if (DateTime.Now.Day != _currentDate.Day || _newFile)
            {
                _currentDate = DateTime.Now;

                _dataToSave = "---- " + DateTime.Now.ToString("MM/dd/yyyy") + " ----" + "\n" + "Farming: " + _comp.FarmName + " | " + "Mayhem:" + _comp.CurrentMayhemLevel + " | " + "Elapsed Time:" + _comp.ElapsedTime + "\n" + "Runs:" + _comp.AmountOfRuns + "  " + "Drops:" + _comp.DropCounter + "  " + "Keepers:" + _comp.KeptCounter + "  " + "Percent:" + _comp.Percentage + "%" + "\n\n";

                _newFile = false;
            }
            else
            {
                _dataToSave = "Farming: " + _comp.FarmName + " | " + "Mayhem:" + _comp.CurrentMayhemLevel + " | " + "Elapsed Time:" + _comp.ElapsedTime + "\n" + "Runs:" + _comp.AmountOfRuns + "  " + "Drops:" + _comp.DropCounter + "  " + "Keepers:" + _comp.KeptCounter + "  " + "Percent:" + _comp.Percentage + "%" + "\n\n";
            }
            SaveFarm();
        }
        public static void SaveFarm()
        {
            var fileName = $"/FarmLog{_logIndex}.txt";
            _saveFile = _savePath + fileName;

            if (!File.Exists(_saveFile))
            {
                File.WriteAllText(_saveFile, "FARMING LOG \n\n");
                json._saveFile = _saveFile;
                File.WriteAllText(_savePath + "/config.json", JsonConvert.SerializeObject(json));
            }
            File.AppendAllText(_saveFile, _dataToSave);
        }
        public static void OpenLog(Control c)
        {
            if (!File.Exists(_saveFile))
            {
                ErrorCatcher.Debug(c);
                Process.Start(_savePath);
            }
            else
            {
                ErrorCatcher.Clear();
                //PROCESS lets us use currently set Default application to open the file we feed
                Process.Start("notepad.exe",_saveFile);
            }
        }
        public static void StreamerMode(Companion c)
        {
            _streamerData = "Farming: " + c.FarmName + " | " + "Mayhem:" + c.CurrentMayhemLevel + " | " + "Elapsed Time:" + c.ElapsedTime + " | " + "Runs:" + c.AmountOfRuns + "  " + "Drops:" + c.DropCounter + "  " + "Keepers:" + c.KeptCounter + "  " + "Percent:" + c.Percentage + "%";
            var f = $"/FarmLogTEMP.txt";
            var tempFile = _savePath + f;
            File.WriteAllText(tempFile, _streamerData);
        }
        public static void CreateNewSave(Companion c)
        {
            //Create a second log file and set it as current file for concurrent saves 
            //make it so that the program targets the new save file instead of the old one
            //allow for continous creation of new files 0 to whatever number
            _logIndex++;
            _newFile = true;

            //set json logindex
            json._logIndex = _logIndex;
            json._saveFile = _saveFile;
            File.WriteAllText(_savePath + "/config.json", JsonConvert.SerializeObject(json));
            GetInfo(c);
        }
        //search the configuration file for values we need and change them here
        public static void ParseFile()
        {
            //List<string> origString = new List<string>();
            //List<string> changedString = new List<string>();

            //this implementation is case sensative 
            //after making changes to the file you have to resave it
            string s = File.ReadAllText(_saveFile);
            string n = s.Replace("Farming", "Doing the thing");
            File.WriteAllText(_saveFile, n);

            //foreach (var line in File.ReadAllText(_saveFile))
            //{
            //    if (line.Contains("Farming"))
            //    {
            //        line.Replace("Farming", "Doing the thing");
            //        File.
            //        //can have 2 lists one with the new value and one with the original 
            //        //that way we can switch it back if the player unchecks
            //        //add to list or replace it here;
            //        //need to save the file after
            //    }
            //}
        }
    }
}

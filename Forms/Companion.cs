/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hood.Core
{
    public partial class Companion : Form
    {
        public int AmountOfRuns { get => _amountOfRuns; }
        public int DropCounter { get => _dropCounter; }
        public int KeptCounter { get => _keptCounter; }
        public int Percentage { get => _percentage; }
        public string ElapsedTime { get => _elapsedTime; }
        public string FarmName { get => _farmName; }
        public int CurrentMayhemLevel { get => _currentMayhemLevel; }
        public bool StreamerMode { get => _stream; }

        KeyboardHook _keyboardHook;
        HelpDialogue _helpForm;

        Stopwatch _stopWatch = new Stopwatch();

        string _elapsedTime;
        string _farmName;

        int _amountOfRuns;
        int _dropCounter;
        int _keptCounter;
        int _percentage;
        int _currentMayhemLevel;

        bool _timerStarted = false;
        bool _timerPaused = false;
        bool _helpOpened = false;
        bool _stream = false;


        public Companion()
        {
            InitializeComponent();
            InitSettings();
            SetupConfig();
        }
        //this will create our json if it doesnt exist
        //if it exists it will set the values of certain variables 
        private void SetupConfig()
        {
            SaveController.SetCurrentFile();
        }
        //turn off all textboxes, register hotkeys with hook
        private void InitSettings()
        {
            //can start timer here and never stop it because STOPPING it doesn't free memory
            //starting it here ensures that when you pause or stop the stopwatch everything updates at the right timings instead of stopping/enabling/disabling it whenever we click along with the stopwatch
            _timer.Interval = 1000;
            _timer.Tick += UpdateLabel;
            _timer.Start();

            //ActiveControl = null;
            foreach (Control t in Controls)
            {
                if (t is TextBox)
                    t.Enabled = false;
            }

            //Mayhem selector setup
            int levels = 11;
            for (int i = 0; i < levels; i++)
            {
                _mayhemSelect.Items.Add($"Mayhem Level: {i}");
            }
            _mayhemSelect.SelectedIndex = 0;
            _mayhemSelect.SelectedIndexChanged += UpdateMayhemLevel;

            //register check boxes to callbacks
            _setCPU.CheckedChanged += ToggleCPUPriority;
            _streamerMode.CheckedChanged += ToggleStreamMode;
            _resetRun.Click += ResetRun;

            RegisterKeybinds();

            //after setting up the app make the farm name input active
            ActiveControl = _farmNameInput;
            _farmNameInput.Enabled = true;
            _farmNameInput.Focus();
        }

        private void RegisterKeybinds()
        {
            KeyDown += Form1_KeyDown;
            _keyboardHook = new KeyboardHook();
            _keyboardHook.KeyPressed += new EventHandler<KeyPressedEventArgs>(HandleInput);
            _keyboardHook.RegisterHotKey(Core.ModifierKeys.None, Keys.PageDown);
            _keyboardHook.RegisterHotKey(Core.ModifierKeys.None, Keys.Home);
            _keyboardHook.RegisterHotKey(Core.ModifierKeys.None, Keys.PageUp);
            _keyboardHook.RegisterHotKey(Core.ModifierKeys.None, Keys.End);
        }

        //handles our background button presses
        private void HandleInput(object s, KeyPressedEventArgs e)
        {
            if (e.Key == Keys.PageDown)
            {
                _dropCounter++;
                UpdatePercentage();
                _dropInput.Text = _dropCounter.ToString();

            }
            else if (e.Key == Keys.PageUp)
            {
                _keptCounter++;
                _keptInput.Text = _keptCounter.ToString();
            }
            else if (e.Key == Keys.End)
            {
                _amountOfRuns++;
                UpdatePercentage();
                _runInput.Text = _amountOfRuns.ToString();
            }
            else if (e.Key == Keys.Home)
            {
                ControlTimer();
            }
        }

        private void UpdatePercentage()
        {
            _percentage = (int)Math.Round((double)(100 * _dropCounter) / _amountOfRuns);
            _percentInput.Text = _percentage.ToString() + "%";
        }

        ///  In order to pick up keypresses program wide you have to enable properties>misc>keypreview
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //events triggered with ENTER key
            HandleEnterKey(e);
            //events triggered with CTRL Key
            HandleOptionKeys(e);
        }

        //when you press enter while using one of the text inputs
        void HandleEnterKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //this removes the DING when pressing enter on Windows
                e.SuppressKeyPress = true;

                //in the form design window in the properties each control we add gets an index value
                switch (ActiveControl.TabIndex)
                {
                    case 2://farm name
                        if (ActiveControl.Text != string.Empty)
                        {
                            //switch the active control to the label so the text can lose focus
                            ActiveControl = _farmLabel;
                            DisableTextBox(_farmNameInput);
                            ErrorCatcher.Clear();
                        }
                        else
                        {
                            ErrorCatcher.Debug(ActiveControl);
                        }
                        break;
                    case 10://runs label
                        if (ActiveControl.Text != string.Empty)
                        {

                            //switch the active control to the label so the text can lose focus
                            ActiveControl = _runsLabel;
                            DisableTextBox(_runInput);

                        }
                        break;
                    case 11:
                        if (ActiveControl.Text != string.Empty)
                        {
                            //switch the active control to the label so the text can lose focus
                            ActiveControl = _dropsLabel;
                            DisableTextBox(_dropInput);

                        }
                        break;
                    case 12:
                        if (ActiveControl.Text != string.Empty)
                        {

                            //switch the active control to the label so the text can lose focus
                            ActiveControl = _keptLabel;
                            DisableTextBox(_keptInput);

                        }
                        break;
                    case 13:
                        if (ActiveControl.Text != string.Empty)
                        {

                            //switch the active control to the label so the text can lose focus
                            ActiveControl = _percentLabel;
                            DisableTextBox(_percentInput);

                        }
                        break;
                    default:
                        break;
                }
            }
        }
        void HandleOptionKeys(KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                if (e.KeyCode == Keys.S)
                {
                    //saves current
                    _saveButton_Click(null, e);
                    //SaveController.SaveFarm();
                }
                else if (e.KeyCode == Keys.O)
                {
                    //opens current log
                    _openLog_LinkClicked(null, null);
                }
                else if (e.KeyCode == Keys.N)
                {
                    //creates a brand new save might need to add dialog confirmation just incase
                    SaveController.CreateNewSave(this);
                }
            }
        }
        //handle timer click
        private void _startTimer_Click(object sender, EventArgs e)
        {
            ControlTimer();
        }

        //controller start timer functionality
        void ControlTimer()
        {
            if (!_timerStarted)
            {
                _stopWatch.Start();
                _timerPaused = false;
                _timerStarted = true;
                _startTimer.Text = "Pause";
            }
            else if (_timerStarted && !_timerPaused)
            {
                //_timer.Enabled = false;
                _stopWatch.Stop();
                _timerPaused = true;
                _startTimer.Text = "Resume";
            }
            else if (_timerStarted && _timerPaused)
            {
                //_timer.Enabled = true;
                _stopWatch.Start();
                _timerPaused = false;
                _startTimer.Text = "Pause";
            }
        }
        void UpdateLabel(object s, EventArgs e)
        {
            _elapsedTime = _stopWatch.Elapsed.ToString(@"hh\:mm\:ss");
            _timerText.Text = _elapsedTime;

            if (_stream)
            {
                SaveController.StreamerMode(this);
            }
        }
        void DisableTextBox(TextBox t)
        {
            t.Enabled = false;
            _farmName = _farmNameInput.Text;
        }
        void UpdateMayhemLevel(object sender, EventArgs e)
        {
            _currentMayhemLevel = _mayhemSelect.SelectedIndex;
            ActiveControl = null;
        }
        //when you click the Farm name label activate the text input and change label
        private void _farmName_Click(object sender, EventArgs e)
        {
            _farmNameInput.Enabled = true;
            _farmNameInput.Focus();
            if (_farmNameInput.Text != string.Empty)
            {
                _farmNameInput.SelectAll();
            }
        }
        private void _farmNameInput_LostFocus(object sender, EventArgs e)
        {
            _farmNameInput.Enabled = false;
            _farmNameInput.Visible = false;
            _farmLabel.Visible = true;
        }
        void ResetRun(object sender, EventArgs e)
        {
            _stopWatch.Reset();
            _stopWatch.Stop();

            _timerStarted = false;
            _timerPaused = false;

            UpdateLabel(sender, e);

            _startTimer.Text = "Start Timer";

            ClearValues();
        }
        private void ClearValues()
        {
            foreach (Control t in Controls)
            {
                if (t is TextBox)
                {
                    _amountOfRuns = 0;
                    _dropCounter = 0;
                    _keptCounter = 0;
                    _percentage = 0;
                    _currentMayhemLevel = 0;
                    _mayhemSelect.SelectedIndex = 0;
                    t.Text = string.Empty;
                }
            }
        }
        //auto created events from the form designer
        void _saveButton_Click(object sender, EventArgs e)
        {
            //pass in this class in order to get the info required instead of grabbing it all through params
            SaveController.GetInfo(this);
        }
        private void _openLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //does the check for the log and everything in the save script
            SaveController.OpenLog(_openLog);
        }
        private void _dropTableLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets/d/1fkCwu0zeX1BBGcNEzWGZDr2kQ0IOPSoZQK2FD-zpw1M/htmlview?usp=sharing&sle=true");
        }
        //links to the patches notes on github/itchio
        private void _versionNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets/d/1fkCwu0zeX1BBGcNEzWGZDr2kQ0IOPSoZQK2FD-zpw1M/htmlview?usp=sharing&sle=true");
        }
        //change this from the default into an event
        private void _helpLabel_Click(object sender, EventArgs e)
        {
            if (_helpOpened)
            {
                _helpOpened = false;
                _helpForm.Close();
            }
            else
            {
                //create the help dialogue window / populate values if needed
                _helpForm = new HelpDialogue();
                _helpForm.FormClosed += (t,y) => _helpOpened = false;
                _helpForm.Owner = this;
                _helpForm.Show();
                _helpOpened = true;
            }
        }
        //loop through current windows processses and increase the Borderlands CPU prior to HIGH/Normal depending on check box state
        void ToggleCPUPriority(object sender, EventArgs e)
        {
            //increase game cpu priority
            Process[] proc = Process.GetProcesses();
            for (int i = 0; i < proc.Length; i++)
            {
                if (proc[i].ProcessName == "Borderlands3")
                {
                    //.checked is an enum in the checked box class
                    if (_setCPU.Checked)
                    {
                        proc[i].PriorityClass = ProcessPriorityClass.High;
                    }
                    else
                    {
                        proc[i].PriorityClass = ProcessPriorityClass.Normal;
                    }
                }
            }
        }
        void ToggleStreamMode(object sender, EventArgs e)
        {
            _stream = _streamerMode.Checked;

            //make sure that when u uncheck streamer mode it manually saves to current save file
            if (!_stream)
            {
                SaveController.GetInfo(this);
            }
        }
    }
}

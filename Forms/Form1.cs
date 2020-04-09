/* https://twitter.com/HoodStrats || https://github.com/Hoodstrats */

using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hoodstrats.Core
{
    public partial class Form1 : Form
    {
        private KeyboardHook _keyboardHook;
        private HelpDialogue _helpForm;

        private DateTime _startTime;
        private TimeSpan _currentElapsedTime;

        Stopwatch _stopWatch = new Stopwatch();

        private int _amountOfRuns;
        private int _dropCounter;
        private int _keptCounter;
        private int _percentage;

        private bool _timerStarted = false;
        private bool _timerPaused = false;
        private bool _helpOpened = false;


        public Form1()
        {
            InitializeComponent();
            InitSettings();
        }
        //turn off all textboxes, register hotkeys with hook
        private void InitSettings()
        {
            ActiveControl = null;
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                    t.Enabled = false;
            }
            //can start timer here and never stop it because STOPPING it doesn't free memory
            //starting it here ensures that when you pause or stop the stopwatch everything updates at the right timings instead of stopping/enabling/disabling it whenever we click along with the stopwatch
            _timer.Interval = 1000;
            _timer.Tick += UpdateLabel;
            _timer.Start();
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
            else if (e.Key == Keys.Home)
            {
                _amountOfRuns++;
                UpdatePercentage();
                _runInput.Text = _amountOfRuns.ToString();
            }
            else if (e.Key == Keys.End)
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
            if (e.KeyCode == Keys.Enter)
            {
                switch (ActiveControl.TabIndex)
                {
                    case 2:
                        if (ActiveControl.Text != string.Empty)
                        {
                            //switch the active control to the label so the text can lose focus
                            ActiveControl = _farmLabel;
                            DisableTextBox(_farmNameInput);
                        }

                        break;
                    case 10:
                        if (ActiveControl.Text != string.Empty)
                        {
                            if (e.KeyCode == Keys.Enter)
                            {
                                //switch the active control to the label so the text can lose focus
                                ActiveControl = _runsLabel;
                                DisableTextBox(_runInput);
                            }
                        }
                        break;
                    case 11:
                        if (ActiveControl.Text != string.Empty)
                        {
                            if (e.KeyCode == Keys.Enter)
                            {
                                //switch the active control to the label so the text can lose focus
                                ActiveControl = _dropsLabel;
                                DisableTextBox(_dropInput);
                            }
                        }
                        break;
                    case 12:
                        if (ActiveControl.Text != string.Empty)
                        {
                            if (e.KeyCode == Keys.Enter)
                            {
                                //switch the active control to the label so the text can lose focus
                                ActiveControl = _keptLabel;
                                DisableTextBox(_keptInput);
                            }
                        }
                        break;
                    case 13:
                        if (ActiveControl.Text != string.Empty)
                        {
                            if (e.KeyCode == Keys.Enter)
                            {
                                //switch the active control to the label so the text can lose focus
                                ActiveControl = _percentLabel;
                                DisableTextBox(_percentInput);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        //handle timer click
        private void _startTimer_Click(object sender, EventArgs e)
        {
            ControlTimer();
        }
        //controller start timer functionality
        private void ControlTimer()
        {
            if (!_timerStarted)
            {
                _stopWatch.Start();
                _timerPaused = false;
                _timerStarted = true;
                _startTime = DateTime.Now;
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

        private void UpdateLabel(object s, EventArgs e)
        {
            string t = _stopWatch.Elapsed.ToString(@"hh\:mm\:ss");
            _timerText.Text = t;
        }
        private void DisableTextBox(TextBox t)
        {
            t.Enabled = false;
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
        private void _resetRun_Click(object sender, EventArgs e)
        {
            _startTime = DateTime.Now;
            _stopWatch.Reset();
            //_timer.Stop();
            _timerStarted = false;
            _timerPaused = false;
            UpdateLabel(sender, e);
            _startTimer.Text = "Start Timer";
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Text = string.Empty;
                }
            }
        }
        private void _saveButton_Click(object sender, EventArgs e)
        {
            _currentElapsedTime = _startTime - DateTime.Now;
            string s = _currentElapsedTime.ToString(@"hh\:mm\:ss");
            SaveController.GetInfo(s, _farmNameInput.Text, _amountOfRuns.ToString(), _dropCounter.ToString(), _keptCounter.ToString(), _percentage.ToString());
        }
        private void _openLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveController.OpenLog();
        }
        private void _dropTableLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docs.google.com/spreadsheets/d/1fkCwu0zeX1BBGcNEzWGZDr2kQ0IOPSoZQK2FD-zpw1M/htmlview?usp=sharing&sle=true");
        }
        private void _helpLabel_Click(object sender, EventArgs e)
        {
            if (_helpOpened)
            {
                _helpOpened = false;
                _helpForm.Close();
            }
            else
            {
                _helpForm = new HelpDialogue();
                _helpForm.FormClosed += (t,y) => _helpOpened = false;
                _helpForm.Owner = this;
                _helpForm.Show();
                _helpOpened = true;
            }
        }
    }
}

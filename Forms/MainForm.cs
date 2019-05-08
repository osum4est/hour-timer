using System;
using System.Windows.Forms;
using HourTimer.Properties;

namespace HourTimer.Forms
{
    public partial class MainForm : Form
    {
        private TimerData timerData;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTimerData();
            StartNow.Checked = timerData.Completed;
        }

        private void StartLargeTimer_Click(object sender, EventArgs e)
        {
            SaveTimerData();
            // TODO
        }

        private void StartSmallTimer_Click(object sender, EventArgs e)
        {
            SaveTimerData();
            // TODO
        }

        private void StartNow_CheckedChanged(object sender, EventArgs e)
        {
            StartTime.Enabled = !StartNow.Checked;
            StartDate.Enabled = !StartNow.Checked;
        }

        private void LoadTimerData()
        {
            timerData = new TimerData()
            {
                StartDate = Settings.Default.StartDate,
                TimerLength = Settings.Default.TimerLength
            };

            StartDate.Value = timerData.StartDate;
            StartTime.Value = timerData.StartDate;
            TimerLength.Value = timerData.TimerLength;
        }

        private void SaveTimerData()
        {
            timerData.TimerLength = (int)TimerLength.Value;

            if (StartNow.Checked)
                timerData.StartDate = DateTime.Now;
            else
                timerData.StartDate = StartDate.Value.Date + StartTime.Value.TimeOfDay;

            Settings.Default.StartDate = timerData.StartDate;
            Settings.Default.TimerLength = timerData.TimerLength;
            Settings.Default.Save();
        }
    }
}
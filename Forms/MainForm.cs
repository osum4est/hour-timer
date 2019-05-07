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
            TimerDataBinding.DataSource = timerData;
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
        }

        private void SaveTimerData()
        {
            if (StartNow.Checked)
                timerData.StartDate = DateTime.Now;

            Settings.Default.StartDate = timerData.StartDate;
            Settings.Default.TimerLength = timerData.TimerLength;
            Settings.Default.Save();
        }
    }
}
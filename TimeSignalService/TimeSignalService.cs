using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace TimeSignalService
{
    public partial class TimeSignalService : ServiceBase
    {
        private Timer timer;
        private Dictionary<int, string> soundMap = new Dictionary<int, string>()
        {
            {0, TimeSignalSettings.Default.Zero},
            {1, TimeSignalSettings.Default.One},
            {2, TimeSignalSettings.Default.Two},
            {3, TimeSignalSettings.Default.Three},
            {4, TimeSignalSettings.Default.Four},
            {5, TimeSignalSettings.Default.Five},
            {6, TimeSignalSettings.Default.Six},
            {7, TimeSignalSettings.Default.Seven},
            {8, TimeSignalSettings.Default.Eight},
            {9, TimeSignalSettings.Default.Nine},
            {10, TimeSignalSettings.Default.Ten},
            {11, TimeSignalSettings.Default.Eleven},
            {12, TimeSignalSettings.Default.Twelve},
            {13, TimeSignalSettings.Default.Thirteen},
            {14, TimeSignalSettings.Default.Fourteen},
            {15, TimeSignalSettings.Default.Fifteen},
            {16, TimeSignalSettings.Default.Sixteen},
            {17, TimeSignalSettings.Default.Seventeen},
            {18, TimeSignalSettings.Default.Eighteen},
            {19, TimeSignalSettings.Default.Nineteen},
            {20, TimeSignalSettings.Default.Twenty},
            {21, TimeSignalSettings.Default.Twentyone},
            {22, TimeSignalSettings.Default.Twentytwo},
            {23, TimeSignalSettings.Default.Twentythree}
        };

        public TimeSignalService()
        {
            InitializeComponent();

            timer = new Timer()
            {
                Interval = 1000,
                Enabled = true,
            };

            timer.Elapsed += TimerTick;
        }

        protected override void OnStart(string[] args)
        {
            eventLog.WriteEntry("サービス起動しました(^・ω・^§)ﾉ");
            timer.Start();
        }

        protected override void OnStop()
        {
            eventLog.WriteEntry("サービス終了しました(^・ω・^§)ﾉ");
            timer.Stop();
        }

        private void TimerTick(object sender, ElapsedEventArgs e)
        {
            if (DateTime.Now.Minute == 0 && DateTime.Now.Second == 0 && File.Exists(soundMap[DateTime.Now.Hour]))
            {
                using (var player = new System.Media.SoundPlayer(soundMap[DateTime.Now.Hour]))
                {
                    player.Play();
                }
            }
        }

        internal void OnStartConsole(string[] args) => OnStart(args);

        internal void OnStopConsole() => OnStop();
    }
}

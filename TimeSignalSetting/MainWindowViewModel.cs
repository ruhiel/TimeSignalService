using Microsoft.Win32;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using TimeSignalSetting.Models;

namespace TimeSignalSetting
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private SettingModel settingModel = new SettingModel();

        public ReactiveProperty<string> Zero { get; private set; }
        public ReactiveProperty<string> One { get; private set; }
        public ReactiveProperty<string> Two { get; private set; }

        public ReactiveProperty<string> Three { get; private set; }
        public ReactiveProperty<string> Four { get; private set; }
        public ReactiveProperty<string> Five { get; private set; }
        public ReactiveProperty<string> Six { get; private set; }
        public ReactiveProperty<string> Seven { get; private set; }
        public ReactiveProperty<string> Eight { get; private set; }
        public ReactiveProperty<string> Nine { get; private set; }
        public ReactiveProperty<string> Ten { get; private set; }
        public ReactiveProperty<string> Eleven { get; private set; }
        public ReactiveProperty<string> Twelve { get; private set; }
        public ReactiveProperty<string> Thirteen { get; private set; }
        public ReactiveProperty<string> Fourteen { get; private set; }
        public ReactiveProperty<string> Fifteen { get; private set; }
        public ReactiveProperty<string> Sixteen { get; private set; }
        public ReactiveProperty<string> Seventeen { get; private set; }
        public ReactiveProperty<string> Eighteen { get; private set; }
        public ReactiveProperty<string> Nineteen { get; private set; }
        public ReactiveProperty<string> Twenty { get; private set; }
        public ReactiveProperty<string> Twentyone { get; private set; }
        public ReactiveProperty<string> Twentytwo { get; private set; }
        public ReactiveProperty<string> Twentythree { get; private set; }
        public ReactiveCommand<string> OpenFileCommand { get; } = new ReactiveCommand<string>();
        public ReactiveCommand<string> PlayCommand { get; } = new ReactiveCommand<string>();
        public ReactiveCommand StartCommand { get; } = new ReactiveCommand();
        public ReactiveCommand StopCommand { get; } = new ReactiveCommand();
        public MainWindowViewModel()
        {
            Zero = settingModel.ToReactivePropertyAsSynchronized(x => x.Zero);

            One = settingModel.ToReactivePropertyAsSynchronized(x => x.One);

            Two = settingModel.ToReactivePropertyAsSynchronized(x => x.Two);

            Three = settingModel.ToReactivePropertyAsSynchronized(x => x.Three);

            Four = settingModel.ToReactivePropertyAsSynchronized(x => x.Four);

            Five = settingModel.ToReactivePropertyAsSynchronized(x => x.Five);

            Six = settingModel.ToReactivePropertyAsSynchronized(x => x.Six);

            Seven = settingModel.ToReactivePropertyAsSynchronized(x => x.Seven);

            Eight = settingModel.ToReactivePropertyAsSynchronized(x => x.Eight);

            Nine = settingModel.ToReactivePropertyAsSynchronized(x => x.Nine);

            Ten = settingModel.ToReactivePropertyAsSynchronized(x => x.Ten);

            Eleven = settingModel.ToReactivePropertyAsSynchronized(x => x.Eleven);

            Twelve = settingModel.ToReactivePropertyAsSynchronized(x => x.Twelve);

            Thirteen = settingModel.ToReactivePropertyAsSynchronized(x => x.Thirteen);

            Fourteen = settingModel.ToReactivePropertyAsSynchronized(x => x.Fourteen);

            Fifteen = settingModel.ToReactivePropertyAsSynchronized(x => x.Fifteen);

            Sixteen = settingModel.ToReactivePropertyAsSynchronized(x => x.Sixteen);

            Seventeen = settingModel.ToReactivePropertyAsSynchronized(x => x.Seventeen);

            Eighteen = settingModel.ToReactivePropertyAsSynchronized(x => x.Eighteen);

            Nineteen = settingModel.ToReactivePropertyAsSynchronized(x => x.Nineteen);

            Twenty = settingModel.ToReactivePropertyAsSynchronized(x => x.Twenty);

            Twentyone = settingModel.ToReactivePropertyAsSynchronized(x => x.Twentyone);

            Twentytwo = settingModel.ToReactivePropertyAsSynchronized(x => x.Twentytwo);

            Twentythree = settingModel.ToReactivePropertyAsSynchronized(x => x.Twentythree);

            OpenFileCommand.Subscribe(x => ButtonAction(x));

            PlayCommand.Subscribe(x => PlayAction(x));

            StartCommand.Subscribe(_ => StartAction());

            StopCommand.Subscribe(_ => StopAction());
        }

        private void StopAction()
        {
            var proc = new Process();

            proc.StartInfo.FileName = @"TimeSignalService.exe";
            proc.StartInfo.Verb = "RunAs";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Arguments = "/u";
            proc.Start();
        }

        private void StartAction()
        {
            var proc = new Process();

            proc.StartInfo.FileName = @"TimeSignalService.exe";
            proc.StartInfo.Verb = "RunAs";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Arguments = "/i";
            proc.Start();
        }

        private void PlayAction(string x) => settingModel.Play(x);

        private void ButtonAction(string number)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "ファイルを開く";
            dialog.Filter = "全てのファイル(*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                settingModel.Put(dialog.FileName, number);

                settingModel.Save();
            }
        }
    }
}

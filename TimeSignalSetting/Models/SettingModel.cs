using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using TimeSignalSetting.Models;

namespace TimeSignalSetting
{
    public class SettingModel : BindableBase
    {
        private configuration Configuration;

        public SettingModel()
        {
            using (var inputStream = new FileStream(@"TimeSignalService.exe.config", FileMode.Open))
            {
                var serializer = new XmlSerializer(typeof(configuration));

                Configuration = (configuration)serializer.Deserialize(inputStream);

                Zero = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Zero))?.value;

                One = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(One))?.value;

                Two = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Two))?.value;

                Three = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Three))?.value;

                Four = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Four))?.value;

                Five = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Five))?.value;

                Six = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Six))?.value;

                Seven = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Seven))?.value;

                Eight = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Eight))?.value;

                Nine = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Nine))?.value;

                Ten = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Ten))?.value;

                Eleven = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Eleven))?.value;

                Twelve = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twelve))?.value;

                Thirteen = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Thirteen))?.value;

                Fourteen = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Fourteen))?.value;

                Fifteen = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Fifteen))?.value;

                Sixteen = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Sixteen))?.value;

                Seventeen = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Seventeen))?.value;

                Eighteen = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Eighteen))?.value;

                Nineteen = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Nineteen))?.value;

                Twelve = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twelve))?.value;

                Twentyone = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twentyone))?.value;

                Twentytwo = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twentytwo))?.value;

                Twentythree = Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twentythree))?.value;
            }
        }

        private string _Zero;
        public string Zero
        {
            get { return _Zero; }
            set { SetProperty(ref _Zero, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Zero)).value = value; }
        }

        private string _One;
        public string One
        {
            get { return _One; }
            set { SetProperty(ref _One, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(One)).value = value; }
        }

        private string _Two;
        public string Two
        {
            get { return _Two; }
            set { SetProperty(ref _Two, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Two)).value = value; }
        }

        private string _Three;
        public string Three
        {
            get { return _Three; }
            set { SetProperty(ref _Three, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Three)).value = value; }
        }

        private string _Four;
        public string Four
        {
            get { return _Four; }
            set { SetProperty(ref _Four, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Four)).value = value; }
        }

        private string _Five;
        public string Five
        {
            get { return _Five; }
            set { SetProperty(ref _Five, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Five)).value = value; }
        }

        private string _Six;
        public string Six
        {
            get { return _Six; }
            set { SetProperty(ref _Six, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Six)).value = value; }
        }

        private string _Seven;
        public string Seven
        {
            get { return _Seven; }
            set { SetProperty(ref _Seven, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Seven)).value = value; }
        }

        private string _Eight;
        public string Eight
        {
            get { return _Eight; }
            set { SetProperty(ref _Eight, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Eight)).value = value; }
        }

        private string _Nine;
        public string Nine
        {
            get { return _Nine; }
            set { SetProperty(ref _Nine, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Nine)).value = value; }
        }

        private string _Ten;
        public string Ten
        {
            get { return _Ten; }
            set { SetProperty(ref _Ten, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Ten)).value = value; }
        }

        private string _Eleven;
        public string Eleven
        {
            get { return _Eleven; }
            set { SetProperty(ref _Eleven, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Eleven)).value = value; }
        }

        private string _Twelve;
        public string Twelve
        {
            get { return _Twelve; }
            set { SetProperty(ref _Twelve, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twelve)).value = value; }
        }

        private string _Thirteen;
        public string Thirteen
        {
            get { return _Thirteen; }
            set { SetProperty(ref _Thirteen, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Thirteen)).value = value; }
        }

        private string _Fourteen;
        public string Fourteen
        {
            get { return _Fourteen; }
            set { SetProperty(ref _Fourteen, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Fourteen)).value = value; }
        }

        private string _Fifteen;
        public string Fifteen
        {
            get { return _Fifteen; }
            set { SetProperty(ref _Fifteen, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Fifteen)).value = value; }
        }

        private string _Sixteen;
        public string Sixteen
        {
            get { return _Sixteen; }
            set { SetProperty(ref _Sixteen, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Sixteen)).value = value; }
        }

        private string _Seventeen;
        public string Seventeen
        {
            get { return _Seventeen; }
            set { SetProperty(ref _Seventeen, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Seventeen)).value = value; }
        }

        private string _Eighteen;
        public string Eighteen
        {
            get { return _Eighteen; }
            set { SetProperty(ref _Eighteen, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Eighteen)).value = value; }
        }

        private string _Nineteen;
        public string Nineteen
        {
            get { return _Nineteen; }
            set { SetProperty(ref _Nineteen, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Nineteen)).value = value; }
        }

        private string _Twenty;
        public string Twenty
        {
            get { return _Twenty; }
            set { SetProperty(ref _Twenty, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twenty)).value = value; }
        }

        private string _Twentyone;
        public string Twentyone
        {
            get { return _Twentyone; }
            set { SetProperty(ref _Twentyone, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twentyone)).value = value; }
        }

        private string _Twentytwo;
        public string Twentytwo
        {
            get { return _Twentytwo; }
            set { SetProperty(ref _Twentytwo, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twentytwo)).value = value; }
        }

        private string _Twentythree;
        public string Twentythree
        {
            get { return _Twentythree; }
            set { SetProperty(ref _Twentythree, value); Configuration.userSettings.TimeSignalServiceTimeSignalSettings.ToList().FirstOrDefault(x => x.name == nameof(Twentythree)).value = value; }
        }


        internal void Play(string number)
        {
            string fileName = null;
            switch (number)
            {
                case "0":
                    fileName = Zero;
                    break;
                case "1":
                    fileName = One;
                    break;
                case "2":
                    fileName = Two;
                    break;
                case "3":
                    fileName = Three;
                    break;
                case "4":
                    fileName = Four;
                    break;
                case "5":
                    fileName = Five;
                    break;
                case "6":
                    fileName = Six;
                    break;
                case "7":
                    fileName = Seven;
                    break;
                case "8":
                    fileName = Eight;
                    break;
                case "9":
                    fileName = Nine;
                    break;
                case "10":
                    fileName = Ten;
                    break;
                case "11":
                    fileName = Eleven;
                    break;
                case "12":
                    fileName = Twelve;
                    break;
                case "13":
                    fileName = Thirteen;
                    break;
                case "14":
                    fileName = Fourteen;
                    break;
                case "15":
                    fileName = Fifteen;
                    break;
                case "16":
                    fileName = Sixteen;
                    break;
                case "17":
                    fileName = Seventeen;
                    break;
                case "18":
                    fileName = Eighteen;
                    break;
                case "19":
                    fileName = Nineteen;
                    break;
                case "20":
                    fileName = Twenty;
                    break;
                case "21":
                    fileName = Twentyone;
                    break;
                case "22":
                    fileName = Twentytwo;
                    break;
                case "23":
                    fileName = Twentythree;
                    break;
            }

            if (File.Exists(fileName))
            {
                var player = new System.Media.SoundPlayer(fileName);
                player.Play();
            }
        }

        internal void Put(string fileName, string number)
        {
            switch (number)
            {
                case "0":
                    Zero = fileName;
                    break;
                case "1":
                    One = fileName;
                    break;
                case "2":
                    Two = fileName;
                    break;
                case "3":
                    Three = fileName;
                    break;
                case "4":
                    Four = fileName;
                    break;
                case "5":
                    Five = fileName;
                    break;
                case "6":
                    Six = fileName;
                    break;
                case "7":
                    Seven = fileName;
                    break;
                case "8":
                    Eight = fileName;
                    break;
                case "9":
                    Nine = fileName;
                    break;
                case "10":
                    Ten = fileName;
                    break;
                case "11":
                    Eleven = fileName;
                    break;
                case "12":
                    Twelve = fileName;
                    break;
                case "13":
                    Thirteen = fileName;
                    break;
                case "14":
                    Fourteen = fileName;
                    break;
                case "15":
                    Fifteen = fileName;
                    break;
                case "16":
                    Sixteen = fileName;
                    break;
                case "17":
                    Seventeen = fileName;
                    break;
                case "18":
                    Eighteen = fileName;
                    break;
                case "19":
                    Nineteen = fileName;
                    break;
                case "20":
                    Twenty = fileName;
                    break;
                case "21":
                    Twentyone = fileName;
                    break;
                case "22":
                    Twentytwo = fileName;
                    break;
                case "23":
                    Twentythree = fileName;
                    break;
            }
        }

        public void Save()
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);

            using (var outputStream = new FileStream(@"TimeSignalService.exe.config", FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(configuration));

                serializer.Serialize(outputStream, Configuration, ns);
            }
        }
    }
}

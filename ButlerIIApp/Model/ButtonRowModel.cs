using ButlerIIApp.Enums;
using System;

namespace ButlerIIApp.Model
{
    public class ButtonRowModel : NotifyPropertyChangedBase
    {
        private int[] starMessage = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private bool enabled = false;
        private int pagerNo = 1;
        private PagerType pagerType = PagerType.STAR;
        private PagerVibeMode pagerVibeMode = PagerVibeMode.VIBE1;
        private ExternalSettings externalSetting = ExternalSettings.OPEN;
        private PagerFlashMode pagerFlashMode;
        private int pagerIntMessage = 0;
        private string pagerStrMessage = "";
        private string identitifier;

        public int[] StarMessage
        {
            get => starMessage;
            set => starMessage = value;
        }

        public bool IsModeCmbEnabled
        {
            get => enabled && !PagerType.Equals(PagerType.ALPHA);

        }
        public bool IsMsgEnabled
        {
            get => enabled && !PagerType.Equals(PagerType.GUEST);

        }

        public bool Enabled
        {
            get => enabled;
            set
            {
                if (this.CheckPropertyChanged<bool>("Enabled", ref enabled, ref value))
                {
                    this.NotifyPropertyChanged("Enabled");
                    this.NotifyPropertyChanged("IsModeCmbEnabled");
                    this.NotifyPropertyChanged("IsMsgEnabled");
                }
            }
        }

        public int PagerNo
        {
            get => pagerNo;
            set
            {
                if (this.CheckPropertyChanged<int>("PagerNo", ref pagerNo, ref value))
                {
                    this.NotifyPropertyChanged("PagerNo");
                }
            }
        }

        public string Identitifier
        {
            get => identitifier;
            set
            {
                if (this.CheckPropertyChanged<string>("Identitifier", ref identitifier, ref value))
                {
                    this.NotifyPropertyChanged("Identitifier");
                }
            }
        }

        public PagerType PagerType
        {
            get => pagerType;
            set
            {
                if (this.CheckPropertyChanged<PagerType>("PagerType", ref pagerType, ref value))
                {
                    this.NotifyPropertyChanged("PagerType");
                    this.NotifyPropertyChanged("IsModeCmbEnabled");
                    this.NotifyPropertyChanged("IsMsgEnabled");
                }
            }
        }



        public PagerVibeMode PagerVibeMode
        {
            get => pagerVibeMode;
            set
            {
                if (this.CheckPropertyChanged<PagerVibeMode>("PagerVibeMode", ref pagerVibeMode, ref value))
                {
                    this.NotifyPropertyChanged("PagerVibeMode");
                }
            }
        }

        public PagerFlashMode PagerFlashMode
        {
            get => pagerFlashMode;
            set
            {
                if (this.CheckPropertyChanged<PagerFlashMode>("PagerFlashMode", ref pagerFlashMode, ref value))
                {
                    this.NotifyPropertyChanged("PagerFlashMode");
                }
            }
        }

        public int PagerIntMessage
        {
            get => pagerIntMessage; set
            {
                if (this.CheckPropertyChanged<int>("PagerIntMessage", ref pagerIntMessage, ref value))
                {
                    this.NotifyPropertyChanged("PagerIntMessage");
                }
            }
        }
        public string PagerStrMessage
        {
            get => pagerStrMessage; set
            {
                if (this.CheckPropertyChanged<string>("PagerStrMessage", ref pagerStrMessage, ref value))
                {
                    this.NotifyPropertyChanged("PagerStrMessage");
                }
            }
        }

        public ExternalSettings ExternalSetting
        {
            get => externalSetting; set
            {
                if (this.CheckPropertyChanged<ExternalSettings>("ExternalSetting", ref externalSetting, ref value))
                {
                    this.NotifyPropertyChanged("ExternalSetting");
                }
            }
        }

        public ButtonRowModel()
        {
        }

        public ButtonRowModel(string identitifier)
        {
            this.identitifier = identitifier;
        }

        public void Init(String data)
        {
            // BUT0,1,1,1,0,2,1
            var delimeter = ',';
            if (data.StartsWith(identitifier))
            {
                var values = data.Split(delimeter);
                if (values.Length != 6)
                {
                    throw new Exception();
                }
                else
                {
                    Enabled = values[1].Equals("1");
                    PagerNo = Convert.ToInt32(values[2]);
                    PagerType = (PagerType)Convert.ToInt32(values[3]);
                    if (PagerType.STAR.Equals(PagerType))
                    {
                        try
                        {
                            PagerIntMessage = Convert.ToInt32(values[4]);
                        }
                        catch
                        {
                            // Do nothing
                        }
                    }
                    else
                    {
                        PagerStrMessage = values[4];
                    }
                    PagerFlashMode = (PagerFlashMode)Convert.ToInt32(values[5]);
                    PagerVibeMode = (PagerVibeMode)Convert.ToInt32(values[5]);
                }
            }
        }
    }
}

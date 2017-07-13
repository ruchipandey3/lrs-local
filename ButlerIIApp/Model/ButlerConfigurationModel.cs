using System;

namespace ButlerIIApp.Model
{
    public class ButlerConfigurationModel : NotifyPropertyChangedBase
    {
       // private AdvancedFeaturesTabModel advancedFeaturesTabModel = new AdvancedFeaturesTabModel();

        private ButtonInputTabModel buttonInputTabModel = new ButtonInputTabModel();
        private ExternalInputRowModel externalInputModel = new ExternalInputRowModel("INP0");

        public ExternalInputRowModel ExternalInputModel { get => externalInputModel; set => externalInputModel = value; }

        private int systemId;
        private bool groupPagingEnabled;
        public int SystemId
        {
            get => systemId; set
            {
                if (this.CheckPropertyChanged<int>("SystemId", ref systemId, ref value))
                {
                    this.NotifyPropertyChanged("SystemId");
                }
            }
        }

        public bool GroupPagingEnabled
        {
            get => groupPagingEnabled; set
            {
                if (this.CheckPropertyChanged<bool>("GroupPagingEnabled", ref groupPagingEnabled, ref value))
                {
                    this.NotifyPropertyChanged("GroupPagingEnabled");
                }
            }
        }

        //public AdvancedFeaturesTabModel AdvancedFeaturesTabModel { get => advancedFeaturesTabModel; set => advancedFeaturesTabModel = value; }
        public ButtonInputTabModel ButtonInputTabModel { get => buttonInputTabModel; set => buttonInputTabModel = value; }

        public void Init(String[] data)
        {
           // AdvancedFeaturesTabModel.Init(data);
            ButtonInputTabModel.Init(data);
        }
    }
}

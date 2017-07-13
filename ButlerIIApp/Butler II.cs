using ButlerIIApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButlerIIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] data = new string[] { "VER,5V1.15", "CPU647", "SERIAL,-1", "UID,0", "RID,1", "RONT0,12,50", "ROFFT0,13,0", "RONT1,14,0", "ROFFT1,2,10", "RONT2,255,255", "ROFFT2,255,255", "GPEN,0", "BEEP,0", "LOCK,3,5,4,0,0", "LCKT,180", "INP0,1,121,1,test,0,0", "LOWBAT,1,101,pfs low battery", "BUT0,1,11,0,2,1", "BUT1,1,101,1,help me,0", "BUT2,1,1,2,,1", "BUT3,1,104,1,hello alpha,0", "BUT4,0,5,0,no message,0", "ACKPGR,0,0,no message", "SECPGR,0,99", "CNCLMSG,0,no message", "RPGSET,45" };
            ButlerConfigModel.Init(data);
        }

        private ButlerConfigurationModel butlerConfigModel = new ButlerConfigurationModel();

        public ButlerConfigurationModel ButlerConfigModel { get => butlerConfigModel; set => butlerConfigModel = value; }

        private void BindControl()
        {
            buttonInputTabView1.DataBindings.Add(new Binding("ButtonInputTabModel", ButlerConfigModel, "ButtonInputTabModel", true, DataSourceUpdateMode.OnPropertyChanged));
           // advancedFeatureTabView1.DataBindings.Add(new Binding("AdvancedFeaturesTabModel", ButlerConfigModel, "AdvancedFeaturesTabModel", true, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}

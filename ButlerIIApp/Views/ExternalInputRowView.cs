using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ButlerIIApp.Model;
using ButlerIIApp.Enums;
using ButlerIIApp.Util;

namespace ButlerIIApp.Views
{
    public partial class ExternalInputRowView : UserControl
    {
        public ExternalInputRowView()
        {
            InitializeComponent();
        }

        private ExternalInputRowModel externalInputRowModel;

        public ExternalInputRowModel ExternalInputRowModel { get => externalInputRowModel; set => externalInputRowModel = value; }


        private void BindControl()
        {
            chkEnabled.DataBindings.Add(new Binding("Checked", ExternalInputRowModel, "Enabled", true, DataSourceUpdateMode.OnPropertyChanged));
            spinPagerNumber.DataBindings.Add(new Binding("Value", ExternalInputRowModel, "PagerNo", true, DataSourceUpdateMode.OnPropertyChanged));
            spinPagerNumber.DataBindings.Add(new Binding("Enabled", ExternalInputRowModel, "Enabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerSettings.DataSource = Enum.GetValues(typeof(ExternalSettings)).Cast<ExternalSettings>().Select(type =>
                      new { Value = type, Title = EnumHelper.GetDescription(type) }).ToList();
            cmbPagerSettings.ValueMember = "Value";
            cmbPagerSettings.DisplayMember = "Title";
            cmbPagerSettings.DataBindings.Add(new Binding("SelectedValue", ExternalInputRowModel, "ExternalSetting", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbPagerSettings.DataBindings.Add(new Binding("Enabled", ExternalInputRowModel, "Enabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerType.DataSource = Enum.GetValues(typeof(PagerType)).Cast<PagerType>().Select(type =>
                    new { Value = type, Title = EnumHelper.GetDescription(type) }).ToList();
            cmbPagerType.ValueMember = "Value";
            cmbPagerType.DisplayMember = "Title";
            cmbPagerType.DataBindings.Add(new Binding("SelectedValue", ExternalInputRowModel, "PagerType", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbPagerType.DataBindings.Add(new Binding("Enabled", ExternalInputRowModel, "Enabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerVibeMode.DataSource = Enum.GetValues(typeof(PagerVibeMode)).Cast<PagerVibeMode>().Select(type =>
                     new { Value = type, Title = EnumHelper.GetDescription(type) }).ToList();
            cmbPagerVibeMode.ValueMember = "Value";
            cmbPagerVibeMode.DisplayMember = "Title";
            cmbPagerVibeMode.DataBindings.Add(new Binding("SelectedValue", ExternalInputRowModel, "PagerVibeMode", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbPagerVibeMode.DataBindings.Add(new Binding("Enabled", ExternalInputRowModel, "IsModeCmbEnabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerFlashMode.DataSource = Enum.GetValues(typeof(PagerFlashMode)).Cast<PagerFlashMode>().Select(type =>
                      new { Value = type, Title = EnumHelper.GetDescription(type) }).ToList();
            cmbPagerFlashMode.ValueMember = "Value";
            cmbPagerFlashMode.DisplayMember = "Title";
            cmbPagerFlashMode.DataBindings.Add(new Binding("SelectedValue", ExternalInputRowModel, "PagerFlashMode", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbPagerFlashMode.DataBindings.Add(new Binding("Enabled", ExternalInputRowModel, "IsModeCmbEnabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerMessage.DataSource = ExternalInputRowModel.StarMessage;
            cmbPagerMessage.DataBindings.Add(new Binding("SelectedItem", ExternalInputRowModel, "PagerIntMessage", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbPagerMessage.DataBindings.Add(new Binding("Enabled", ExternalInputRowModel, "IsMsgEnabled", true, DataSourceUpdateMode.OnPropertyChanged));

            txtMessage.DataBindings.Add(new Binding("Text", ExternalInputRowModel, "PagerStrMessage", true, DataSourceUpdateMode.OnPropertyChanged));
            txtMessage.DataBindings.Add(new Binding("Enabled", ExternalInputRowModel, "IsMsgEnabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagerFlashMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagerVibeMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagerMessage.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ProgramAlphaPager()
        {
            if (PagerType.ALPHA.Equals(ExternalInputRowModel.PagerType))
            {
                txtMessage.Visible = true;
                cmbPagerMessage.Visible = false;
            }
            else if (PagerType.STAR.Equals(ExternalInputRowModel.PagerType))
            {
                cmbPagerVibeMode.Visible = true;
                cmbPagerFlashMode.Visible = false;

                cmbPagerMessage.Visible = true;
                txtMessage.Visible = false;
            }
            else if (PagerType.GUEST.Equals(ExternalInputRowModel.PagerType))
            {
                if (cmbPagerMessage.Visible && txtMessage.Visible)
                {
                    txtMessage.Visible = false;
                }
                cmbPagerVibeMode.Visible = false;
                cmbPagerFlashMode.Visible = true;
            }
        }

        private void ExternalInputRowView_Load(object sender, EventArgs e)
        {
            BindControl();
        }

        private void cmbPagerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramAlphaPager();
        }
    }
}

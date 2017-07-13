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
    public partial class ButtonRowView : UserControl
    {
        public ButtonRowView()
        {
            InitializeComponent();
        }

        private ButtonRowModel buttonRowModel;

        public ButtonRowModel ButtonRowModel
        {
            get => buttonRowModel; set
            {
                buttonRowModel = value;
            }
        }

        private void ButtonRowView_Load(object sender, EventArgs e)
        {
            BindControl();
        }

        private void BindControl()
        {
            chkEnabled.DataBindings.Add(new Binding("Checked", ButtonRowModel, "Enabled", true, DataSourceUpdateMode.OnPropertyChanged));
            spinPagerNumber.DataBindings.Add(new Binding("Value", ButtonRowModel, "PagerNo", true, DataSourceUpdateMode.OnPropertyChanged));
            spinPagerNumber.DataBindings.Add(new Binding("Enabled", ButtonRowModel, "Enabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerType.DataSource = Enum.GetValues(typeof(PagerType)).Cast<PagerType>().Select(type =>
                    new { Value = type, Title = EnumHelper.GetDescription(type) }).ToList();
            cmbPagerType.ValueMember = "Value";
            cmbPagerType.DisplayMember = "Title";
            cmbPagerType.DataBindings.Add(new Binding("SelectedValue", ButtonRowModel, "PagerType", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbPagerType.DataBindings.Add(new Binding("Enabled", ButtonRowModel, "Enabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerVibeMode.DataSource = Enum.GetValues(typeof(PagerVibeMode)).Cast<PagerVibeMode>().Select(type =>
                     new { Value = type, Title = EnumHelper.GetDescription(type) }).ToList();
            cmbPagerVibeMode.ValueMember = "Value";
            cmbPagerVibeMode.DisplayMember = "Title";
            cmbPagerVibeMode.DataBindings.Add(new Binding("SelectedValue", ButtonRowModel, "PagerVibeMode", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbPagerVibeMode.DataBindings.Add(new Binding("Enabled", ButtonRowModel, "IsModeCmbEnabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerFlashMode.DataSource = Enum.GetValues(typeof(PagerFlashMode)).Cast<PagerFlashMode>().Select(type =>
                      new { Value = type, Title = EnumHelper.GetDescription(type) }).ToList();
            cmbPagerFlashMode.ValueMember = "Value";
            cmbPagerFlashMode.DisplayMember = "Title";
            cmbPagerFlashMode.DataBindings.Add(new Binding("SelectedValue", ButtonRowModel, "PagerFlashMode", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbPagerFlashMode.DataBindings.Add(new Binding("Enabled", ButtonRowModel, "IsModeCmbEnabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerMessage.DataSource = ButtonRowModel.StarMessage;
            cmbPagerMessage.DataBindings.Add(new Binding("SelectedItem", ButtonRowModel, "PagerIntMessage", true, DataSourceUpdateMode.OnPropertyChanged));
            cmbPagerMessage.DataBindings.Add(new Binding("Enabled", ButtonRowModel, "IsMsgEnabled", true, DataSourceUpdateMode.OnPropertyChanged));

            txtMessage.DataBindings.Add(new Binding("Text", ButtonRowModel, "PagerStrMessage", true, DataSourceUpdateMode.OnPropertyChanged));
            txtMessage.DataBindings.Add(new Binding("Enabled", ButtonRowModel, "IsMsgEnabled", true, DataSourceUpdateMode.OnPropertyChanged));

            cmbPagerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagerFlashMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagerVibeMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPagerMessage.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ProgramAlphaPager()
        {
            if (PagerType.ALPHA.Equals(ButtonRowModel.PagerType))
            {
                txtMessage.Visible = true;
                cmbPagerMessage.Visible = false;
            }
            else if (PagerType.STAR.Equals(ButtonRowModel.PagerType))
            {
                cmbPagerVibeMode.Visible = true;
                cmbPagerFlashMode.Visible = false;

                cmbPagerMessage.Visible = true;
                txtMessage.Visible = false;
            }
            else if (PagerType.GUEST.Equals(ButtonRowModel.PagerType))
            {
                if (cmbPagerMessage.Visible && txtMessage.Visible)
                {
                    txtMessage.Visible = false;
                }
                cmbPagerVibeMode.Visible = false;
                cmbPagerFlashMode.Visible = true;
            }
        }

        private void cmbPagerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramAlphaPager();
        }
    }
}

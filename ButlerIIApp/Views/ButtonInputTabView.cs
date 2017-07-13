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

namespace ButlerIIApp.Views
{
    public partial class ButtonInputTabView : UserControl
    {
        public ButtonInputTabView(ButtonInputTabModel buttonInputTabModel)
        {
            this.ButtonInputTabModel = buttonInputTabModel;
            InitializeComponent();
            BindControl();
        }

        private ButtonInputTabModel buttonInputTabModel;
        public ButtonInputTabModel ButtonInputTabModel
        {
            get => buttonInputTabModel; set
            {
                buttonInputTabModel = value;
            }
        }

        private void BindControl()
        {
            buttonRowView1.DataBindings.Add(new Binding("ButtonRowModel", ButtonInputTabModel.ButtonRowModel[0], "", true, DataSourceUpdateMode.OnPropertyChanged));
            buttonRowView2.DataBindings.Add(new Binding("ButtonRowModel", ButtonInputTabModel.ButtonRowModel[1], "", true, DataSourceUpdateMode.OnPropertyChanged));
            buttonRowView3.DataBindings.Add(new Binding("ButtonRowModel", ButtonInputTabModel.ButtonRowModel[2], "", true, DataSourceUpdateMode.OnPropertyChanged));
            buttonRowView4.DataBindings.Add(new Binding("ButtonRowModel", ButtonInputTabModel.ButtonRowModel[3], "", true, DataSourceUpdateMode.OnPropertyChanged));
            buttonRowView5.DataBindings.Add(new Binding("ButtonRowModel", ButtonInputTabModel.ButtonRowModel[4], "", true, DataSourceUpdateMode.OnPropertyChanged));
            externalInputRowView1.DataBindings.Add(new Binding("ExternalInputRowModel", ButtonInputTabModel, "ExternalInputModel", true, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}

using System;

namespace ButlerIIApp.Model
{
    public class ButtonInputTabModel
    {
        private ButtonRowModel[] buttonRowModel = new ButtonRowModel[] {
            new ButtonRowModel("BUT0"),
            new ButtonRowModel("BUT1") ,
            new ButtonRowModel("BUT2") ,
            new ButtonRowModel("BUT3"),
            new ButtonRowModel("BUT4")
        };

        private ExternalInputRowModel externalInputModel = new ExternalInputRowModel("INP0");

        public ExternalInputRowModel ExternalInputModel { get => externalInputModel; set => externalInputModel = value; }

        public ButtonRowModel[] ButtonRowModel { get => buttonRowModel; set => buttonRowModel = value; }

        public void Init(String[] data)
        {
            ButtonRowModel[0].Init(data[17]);
            ButtonRowModel[1].Init(data[18]);
            ButtonRowModel[2].Init(data[19]);
            ButtonRowModel[3].Init(data[20]);
            ButtonRowModel[4].Init(data[21]);
            ExternalInputModel.Init(data[15]);
        }
    }
}

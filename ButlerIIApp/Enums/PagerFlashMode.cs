using System.ComponentModel;

namespace ButlerIIApp.Enums
{
    public enum PagerFlashMode
    {
        [Description("1 Sec")]
        OneSec = 0,
        [Description("30 Sec")]
        ThirtySec = 1,
        [Description("5 Min")]
        FiveMin = 2
    }
}

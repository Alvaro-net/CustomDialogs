using DialogMessage.Dialogs.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DialogMessage.Dialogs.Model
{
    public class DialogModel
    {


        #region General dipose
        public string Title { get; set; } = "";
        public string Text { get; set; } = "";

        public bool ShowClose { get; set; } = false;

        public bool ShowIcon { get; set; } = false;

        public Geometry? Icon { get; set; }

        public Brush Background { get; set; } = new SolidColorBrush(Colors.WhiteSmoke);

        public Brush Border { get; set; } = new SolidColorBrush(Colors.Black);

        public Brush Foreground { get; set; } = new SolidColorBrush(Colors.Black);

        public int TitleFontSize { get; set; } = 21;

        public int FontSize { get; set; } = 21;

        public FontFamily FontFamily { get; set; } = new FontFamily("Roboto");

        public int CornerRadius { get; set; } = 5;

        public int BorderThickness { get; set; } = 0;

        #endregion

        #region Buttons Configuration
        public bool ShowTwoButtons { get; set; } = true;

        public bool ShowInverted { get; set; } = false;

        public Brush ClieckedButtonBackround { get; set; } = new SolidColorBrush(Colors.White);

        public Brush ClieckedButtonBorder { get; set; } = "#272727".ToBrush();

        public int ClieckedButtonBorderThickness { get; set; } = 2;

        #endregion

        #region OKButton

        public string OKText { get; set; } = "OK";

        public Brush OKBackground { get; set; } = "#e7e7e7".ToBrush();

        public Brush OKBorder { get; set; } = "#e7e7e7".ToBrush();

        public Brush OKForeground { get; set; } = new SolidColorBrush(Colors.Black);

        public FontFamily OKFontFamily { get; set; } = new FontFamily("Roboto");

        public int OKBorderThickness { get; set; } = 0;

        #endregion

        #region CancelButton

        public string CancelText { get; set; } = "CANCEL";

        public Brush CancelBackground { get; set; } = "#e7e7e7".ToBrush();

        public Brush CancelBorder { get; set; } = "#e7e7e7".ToBrush();

        public Brush CancelForeground { get; set; } = new SolidColorBrush(Colors.Black);

        public FontFamily CancelFontFamily { get; set; } = new FontFamily("Roboto");

        public int CancelBorderThickness { get; set; } = 0;

        #endregion
    }
}

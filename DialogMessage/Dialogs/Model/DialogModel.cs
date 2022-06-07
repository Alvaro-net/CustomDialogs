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

        public Brush Background { get; set; } = new SolidColorBrush(Colors.White);

        public Brush Border { get; set; } = new SolidColorBrush(Colors.White);

        public Brush Foreground { get; set; } = new SolidColorBrush(Colors.Black);

        public int TitleFontSize { get; set; } = 24;

        public int FontSize { get; set; } = 20;

        public FontFamily FontFamily { get; set; } = new FontFamily("Arial");

        public int CornerRadius { get; set; } = 0;

        public int BorderThickness { get; set; } = 0;

        #endregion

        #region Buttons Configuration
        public bool ShowTwoButtons { get; set; } = true;

        public bool ShowInverted { get; set; } = false;
        #endregion

        #region OKButton

        public string OKText { get; set; }

        public Brush OKBackground { get; set; } = new SolidColorBrush(Colors.Gray);

        public Brush OKBorder { get; set; } = new SolidColorBrush(Colors.Gray);

        public Brush OKForeground { get; set; } = new SolidColorBrush(Colors.Black);

        public FontFamily OKFontFamily { get; set; } = new FontFamily("Arial");

        public int OKBorderThickness { get; set; } = 0;

        #endregion

        #region CancelButton

        public string CancelText { get; set; }

        public Brush CancelBackground { get; set; } = new SolidColorBrush(Colors.Gray);

        public Brush CancelBorder { get; set; } = new SolidColorBrush(Colors.Gray);

        public Brush CancelForeground { get; set; } = new SolidColorBrush(Colors.Black);

        public FontFamily CancelFontFamily { get; set; } = new FontFamily("Arial");

        public int CancelBorderThickness { get; set; } = 0;

        #endregion
    }
}

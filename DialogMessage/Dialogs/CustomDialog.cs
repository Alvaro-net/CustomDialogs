using DialogMessage.Dialogs.Model;
using DialogMessage.Dialogs.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogMessage.Dialogs
{
    public class CustomDialog
    {
        public static bool? ShowMessage(DialogModel dialogModel)
        {
            return new Dialog(dialogModel).ShowDialog();
        }
    }
}

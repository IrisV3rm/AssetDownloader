using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetDownloader
{
    class Forms
    {
        public static DialogResult Notify(string Message, bool YN, bool OK)
        {
            return new Notice(Message, YN, OK).ShowDialog();
        }
    }
}

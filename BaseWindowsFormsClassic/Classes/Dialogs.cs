using System.Diagnostics;
using System.Windows.Forms;

namespace BaseWindowsFormsClassic.Classes
{
    public static class Dialogs
    {
        [DebuggerStepThrough]
        public static bool Question(string text) => 
            (MessageBox.Show(text, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        
        [DebuggerStepThrough]
        public static bool Question(string text, string tile) => 
            (MessageBox.Show(text, tile, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
    }
}
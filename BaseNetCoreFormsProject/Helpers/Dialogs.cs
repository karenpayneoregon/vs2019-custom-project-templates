using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.MessageBox;

namespace BaseNetCoreFormsProject.Helpers
{
    public static class Dialogs
    {
        /// <summary>
        /// Ask a question with No as the default button
        /// </summary>
        /// <param name="pMessage">Message to display</param>
        /// <param name="pTitle">Title which defaults to 'Question'</param>
        /// <returns></returns>
        public static bool Question(string pMessage, string pTitle = "Question") =>
            (Show(pMessage, @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);

        /// <summary>
        /// Ask a question with the ability to define the default button to Yes or No
        /// </summary>
        /// <param name="pMessage">Message to display</param>
        /// <param name="pTitle">Title for message box</param>
        /// <param name="pDefaultButton"></param>
        /// <returns></returns>
        public static bool Question(string pMessage, string pTitle, DialogResult pDefaultButton)
        {
            MessageBoxDefaultButton db = 0;
            
            if (pDefaultButton == DialogResult.No)
            {
                db = MessageBoxDefaultButton.Button2;
            }
            
            return (Show(pMessage, pTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, db) == DialogResult.Yes);
        }

        /// <summary>
        /// Present a message without an icon
        /// </summary>
        /// <param name="pMessage">Message to display</param>
        /// <param name="pTitle">Dialog title</param>
        /// <remarks>
        /// No icon means no sound
        /// </remarks>
        public static void MessageBox(string pMessage, string pTitle = "Alert")
        {
            Show(pMessage, pTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        /// <summary>
        /// Present a message with an information icon
        /// </summary>
        /// <param name="pMessage">Message to display</param>
        public static void InformationDialog(string pMessage)
        {
            Show(pMessage, @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Present a message with an information icon
        /// </summary>
        /// <param name="pMessage">Message to display</param>
        /// <param name="pTitle">Dialog title</param>
        public static void InformationDialog(string pMessage, string pTitle)
        {
            Show(pMessage, pTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

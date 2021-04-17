using System;
using System.Windows;
using static System.Windows.MessageBox;

namespace BaseNetCoreWpfAppProject.Helpers
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
            (Show(pMessage, pTitle, MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes);

        /// <summary>
        /// Ask a question with the ability to define the default button to Yes or No
        /// </summary>
        /// <param name="pMessage">Message to display</param>
        /// <param name="pTitle">Dialog title</param>
        /// <param name="defaultButton"></param>
        /// <returns></returns>
        public static bool Question(string pMessage, string pTitle, MessageBoxResult defaultButton)
        {
            MessageBoxResult button = 0;
            if (defaultButton == MessageBoxResult.No)
            {
                button = MessageBoxResult.No;
            }

            return (Show(pMessage, pTitle, MessageBoxButton.YesNo, MessageBoxImage.Question, button) == MessageBoxResult.Yes);
        }
        /// <summary>
        /// Ask a question with OK and Cancel where the default button is Cancel
        /// </summary>
        /// <param name="pMessage">Message to display</param>
        /// <param name="pTitle">Dialog title</param>
        /// <param name="defaultButton"></param>
        /// <returns></returns>
        public static bool QuestionWithCancel(string pMessage, string pTitle, MessageBoxResult defaultButton = MessageBoxResult.Cancel) => 
            Show(pMessage, pTitle, MessageBoxButton.OKCancel, MessageBoxImage.Question, defaultButton) == MessageBoxResult.OK;

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
            Show(pMessage, pTitle, MessageBoxButton.OK, MessageBoxImage.None);
        }
        /// <summary>
        /// Present a message without an icon
        /// </summary>
        /// <param name="pMessage">Message to display</param>
        public static void InformationDialog(string pMessage)
        {
            Show(pMessage, "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Present a message without an icon
        /// </summary>
        /// <param name="pMessage">Message to display</param>
        /// <param name="pTitle">Dialog title</param>
        public static void InformationDialog(string pMessage, string pTitle)
        {
            Show(pMessage, pTitle, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

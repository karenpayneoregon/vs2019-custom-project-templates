using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static BaseNetCoreWpfAppProject.Helpers.Dialogs;

namespace BaseNetCoreWpfAppProject
{
    
    public partial class MainWindow : Window
    {
        public static RoutedCommand ExitRoutedCommand = new RoutedCommand();
        public MainWindow()
        {
            InitializeComponent();

            CommandBindings.Add(new CommandBinding(
                ExitRoutedCommand,
                ExitApplicationCommandOnExecute,
                ApplicationExitCanExecute));
            
        }
        private void ExitApplicationCommandOnExecute(object sender, ExecutedRoutedEventArgs e)
        {
            if (Question("Leave?"))
            {
                Application.Current.Shutdown();
            }
        }

        private void ApplicationExitCanExecute(object sender, CanExecuteRoutedEventArgs e) =>
            e.CanExecute = true;
    }
}

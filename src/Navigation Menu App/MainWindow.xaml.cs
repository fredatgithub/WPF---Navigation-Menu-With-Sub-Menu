using System.Windows;

namespace Navigation_Menu_App
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void MaxBtn_Click(object sender, RoutedEventArgs e)
    {
      if (WindowState == WindowState.Normal)
      {
        WindowState = WindowState.Maximized;
      }
      else
      {
        if (WindowState == WindowState.Maximized)
        {
          WindowState = WindowState.Normal;
        }
      }
    }

    private void CloseBtn_Click(object sender, RoutedEventArgs e)
    {
      Close();
    }
  }
}

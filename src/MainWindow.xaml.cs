using System.Windows;

namespace Lucy101;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    private MainviewModel _model = new MainviewModel();
    public MainWindow()
    {
        InitializeComponent();
        DataContext = _model;
        this.KeyDown += _model.HandleKey;
    }
}

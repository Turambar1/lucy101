using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Lucy101;
public class MainviewModel : ViewModelBase
{
private Piano _piano = new();

private List<Color> _colors = new List<Color> 
{
    Colors.AliceBlue, Colors.Red, Colors.Blue, Colors.Green, Colors.Yellow, Colors.Brown
};

private Brush? _background; 
public Brush? Background { get => _background; set => SetProperty(ref _background, value); }

private string? _infoText; 
public string? InfoText { get => _infoText; set => SetProperty(ref _infoText, value); }

    public void HandleKey(object sender, KeyEventArgs e)
    {
        var keyAsInt = (int)e.Key;
        _piano.PlayNote(keyAsInt);
        Background = new SolidColorBrush(_colors[keyAsInt % (_colors.Count - 1)]);
        InfoText = e.Key.ToString() + "-" + keyAsInt;
        e.Handled = true; 
    }
}
using System.Windows;
namespace ArrayFormatter;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        inputTxtBx.Focus();
    }

    private void ProcessButton_Click(object sender, RoutedEventArgs e)
    {
        string inputText = inputTxtBx.Text;
        FormattingOptions options = new()
        {
            OldHorizontalDelimiter = ohdTxtBox.Text,
            NewHorizontalDelimiter = nhdTxtBox.Text,
            OldVerticalDelimiter = ovdTxtBox.Text,
            NewVerticalDelimiter = nvdTxtBox.Text,
            TextToRemoveBefore = removeBeforeTxtBox.Text,
            TextToAddBefore = addBeforeTxtBox.Text,
            TextToRemoveAfter = removeAfterTxtBox.Text,
            TextToAddAfter = addAfterTxtBox.Text
        };
        string outputText = FormattingTools.FormatInputText(inputText, options);
        outputTxtBx.Text = outputText;
        outputTxtBx.Focus();
        outputTxtBx.SelectAll();
    }

}

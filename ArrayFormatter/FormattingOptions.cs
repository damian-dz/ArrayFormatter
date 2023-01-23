namespace ArrayFormatter;

public struct FormattingOptions
{
    public string OldHorizontalDelimiter { get; set; }
    public string NewHorizontalDelimiter { get; set; }
    public string OldVerticalDelimiter { get; set; }
    public string NewVerticalDelimiter { get; set; }
    public string TextToRemoveBefore { get; set; }
    public string TextToAddBefore { get; set; }
    public string TextToRemoveAfter { get; set; }
    public string TextToAddAfter { get; set; }
}

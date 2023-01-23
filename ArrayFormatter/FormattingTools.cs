using System;
using System.Collections.Generic;

namespace ArrayFormatter;

public static class FormattingTools
{
    public static string FormatInputText(string inputText, FormattingOptions options)
    {
        string oldVerDel = ReplaceNewLines(options.OldVerticalDelimiter);
        string oldHorDel = ReplaceNewLines(options.OldHorizontalDelimiter);
        string newVerDel = ReplaceNewLines(options.NewVerticalDelimiter);
        string newHorDel = ReplaceNewLines(options.NewHorizontalDelimiter);

        string removeBefore = options.TextToRemoveBefore;
        string removeAfter = options.TextToRemoveAfter;
        string addBefore = options.TextToAddBefore;
        string addAfter = options.TextToAddAfter;

        string[] rows = inputText.Split(oldVerDel);
        var newRows = new List<string>();
        foreach (string row in rows)
        {
            string[] cells = row.Split(oldHorDel);
            for (int i = 0; i < cells.Length; i++)
            {
                cells[i] = RemoveTextBefore(cells[i], removeBefore);
                cells[i] = RemoveTextAfter(cells[i], removeAfter);
                cells[i] = addBefore + cells[i] + addAfter;
            }
            newRows.Add(string.Join(newHorDel, cells));
        }

        return string.Join(newVerDel, newRows.ToArray());
    }

    private static string ReplaceNewLines(string old)
    {
        return old
            .Replace(@"\r\n", Environment.NewLine)
            .Replace(@"\n", Environment.NewLine);
    }

    private static string RemoveTextBefore(string old, string textToRemove)
    {
        int idx = old.IndexOf(textToRemove);
        if (idx == 0)
            return old[textToRemove.Length..];
        return old;
    }

    private static string RemoveTextAfter(string old, string textToRemove)
    {
        int idx = old.LastIndexOf(textToRemove);
        if (idx + textToRemove.Length == old.Length)
            return old[..idx];
        return old;
    }

}

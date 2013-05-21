// Copyright Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Documents;
using System.Windows.Controls;

namespace Microsoft.Samples.SqlServer.ExtensionMethods
{
    public static class RichTextBoxExtensions
    {
        public static string DocumentText(this RichTextBox richTextBox)
        {
            TextRange range;
            range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

            return range.Text;
        }
        public static void DocumentText(this RichTextBox richTextBox, string text)
        {
            TextRange range;
            range = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

            range.Text = text;
        }
    }

  public static class StringExtensions
  {
    public static string QuotedValue(this String value)
    {
      value = value != null ? value : string.Empty;
      return "\"" + value + "\"";
    }

    public static string NonQuotedValue(this String value)
    {
      value = value != null ? value : string.Empty;
      return value.Replace("\"", string.Empty);
    }
  }
}

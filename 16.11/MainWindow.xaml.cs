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

namespace _16._11
{
    public partial class MainWindow : Window
    {
        private void ApplyFormatting(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(StartIndexInput.Text, out int start) && int.TryParse(EndIndexInput.Text, out int end))
            {
                if (start >= 0 && end <= new TextRange(MainRichTextBox.Document.ContentStart, MainRichTextBox.Document.ContentEnd).Text.Length && start <= end)
                {
                    TextRange range = new TextRange(MainRichTextBox.Document.ContentStart, MainRichTextBox.Document.ContentEnd);
                    range.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                    range.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);

                    TextPointer startPointer = MainRichTextBox.Document.ContentStart.GetPositionAtOffset(start, LogicalDirection.Forward);
                    TextPointer endPointer = MainRichTextBox.Document.ContentStart.GetPositionAtOffset(end, LogicalDirection.Backward);
                    TextRange selectedRange = new TextRange(startPointer, endPointer);

                    if ((sender as Button).Name == "BoldButton")
                        selectedRange.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                    else if ((sender as Button).Name == "ItalicButton")
                        selectedRange.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
                    else if ((sender as Button).Name == "UnderlineButton")
                        selectedRange.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
                }
            }
        }

        private void ClearFormatting(object sender, RoutedEventArgs e)
        {
            TextRange range = new TextRange(MainRichTextBox.Document.ContentStart, MainRichTextBox.Document.ContentEnd);
            range.ClearAllProperties();
        }
    }
}


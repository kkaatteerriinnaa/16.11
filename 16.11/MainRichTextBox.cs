using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Documents;

namespace _16._11
{
    public partial class MainWindow
    {
        private RichTextBox MainRichTextBox;

        public MainWindow()
        {
            InitializeComponent();


            MainRichTextBox = new RichTextBox
            {
                Name = "MainRichTextBox",
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };

            // Добавление RichTextBox на главное окно
            this.Content = MainRichTextBox;
        }
    }
}

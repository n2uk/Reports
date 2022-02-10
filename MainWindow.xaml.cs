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
using Word = Microsoft.Office.Interop.Word;

namespace WpfApp1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var app = new Word.Application();
            app.Visible = false;
            app.Documents.Open(Environment.CurrentDirectory + "\\TEMPLATE5.docx");

            object findText = "ПРИЛОЖЕНИЕ";
            object missing = Type.Missing;
            Object wrap = Word.WdFindWrap.wdFindContinue;
            Object replace = Word.WdReplace.wdReplaceAll;

            app.Selection.Find.ClearFormatting();

            Word.Find find = app.Selection.Find;
            find.Text = "ПРИЛОЖЕНИЕ";
            find.Replacement.Text = "ХРЕЛОЖЕНИЕ";
            find.Execute(FindText: Type.Missing,
                foreach( )
           MatchCase: false,
           MatchWholeWord: false,
           MatchWildcards: false,
           MatchSoundsLike: missing,
           MatchAllWordForms: false,
           Forward: true,
           Wrap: wrap,
           Format: false,
           ReplaceWith: missing, Replace: replace);

            app.Documents.Save();
            app.Documents.Close();
            app.Quit();
        }
    }
}

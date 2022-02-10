using Archiving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Word = Microsoft.Office.Interop.Word;


namespace WpfApp1
{
    internal class Template6
    {
        public string Template6Create(string f)
        {
            TTN ttn = new TTN();
            var test = typeof(TTN).GetProperties();
            var app = new Word.Application();
            app.Visible = false;
            var wd = app.Documents.Open(Environment.CurrentDirectory + "\\TEMPLATE6.docx");
            wd.SaveAs2(Environment.CurrentDirectory + "\\1TEMPLATE6.docx");
            foreach (PropertyInfo pi in test)
            {
                if (((((DataParam)pi.GetValue(ttn)).Tag != null)) && (((DataParam)pi.GetValue(ttn)).TypeOfReports == "5"))
                {

                    object missing = Type.Missing;
                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    app.Selection.Find.ClearFormatting();
                    Word.Find find = app.Selection.Find;

                    find.Text = ((DataParam)pi.GetValue(ttn)).Tag;
                    find.Replacement.Text = ((DataParam)pi.GetValue(ttn)).Title;
                    find.Execute(FindText: Type.Missing,
                   MatchCase: false,
                   MatchWholeWord: false,
                   MatchWildcards: false,
                   MatchSoundsLike: missing,
                   MatchAllWordForms: false,
                   Forward: true,
                   Wrap: wrap,
                   Format: false,
                   ReplaceWith: missing, Replace: replace);
                    //что-то написал 

                }
            }

            wd.ExportAsFixedFormat(Environment.CurrentDirectory + "\\tickets\\ticket6" + ttn.TtnN.Value + ".PDF", Word.WdExportFormat.wdExportFormatPDF);


            app.Documents.Close();
            app.Quit();
            return "";
        }
    }
}

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
        public string Template6Create(string bidNum, string cargoDocuments, string transporter, string carModel, string plateNumber,
            string cargoConditionR, string cargoConditionS, string anotherCondition)
        {
            string[] methodMassive = { bidNum="Номер заявки", cargoDocuments="Сопроводительные документы",
                transporter="перевозчик", carModel="Транспортное средство", plateNumber="Номера", cargoConditionR="Состояние перевозчика получатель",
                cargoConditionS="Отправитель", anotherCondition="Другие условия"};
            string[] parameterMassive = { "<BID_NUM>", "<CARGO_DOCUMENTS>", "<TRANSPORTER>", "<CAR_MODEL>", "<PLATE_NUMBER>", "<CARGO_CONDITION_R>", "<CARGO_CONDITION_S>", "<ANOTHER_CONDITION>" };
            TTN ttn = new TTN();
            var test = typeof(TTN).GetProperties();
            var app = new Word.Application();
            app.Visible = false;
            object missing = Type.Missing;
            Object wrap = Word.WdFindWrap.wdFindContinue;
            Object replace = Word.WdReplace.wdReplaceAll;


            var wd = app.Documents.Open(Environment.CurrentDirectory + "\\TEMPLATE6.docx");
            wd.SaveAs2(Environment.CurrentDirectory + "\\1TEMPLATE6.docx");
            foreach (PropertyInfo pi in test)
            {
                if ((((((DataParam)pi.GetValue(ttn)).Tag != null))) && (((DataParam)pi.GetValue(ttn)).TypeOfReports != null))
                {
                    foreach (char s in ((DataParam)pi.GetValue(ttn)).TypeOfReports)
                    {
                        if (s == '6')
                        {
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

                        }
                    }
                }
            }
            for (int i = 0; i < methodMassive.Length; i++)
            {
                Word.Find newFind = app.Selection.Find;
                newFind.Text = parameterMassive[i];
                newFind.Replacement.Text = methodMassive[i];
                newFind.Execute(FindText: Type.Missing,
                MatchCase: false,
                MatchWholeWord: false,
                MatchWildcards: false,
                MatchSoundsLike: missing,
                MatchAllWordForms: false,
                Forward: true,
                Wrap: wrap,
                Format: false,
                ReplaceWith: missing, Replace: replace);

            }
            wd.ExportAsFixedFormat(Environment.CurrentDirectory + "\\tickets\\ticket6" + ttn.TtnN.Value + ".PDF", Word.WdExportFormat.wdExportFormatPDF);
            app.Documents.Close();
            app.Quit();
            return "";
        }
    }
}

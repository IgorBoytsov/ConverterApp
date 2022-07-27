using ConverterApp.Pages;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Spire.Doc;
using Spire.Doc.Documents;




namespace ConverterApp.Method
{
    public static class Converting
    {
       // static public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }
        static public string str = (string)App.Current.Resources["filePath"];
        static public string NameFile = (string)App.Current.Resources["nameFileWordToPDF"];
        static Spire.Doc.Document document = new Spire.Doc.Document();
        static MainWindow mainWindow = new MainWindow();

        // Converet Word Methods

        static public void WordToPDF()
        {
            Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document wordDocument;

            wordDocument = appWord.Documents.Open(str);
            wordDocument.ExportAsFixedFormat($@"D:{NameFile}.PDF", WdExportFormat.wdExportFormatPDF);
            MessageBox.Show("Файл конвертирован!");
        }


        static public void WortToTXT()
        {
            document.LoadFromFile(str);
            document.SaveToFile($@"D:\{NameFile}.txt", FileFormat.Txt);
        }

        static public void WordToEpub()
        {
            if (mainWindow.ChekBoxArhive.IsChecked == true)
            {
               //Добавить реализацию сохранение файлов в архив
            }
            document.LoadFromFile(str);
            document.SaveToFile($@"D:\{NameFile}.EPub", FileFormat.EPub);
        }

        // Converet PDF Methods

        static public void PDFToWord()
        {
            SautinSoft.PdfFocus doc = new SautinSoft.PdfFocus();
            doc.OpenPdf(str);

            if (doc.PageCount > 0)
            {
                int result = doc.ToWord($@"d:\{NameFile}.docx");

                if (result == 0)
                {
                    System.Diagnostics.Process.Start($@"d:\{NameFile}.docx");
                }
                MessageBox.Show("Файл конвертирован!");
            }
        }

        // Converet PNG Methods

        static public void PNGToJPG()
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(str);
            image.Save($@"d:\{NameFile}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Файл конвертирован!");
        }

        static public void PNGToICO()
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(str);
            image.Save($@"d:\{NameFile}.jpg", System.Drawing.Imaging.ImageFormat.Icon);
            MessageBox.Show("Файл конвертирован!");
        }

        static public void PNGToBMP()
        {

        }

        static public void PNGToWebP()
        {

        }

        static public void PNGToSVG()
        {

        }
        // Converet JPG Methods

        static public void JPGToPNG()
        {
            System.Drawing.Image image1 = System.Drawing.Image.FromFile(str);
            image1.Save($@"d:\{NameFile}.png", System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Файл конвертирован!");
        }
    }

}

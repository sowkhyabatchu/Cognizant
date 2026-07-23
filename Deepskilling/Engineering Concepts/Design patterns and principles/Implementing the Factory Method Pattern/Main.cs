using System;

class MainClass
{
    static void Main(string[] args)
    {
        DocumentFactory pdfFactory = new PdfDocumentFactory();
        Document pdf = pdfFactory.CreateDocument();
        pdf.Open();

        DocumentFactory wordFactory = new WordDocumentFactory();
        Document word = wordFactory.CreateDocument();
        word.Open();

        DocumentFactory excelFactory = new ExcelDocumentFactory();
        Document excel = excelFactory.CreateDocument();
        excel.Open();
    }
}

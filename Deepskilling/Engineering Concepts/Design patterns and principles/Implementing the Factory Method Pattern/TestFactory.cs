using System;

public class TestFactory
{
    public static void Test()
    {
        DocumentFactory[] factories =
        {
            new PdfDocumentFactory(),
            new WordDocumentFactory(),
            new ExcelDocumentFactory()
        };

        foreach (DocumentFactory factory in factories)
        {
            Document document = factory.CreateDocument();
            document.Open();
        }
    }
}

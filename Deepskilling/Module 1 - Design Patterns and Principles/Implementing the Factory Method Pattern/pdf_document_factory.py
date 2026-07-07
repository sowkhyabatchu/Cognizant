from document_factory import DocumentFactory
from pdf_document import PdfDocument

class PdfDocumentFactory(DocumentFactory):

    def create_document(self):
        return PdfDocument()

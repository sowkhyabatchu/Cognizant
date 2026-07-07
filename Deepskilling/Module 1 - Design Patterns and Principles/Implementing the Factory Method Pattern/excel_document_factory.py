from document_factory import DocumentFactory
from excel_document import ExcelDocument

class ExcelDocumentFactory(DocumentFactory):

    def create_document(self):
        return ExcelDocument()

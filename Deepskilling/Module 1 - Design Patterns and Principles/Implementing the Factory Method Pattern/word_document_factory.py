from document_factory import DocumentFactory
from word_document import WordDocument

class WordDocumentFactory(DocumentFactory):

    def create_document(self):
        return WordDocument()

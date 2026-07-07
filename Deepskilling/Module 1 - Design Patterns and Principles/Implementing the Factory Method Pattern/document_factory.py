from abc import ABC, abstractmethod

class DocumentFactory(ABC):

    @abstractmethod
    def create_document(self):
        pass

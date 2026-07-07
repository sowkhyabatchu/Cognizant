from abc import ABC, abstractmethod

class Document(ABC):

    @abstractmethod
    def open(self):
        pass

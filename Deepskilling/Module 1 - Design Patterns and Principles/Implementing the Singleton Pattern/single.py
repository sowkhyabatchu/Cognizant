class Singleton:
    _instance = None

    def __new__(cls):
        if cls._instance is None:
            print("Creating Singleton Object...")
            cls._instance = super().__new__(cls)
        return cls._instance

    def show_message(self):
        print("This is the Singleton object.")

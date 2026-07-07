from single import Singleton

obj1 = Singleton()
obj2 = Singleton()

obj1.show_message()
obj2.show_message()

print("Are both objects the same?", obj1 is obj2)

# Import from MyClass 
from MyClass import Car

car_a =Car("Aqua")
car_b = Car("Blue")

car_a.print_car()
car_b.print_car()


print("\ndirectly")
print (car_a.color,car_a.car_type, Car.car_type)
print (car_b.color,car_b.car_type, Car.car_type)

car_a.color="Amber"
car_b.color="Brown"


car_a.print_car()
car_b.print_car()

Car.car_type="Standard"

car_a.print_car()
car_b.print_car()


Car.color="bad color"
car_a.print_car()
car_b.print_car()


print (Car.color)

age = 21 #integer
name = "21 first" # string
temp = 10.2 #float
print (type(temp))

for list in name:
    print (list)


b = "Hello, World!"
print(b[2:5])

b = "Hello, World!"
print(b[:5])

b = "Hello, World!"
print(b[-5:-2])

age = 25
txt = "My name is John, I am {age}" 
print(txt.format (age=25))


myorder = "I have a {carname}, it is a {model}."
print(myorder.format(carname = "Ford", model = "Mustang"))



def myfunc(n):
      return lambda a : a * n

mydoubler = myfunc(3)

print(mydoubler(11))
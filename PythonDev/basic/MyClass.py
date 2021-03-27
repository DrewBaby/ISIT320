class Car:
    __car_type = "Sports"

    def __init__(self, color):
        self.color = color

    def print_car(self):
        print(self.color,
        "\t", self.__car_type,
        "\t", Car.__car_type,
        )
#    def get_color(self):
#        return self.color
    
#    def set_color(self,color):
#         self.color = color

    @property
    def car_type (self):
            return self.__car_type
    @car_type.setter
    def car_type(self, car_type):
        self.__car_type = car_type
    
echo
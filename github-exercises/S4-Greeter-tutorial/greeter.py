from sense_hat import SenseHat


class Greeter:
    def __init__(self):
        self.sense_hat = SenseHat()

    def greet_user(self):
        self.sense_hat.show_message("Hello, world!", scroll_speed=0.05)


if __name__ == "__main__":
    # Instantiate a Greeter object
    greeter = Greeter()

    # Call the instance method {greet_user}
    greeter.greet_user()

# to run please use simulator - https://trinket.io/sense-hat

def get_initials(fullname):
    """ Given a person's name, returns the person's initials (uppercase) """
    # TODO your code here
    initials = ''
    list_of_names = fullname.split()
    for init in list_of_names:
        initials += init[0]
    return initials.upper()

def main():
    fullname = input("What is yout full name?\n")
    print(get_initials(fullname))

if __name__ == "__main__":
    main()
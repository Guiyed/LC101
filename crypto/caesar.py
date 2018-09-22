from helpers import alphabet_position, rotate_character

def encrypt(text, rot):
    crypted_text = ''
    for char in text:
        crypted_text += rotate_character(char, rot)
    return crypted_text



def main():
    from sys import argv, exit    

    ##### Programa Con Validacion (Bonus Mission) ###    
    if len(argv) > 1 and argv[1].isdigit():
        message = input(" Please type your message:\n  ")
        rotation = int(argv[1])
    else:
        print('usage: python caesar.py n')
        exit()        
    print(' Your coded Message is:\n  ' + encrypt(message,rotation))

    ##### Asi tenia el programa antes de validar y estaba corriendo###
    '''
    #print("This is what the user typed on the command line:", argv)
    message = input(" Please type your message:\n  ")
    
    if len(argv) > 1 and argv[1]!= None:
        rotation = int(argv[1])
    else:
        rotation = int(input(" How many rotations do you wan in the Caesar algorithm:\n  "))
    print(' Your coded Message is:\n  ' + encrypt(message,rotation))
    '''

if __name__ == "__main__":
    main()
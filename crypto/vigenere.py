from helpers import alphabet_position, rotate_character

def cypher(message  ='', key = 'a'):
    crypted_message = ''
    key_lenght = len(key)
    key_index_count = 0
    
    for char in message:
        crypted_message += rotate_character(char, alphabet_position(key[key_index_count]))
        if char.isalpha():
            if key_index_count < key_lenght-1:
                key_index_count +=1
            else:
                key_index_count = 0               
    
    return crypted_message

def encrypt(message  ='', key = 'a'):
    crypted_message = ''
    key_lenght = len(key)
    key_index_count = 0
    
    for char in message:
        crypted_message += rotate_character(char, alphabet_position(key[key_index_count]))
        if char.isalpha():
            if key_index_count < key_lenght-1:
                key_index_count +=1
            else:
                key_index_count = 0               
    
    return crypted_message

def main():
    from sys import argv
    
     ##### Programa Con Validacion (Bonus Mission) ###    
    if len(argv) > 1 and argv[1].isalpha():
        message = input(" Type the Message you want to cypher:\n  ")
        key = (argv[1])
    else:
        print('''  usage: python vigenere.py keyword
        Arguments:
        -keyword : The string to be used as a "key" to encrypt your message. 
        Should only contain alphabetic characters-- no numbers or special characters.''')
        exit()        
    print(' Your coded Message is:\n  ' + cypher(message,key))

    ##### Asi tenia el programa antes de validar y estaba corriendo###
    '''
    
    message = input(" Type the Message you want to cypher:\n  ") 
    
    if len(argv) > 1 and argv[1]!= None:
        key = argv[1]
    else:    
        key = input(" Type the Encryption key:\n  ")   
    print(' Your coded Message is:\n  ' + cypher(message,key))

    '''

if __name__ == "__main__":
    main()
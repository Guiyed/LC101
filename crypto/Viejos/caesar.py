

def alphabet_position(letter):
    alphabet = 'abcdefghijklmnopqrstuvwxyz'
    index = alphabet.find(letter.lower())
    return index

def rotate_character(char, rot):
    alpha = 'abcdefghijklmnopqrstuvwxyz'
    alphaUpper = alpha.upper()
    rotated_index = alphabet_position(char) + rot
        
    if char in alpha:
        rotated_char = alpha[rotated_index % 26]
    elif char in alphaUpper:
        rotated_char = alphaUpper[rotated_index % 26]
    else:
        rotated_char = char
    
    return rotated_char

def encrypt(text, rot):
    crypted_text = ''
    for char in text:
        crypted_text += rotate_character(char, rot)
    return crypted_text





def main():
    message = input("Please type your message:")
    rotation = int(input("How many rotations do you wan in the Caesar algorithm:"))
    print('Your coded Message is: ' + encrypt(message,rotation))

if __name__ == "__main__":
    main()
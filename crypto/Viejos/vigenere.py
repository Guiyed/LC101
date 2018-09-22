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

def cypher(message, key):
    crypted_message = ''
    key_lenght = len(key)

    for char in message:
        key_dictionary[char]= 



    for char in text:
        crypted_text += rotate_character(char, alphabet_position(key[count])
        if count < key_lenght:
            count +=1
        
    return crypted_text

    return crypted_message
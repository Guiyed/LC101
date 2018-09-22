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
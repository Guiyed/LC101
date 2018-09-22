test_string = ('Lorem ipsum dolor sit amet, consectetur adipiscing elit. ' 
+ 'Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. ' 
+ 'Praesent quis rhoncus justo. Aliquam erat volutpat. '
+ 'Donec sit amet suscipit metus, non lobortis massa. '
+ 'Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. ' 
+ 'onec nec velit non ligula efficitur luctus.')

def counting(text):
    dictionary = {}
    for char in text:
        if dictionary.get(char) == None:
            dictionary[char]=1
        else:
            dictionary[char]+=1
    for (letter,count) in dictionary.items():
        print(letter , ':', count)

def main():
    paragraph = input("Please introduce the Paragraph to analize: \n")
    
    if paragraph == '':
        print('No valid text so we are using the default or example string:\n', test_string)
        paragraph = test_string

    counting(paragraph)

if __name__ == '__main__':
    main()
   
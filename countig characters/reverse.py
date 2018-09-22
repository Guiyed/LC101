def reverse(dictio):
    new_dict = {}

    for (keys,values) in dictio.items():
        if type(values) != list:
            new_dict[values] = new_dict.get(values,[])
            new_dict[values].append(keys)
        else:
            for value in values:
                new_dict[value] = new_dict.get(value,[])
                new_dict[value].append(keys)
    
    return new_dict

    #inv_map = dict((my_map[k], k) for k in my_map)

def main():    
    #test_dict = {1:'1', 2:'a', 'A': 'b', 'name': 'Guille', "pears": 32, 3: 'a'}
    test_dict = {1:'1', 2:'a', 'A': 'b', 'name': 'Guille', "pears": 32, 3:'a', 'Movies':['uno','dos']}
    reversed_dict = {}
    
    '''
    reversed_dict = reverse(test_dict)
    print(test_dict)
    print(reversed_dict)
    '''
    print("Original Dict")
    for (keys,vals) in test_dict.items():
        print(keys , ': ', vals)

    print("\nReversed Dict")
    for (new_keys,new_vals) in reverse(test_dict).items():
        print(new_keys , ': ', new_vals)

    print("\nReversed to original Dict")
    for (new_keys,new_vals) in reverse(reverse(test_dict)).items():
        print(new_keys , ': ', new_vals)



if __name__ == '__main__':
    main()
   
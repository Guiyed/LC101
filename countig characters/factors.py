def factors(n):
    factors_dict = {}

    for number in range(1,n+1):
        factors_dict[number] = []
        for i in range(1,number+1):
            if number % i == 0:
                factors_dict[number].append(i)
        
    return factors_dict

def main():
    n = int(input('Introduce the number you want to factor: '))
    factors_1_to_n = {}
    factors_1_to_n = factors(n)
    
    for (num,factor) in factors_1_to_n.items():
        print(num , ': ', factor)
    

if __name__ == '__main__':
    main()
   
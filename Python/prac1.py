"""
Practical : Simple Calculation

"""

import sys 

#define main function 
def main():

    # indent to show that its part of the main function

    print("Hello Python !")

    #Example : Basic calculation 
    num1 = int(input("Enter first number: "))
    num2 = int(input("Enter second number: "))
    results = num1 + num2 

    #Display the results ;
    print(" The result is :", results)

#Explicitly call the function by calling the entry point function

if __name__ == "__main__": 
    main()
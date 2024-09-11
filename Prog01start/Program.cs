// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, welcome to my first program!");

// Reserve space in memory for an int,
// refer to the address by the name “age”
int age;

// Store the value 24 in the address
// referred to by “age”
age = 24;
age = 25;
age = 24 + 32;    // Now age is 56
age = age + 10;


double incomeTax = 100.6;
double housingTax = 50.2;
double zoneTax;
zoneTax = 30.3;
double tax = incomeTax - housingTax + 0.5 * zoneTax;

int a = 7;
int b = 4;
int c = a / b; // a divided by b

int a1 = 7 % 4;

int a2 = 2 * (3 + 4);  // This is 10, NOT 14


double x = 25.00;
double y = 6.00;
double z = 0.08;
double t = x * (1.00 + z) + y;

double netPrice = 25.00;
double shipping = 6.00;
double tax1 = 0.08;
double totalPrice = netPrice * (1.00 + tax1) + shipping;

double test1 = a2;


Console.WriteLine($"Dette er en { test1*2 } tekststreng" );

int firstNumber = 12;
int secondNumber = 14;
bool areTheyEqual = firstNumber == secondNumber;
Console.WriteLine($"The numbers are equal : {areTheyEqual}");


//int age2 = 8;
//bool isSmaller = (age2 < 10);
//int age2 = 14;
//bool isTeenager = (age2 < 20) && (age2 > 12);
//int age2 = 14;
//bool isNotTeenager = (age2 > 19) || (age2 < 13);
int age2 = 14;
bool isTeenager = (age2 < 20) && (age2 > 12);
bool isNotTeenager = !isTeenager;


int CalculateAverage(int val1, int val2, int val3)
{
    int average = (val1 + val2 + val3) / 3;
    return average;
}

int tal1 = 10;
int tal2 = 20;
int tal3 = 30;
//int result = CalculateAverage(tal1, tal2, tal3);
Console.WriteLine($"resultatet er {CalculateAverage(tal1, tal2, tal3)}");

int talA = 100;
int talB = 203;
int talC = 340;

int result = CalculateAverage(talA, talB, talC);
Console.WriteLine($"resultatet er {result}");
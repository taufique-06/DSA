//Q1: Factorial of a Number
Console.WriteLine(Factorial(5));
Console.WriteLine(Sum(5));
Console.WriteLine(SumOfDigits(12345));
Console.WriteLine(ProductOfDigits(12345));
Console.WriteLine(ReverseNumber(12345));

static int Factorial(int v)
{
    if (v <= 1)
    {
        return 1;
    }
    return v * Factorial(v - 1);
}

//Q2: Sum of n to 1

static int Sum(int v)
{
    if (v <= 1)
    {
        return 1;
    }
    return v + Sum(v - 1);
}

//Q3: Sum of Individual Digits
//In order take the individual digit from a number, you can do a modulo of 10. 

static int SumOfDigits(int v)
{
    if (v == 0)
    {
        return 0;
    }
    return (v%10) + SumOfDigits(v/10);
}

//Product of digits
static int ProductOfDigits(int v)
{
    if (v%10 == v)
    {
        return v;
    }
    return (v % 10) * ProductOfDigits(v / 10);
}

//Reverse a number

static int ReverseNumber(int v)
{
    if (v % 10 == v)
    {
        return v;
    }
    return (v % 10) * ProductOfDigits(v / 10);
}
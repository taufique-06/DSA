//print number 1 to 5
//print(1);
Console.WriteLine(Fibo(4));

static void print(int n)
{
    //The If block is base condition
    if(n == 5)
    {
        Console.WriteLine(5);
        return;
    }
    Console.WriteLine(n);

    //This is the Recursive call
    // If you are calling a function again and again, you can treat it as a separate call in the stack.
    //Same function is calling again and again. However, every function call is taking the memory 
    print(n + 1);
}

//Fibonacci Number - sum of the previous two numbers

static int Fibo(int n)
{
    if(n < 2)
    {
        return n;
    }
    return Fibo((n-1)) + Fibo((n-2));
}


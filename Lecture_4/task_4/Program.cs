// Факториал
// 5! = 5 * 4 * 3 * 2 * 1
//      5 * 4!
//          4 * 3!

double Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 0; i < 4; i++)
{
    Console.WriteLine(Factorial(i));
}

//Console.WriteLine(Factorial(3)); // 1*2*3 = 6

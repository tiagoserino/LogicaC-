using static System.Console;

int a = 3;

if (a < 0)
{
    WriteLine($"O número {a} é negativo!");
}
else
{
    if (a == 0)
    {
        WriteLine($"O número {a}é igual a 0!");
    }
    else
    {
        WriteLine($"O número {a} é positivo!");
    }
}
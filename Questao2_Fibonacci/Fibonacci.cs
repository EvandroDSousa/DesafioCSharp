int numero = 21; // numero previamente definido
bool pertence = false;

int a = 0, b = 1;

while (b <= numero)
{
    if (b == numero || numero == 0)
    {
        pertence = true;
        break;
    }

    int temp = b;
    b = a + b;
    a = temp;
}

if (pertence)
    Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
else
    Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci.");

string texto = "Sou escolhido";
string invertida = "";

for (int i = texto.Length - 1; i >= 0; i--)
{
    invertida += texto[i];
}

Console.WriteLine(invertida);

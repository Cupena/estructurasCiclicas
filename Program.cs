int[] valor = new int [10];
int valorCero = 0;
int valorPositivo = 0;
int valorNegativo = 0;
for ( int i = 0; i < valor.Length; i++)
{
    Console.WriteLine($"Valor #{i+1}");
    if(int.TryParse(Console.ReadLine()!, out valor[i]))
    {
        if(valor[i] == 0)
        {
            valorCero++;
        }
        else if (valor[i]>0)
        {
            valorPositivo++;
        }
        else if (valor[i] < 0)
        {
            valorNegativo++;
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("El caracter ingresado es invalido.");
        Console.ResetColor();
        i--;
    }
}



Console.WriteLine($"La cantidad de valores ceros es: {valorCero} ");
Console.WriteLine($"La cantidad de valores positivos es: {valorPositivo}");
Console.WriteLine($"La cantidad de valores negativos es de: {valorNegativo}");
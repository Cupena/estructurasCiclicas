int[] valor = new int [10];
int valorCero = 0;
int valorPositivo = 0;
int valorNegativo = 0;
int opcion = 0;

// Limpiar cualquier cosa de la consola
Console.Clear();

do
{
Console.WriteLine("===   MENU   ===\n1. Introducir los valores\n2. Mostrar los valores introducidos\n3. Mostrar resultados sobre los valores\n4. Mostrar conclusion\n5. Salir del programa");
if(int.TryParse(Console.ReadLine()!, out opcion))
{
    if(opcion == 5)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Saliendo del programa");

        for(int i = 0; i < 5; i++)
        {
            Thread.Sleep(400);
            Console.Write(". ");
        
        }
        Console.ResetColor();
        Console.Clear();
    }
    else if(opcion !=5)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
 Console.Write("Ingresando al sistema");
    
    for(int i = 0; i < 5 ; i++)
    {
        Thread.Sleep(250);
        Console.Write(". ");
    
    }
    Console.ResetColor();
    Console.Clear();

    switch (opcion)
    {
        case 1:
        Console.Clear();
    valorCero = 0;
    valorPositivo =0;
    valorNegativo = 0;
    
        for ( int i = 0; i < valor.Length; i++)
{
    Console.Write($"Valor #{i+1}: ");
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
Console.Clear();
        break;
    
        case 2:
        Console.Clear();
        if(valorCero == 0 && valorPositivo ==0 && valorNegativo ==0)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("No hay valores que mostrar. Volviendo al menu");
            for(int i = 0 ; i < 5; i++)
            {
                Thread.Sleep(350);
                Console.Write(". ");
            }
            Console.ResetColor();
            Console.Clear();
            break;
        }
        else
        {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Cargando valores ");
        for(int i = 0 ; i < 5 ; i++)
        {
            Thread.Sleep(350);
            Console.Write(". ");
        }
        Console.ResetColor();
        Console.Clear();

        Console.WriteLine("Los valores registrados son: ");
        
        for(int i = 0; i < valor.Length; i++)
        {
        if(valor[i] ==0) Console.ForegroundColor = ConsoleColor.Gray;
        else if(valor[i]<0) Console.ForegroundColor = ConsoleColor.Red;
        else if(valor[i]>0)Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(105);
            Console.WriteLine($"Valor #{1+i}: {valor[i]}");
        }
        Console.ResetColor();
        Console.WriteLine("");
        Console.WriteLine("Desea regresar al menu");
        Console.ReadKey();
        Console.Clear();
        break;
        }   
        
    
        case 3:
        if(valorCero == 0 && valorPositivo ==0 && valorNegativo ==0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("No hay datos que mostrar\n");
            Console.Write("Volviendo al menu ");
            for(int i = 0; i < 5 ; i++)
            {
                Thread.Sleep(300);
                Console.Write(". ");
            }
            Console.ResetColor();
            Console.Clear();
            break;
        }
        else
        {
            Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Ingresando a resultados");

        for(int i = 0; i < 5; i++)
        {
            Thread.Sleep(400);
            Console.Write(".");
        }
        Console.Clear();

        Console.WriteLine("Carga completada, presione cualquier tecla para iniciar");
        Console.ReadKey();
        Console.Clear();
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"La cantidad de valores ceros es: {valorCero} ");
        Console.WriteLine($"La cantidad de valores positivos es: {valorPositivo}");
        Console.WriteLine($"La cantidad de valores negativos es de: {valorNegativo}");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("");
        Console.WriteLine("Volver al menu.");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
        break;
        }
        
  
        case 4:
        break;
  
        case 5:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Saliendo del programa");
  
        for ( int i = 0 ; i < 5 ; i++)
        {
            Thread.Sleep(250);
            Console.Write(". ");
        }
        Console.ResetColor();
        break;
        
        default:
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Debe introducir una opcion de acuerdo al menu.");
        for (int i = 0; i < 5 ; i++)
        {
            Thread.Sleep(350);
            Console.Write(". ");
        }
        Console.ResetColor();
        Console.Clear();
        break;
    }
    }

   
}
else
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Ha introducido un caracter invalido. ");
    Console.ResetColor();
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Volviendo al menu ");
    for ( int i = 0 ; i < 5; i++)
    {
        Thread.Sleep(350);
        Console.Write(". ");
    }
    Console.ResetColor();
    Console.Clear();
}
}while(opcion !=5);





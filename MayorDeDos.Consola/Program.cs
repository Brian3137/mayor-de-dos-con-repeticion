MayorDeDos();

//---METODOS---

//Un metoodo, es un bloque de codigo con una responsabilidad determinada.
int PedirNumeroPorConsola()
{
    Console.WriteLine("Escriba un número a comparar y presione enter:");
    string linea = Console.ReadLine();
    int numeroLeido = int.Parse(linea);
    return numeroLeido;
}

void MayorDeDos()
{
    Console.WriteLine("Mayor De Dos números");
    Console.WriteLine("Este programa calcula el mayor de dos numeros proporcionados por el usuario.");
    Console.WriteLine();

    int numeroA = PedirNumeroPorConsola();
    int numeroB = PedirNumeroPorConsola();

    Console.WriteLine("Procesando...");
    Thread.Sleep(2000); //Numero en mili segundos

    if (numeroA == numeroB)
    {
        Console.WriteLine("Los numeros son iguales");
    }
    else
    {
        if (numeroA > numeroB)
        {
            Console.WriteLine("El número mayor es " + numeroA);
        }
        else { Console.WriteLine("El número mayor es " + numeroB); }
    }

    Console.WriteLine("Desea seguir buscando el mayor de dos numeros? Ponga SI para continuar , NO para finalizar.");
    string respuesta = Console.ReadLine();
    if (respuesta == "SI")
    {
        MayorDeDos();
    }
    else
    {
        Console.WriteLine("Presiona una tecla cualquiera para cerrar el programa");
        Console.ReadLine();
    }
}

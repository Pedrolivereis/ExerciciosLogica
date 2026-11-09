Console.WriteLine("Digite tres valores para formar um triangulo");
double lado1 = double.Parse(Console.ReadLine());
double lado2 = double.Parse(Console.ReadLine());
double lado3 = double.Parse(Console.ReadLine());

if (lado1 + lado2 >  lado3 && lado2 + lado3 > lado1 && lado1 + lado3 > lado2)
{
    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("Triangulo Equilatero");
    }
    else if (lado1 == lado2 && lado2 !=  lado3 || lado2 == lado3 && lado3 != lado1 || lado1 == lado3 && lado3 != lado2)
    {
        Console.WriteLine("Triangulo iósceles");
    }
    else
    {
        Console.WriteLine("Triangulo Escaleno");
    }
}
else
{
    Console.WriteLine("Triangulo invalido");
}


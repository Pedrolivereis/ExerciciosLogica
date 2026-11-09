Console.WriteLine("Informe um número decimal: ");
float num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Informe um número decimal: ");
float num2 = float.Parse(Console.ReadLine());
float maior = num1;
if (maior > num2)
{
    Console.WriteLine($"{maior} é maior que {num2}");
}
else if (maior < num2)
{
    maior = num2;
    Console.WriteLine($"{maior} é maior que {num1}");
}
else
{
    Console.WriteLine("Os numeros sao iguais");
}



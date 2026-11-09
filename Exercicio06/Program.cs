Console.WriteLine("Digite a sua idade:");
int idade = int.Parse(Console.ReadLine());
if (idade <= 12)
{
    Console.WriteLine($"Você tem {idade} entao voce é criança");
}
else if (idade <= 17)
{
    Console.WriteLine($"Você tem {idade} então você é adolecente");
}
else if (idade <= 59)
{
    Console.WriteLine($"Você tem {idade} então você é adulto");
}
else
{
    Console.WriteLine($"Você tem {idade} então você é idoso");
}

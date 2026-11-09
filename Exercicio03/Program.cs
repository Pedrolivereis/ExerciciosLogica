Console.WriteLine("Informe a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Informe a quarta nota: ");
float nota4 = float.Parse(Console.ReadLine());

float media = ((nota1 + nota2 + nota3 + nota4) /4);

if (media >= 7)
{
    Console.WriteLine($"Susa média é {media:f1} e você foi aprovado");
}
else if (media > 5)
{
    Console.WriteLine($"Sua média é {media:f1} e você esta de recuperacao");
}
else
{
    Console.WriteLine($"Sua média é {media:f1} e você esta Reprovado");
}
Console.WriteLine("Informe seu salario:");
double salario = double.Parse(Console.ReadLine());
double aumento = 0;
if (salario <= 2000)
{
    aumento = salario  * 15 / 100;
    Console.WriteLine($"Seu aumento foi de {aumento} reais e agora seu salario é {salario + aumento}");
}
else if (salario <= 4000)
{
    aumento = salario * 10 / 100;
    Console.WriteLine($"Seu aumento foi de {aumento} reais e agora seu salario é {salario + aumento}");
}
else
{
    aumento = salario * 5 / 100;
    Console.WriteLine($"Seu aumento foi de {aumento} reais e agora seu salario é {salario + aumento}");
}

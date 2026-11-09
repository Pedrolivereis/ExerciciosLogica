Console.WriteLine("Digite um ano aleatorio");
int ano = int.Parse(Console.ReadLine());
if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
{
    Console.WriteLine($"{ano} é um ano BISSEXTO");
}
else
{
    Console.WriteLine($"{ano} NÃO É BISSEXTO");
}
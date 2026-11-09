Console.WriteLine($"Qual o seu peso em kg:");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine($"Digite a sua altura em centimetros:");
float altura = float.Parse(Console.ReadLine());
altura = altura / 100;
float imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine($"Você está abaixo do peso");
}
else if (imc < 25)
{
    Console.WriteLine($"Você está com peso normal");
}
else if (imc < 30)
{
    Console.WriteLine($"Você está sobrepeso");
}
else if (imc < 35)
{
    Console.WriteLine($"Você está com obesidade grau |");
}
else if (imc < 40)
{
    Console.WriteLine($"Você está com obesidade grau ||");
}
else
{
    Console.WriteLine($"Você está com obesidade grau |||(MÓRBIDA)");
}
// faça um programa que leia o ano que a pessoa nasceu e informe se ela é maior de idade;
int ano;
int idade;
int anoAtual = 2024;

Console.WriteLine("Que ano você nasceu?");
ano = int.Parse(Console.ReadLine());

if (ano > anoAtual)
{
    Console.WriteLine("sério? Veio do futuro?");
}
else
{
    idade = anoAtual - ano;
    if (idade >= 18)
    {
        Console.WriteLine("Você é maior de idade");
    }
    else
    {
        Console.WriteLine("Você é menor de idade");
    }
}

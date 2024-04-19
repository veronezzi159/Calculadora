/*string name;
int idade;
Console.Write("Escreva seu nome: ");
name = Console.ReadLine();
Console.Write("Digite sua Idade: ");
idade = int.Parse(Console.ReadLine()); 
Console.WriteLine($"\nSeja bem vindo {name}!, Você tem: " + idade + "anos");


int idade;
int ano;

Console.Write("Digite seu ano de nascimento: ");
ano = int.Parse(Console.ReadLine());
idade = 202 - ano;
Console.WriteLine("\nVocê tem: " + idade + " anos");
*/

float n1, n2;

float soma;
float sub;
float multipli;
float div;

Console.WriteLine("Digite 2 numeros( separando-os por linha): ");
n1 = float.Parse(Console.ReadLine());
n2 = float.Parse(Console.ReadLine());

soma  = n1 + n2 ;
sub = n1 - n2 ;
multipli = n1 * n2;
 if ((n2 == 0) || (n2 < 0) )
{
    Console.WriteLine("Impossível Dividir por zero ou negativo");
} else
{
    div = n1 / n2;
    Console.WriteLine($"Divisão: {div}");
}

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtração: {sub}");
Console.WriteLine($"Multiplicação: {multipli}");



Console.ReadLine();
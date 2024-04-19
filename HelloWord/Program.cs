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
string operador;
bool controle;
float soma;
float sub;
float multipli;
float div;


do
{
    Console.WriteLine("Qual operação deseja realiar? use: s para soma, sub para subtração, m para multiplicação e d para divisão");
    operador = Console.ReadLine();
    if (operador == "s" || operador == "d" || operador == "sub" || operador == "m")
    {
        controle = true;
    }
    else
    {
        controle= false;
    }


} while (controle == false);


do 
{
    Console.WriteLine("Digite 2 numeros( separando-os por linha): ");
    n1 = float.Parse(Console.ReadLine());
    n2 = float.Parse(Console.ReadLine());
    if (operador == "d")
    {
        if (n2 > 0)
        {
            controle = true;
        }
        else
        {
            Console.WriteLine("Divisão por zero/negativo impossivel, digite um numero valido");
            controle = false;
        }
    }
    else
    {
        controle = true;
    }
} while (controle == false);

if (operador == "s")
{
    soma = n1 + n2;
    Console.WriteLine($"Soma: {soma}");
} else if (operador == "d")
{
    div = n1 / n2;
    Console.WriteLine($"Divisão: {div}");
} else if (operador == "m")
{
    multipli = n1 * n2;
    Console.WriteLine($"Multiplicação: {multipli}");
} else
{
    sub = n1 - n2;
    Console.WriteLine($"Subtração: {sub}");
}

Console.ReadLine();
float n1, n2;
int op = 0;
float resultado;


Console.WriteLine("Digite 1 numero: ");
n1 = float.Parse(Console.ReadLine());
do
{
    Console.WriteLine( "Digite outro numero (diferente de zero)");
    n2 = float.Parse(Console.ReadLine());
} while (n2 == 0);

do
{
    Console.WriteLine("Escolha uma operação");
    Console.Write("1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão");
    op = int.Parse(Console.ReadLine());
} while (op < 1 && op > 4 );

if (op == 1)
{
    resultado = n1 + n2;
    Console.WriteLine(resultado);
}
else
{
    if (op == 2)
    {
        resultado = n1 - n2;
        Console.WriteLine( resultado);
    }
    else
    {
        if (op == 3)
        {
            resultado = n1 * n2;
            Console.WriteLine( resultado);
        }
        else
        {
            resultado = n1 / n2;
            Console.WriteLine( resultado);
        }
    }
}


Console.ReadLine();

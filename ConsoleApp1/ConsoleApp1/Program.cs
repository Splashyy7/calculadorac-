class Program
{
    static void Main(string[] args)

    {
        Console.Clear();
        Console.WriteLine("Olá");

        string num1;
        string num2;

        Console.WriteLine("---Operações matemáticas");
        Console.WriteLine("Digite o primeiro numero:");
        num1 = Console.ReadLine();

        Console.WriteLine("Você Digitou o valor: " + num1);

        Console.WriteLine("Digite o segundo numero:");
        num2 = Console.ReadLine();

        Console.WriteLine("Você Digitou o valor: " + num2);

        int numero1 = int.Parse(num1);
        int numero2 = int.Parse(num2);

        int resultadoMultiplicacao = numero1 * numero2;

        int resultadoSoma = numero1 +numero2;

        int resultadoSubtracao = numero1 - numero2;

        int resultadoDivisao = numero1 / numero2;

        Console.WriteLine("O resultado da multiplicação é: " + resultadoMultiplicacao);
        Console.WriteLine("O resultado da soma: "+ resultadoSoma);
        Console.WriteLine("O resultado da subtração é: " + resultadoSubtracao);
        Console.WriteLine("O resultado da divisão é : " + resultadoDivisao);
    }
}

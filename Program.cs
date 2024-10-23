int numero;
int anterior = 0;
int atual = 1;
bool pertence;

Console.WriteLine("Informe um número para verificar se pertence à sequência de Fibonacci:");
numero = int.Parse(Console.ReadLine());

pertence = (numero == 0 || numero == 1) ? true : false;

while (atual <= numero && !pertence)
{
    pertence = (atual == numero) ? true : false;

    int proximo = anterior + atual;

    anterior = atual;
    atual = proximo;
}

Console.WriteLine(pertence
    ? $"O número {numero} pertence à sequência de Fibonacci."
    : $"O número {numero} NÃO pertence à sequência de Fibonacci.");
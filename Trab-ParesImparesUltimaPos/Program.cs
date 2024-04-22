/*
faça um programa que leia 10 numeros inteiros e imprima os seguintes itens (vetor)
a - somente os valores pares
b - somente os valores impares
c - somente a primeira e a ultima posicao
*/

int[] numeros = new int[10];

while (true)
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Informe o {i+1}o numero:");
        numeros[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
    Console.WriteLine("Informando numeros pares abaixo:");
    for (int i = 0; i < 10; i++)
    {

        if ((numeros[i] % 2 == 0) && (numeros[i] > 0))
        {
            Console.Write((numeros[i]) + " ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("Informando numeros impares abaixo:");
    for (int i = 0; i < 10; i++)
    {
        if (numeros[i] % 2 != 0)
        {
            Console.Write((numeros[i]) + " ");
        }
    }
    Console.WriteLine();
    Console.WriteLine($"O numero que ocupa a primeira posicao eh: {numeros[0]} e o numero que ocupa a ultima posicao eh: {numeros[9]}");

    Console.ReadLine();
    Console.Clear();
}

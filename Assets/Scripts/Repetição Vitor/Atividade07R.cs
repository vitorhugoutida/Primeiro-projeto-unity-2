//using System.Drawing;
//using UnityEngine;
//using static Unity.Burst.Intrinsics.X86;

//public class Atividade07R : MonoBehaviour
//{
//    // Start is called once before the first execution of Update after the MonoBehaviour is created

//    //    (Maior número em uma lista) Dada uma lista de números,
//    //encontre o maior valor.
//    [SerializeField] int numero1 = 0;
//    [SerializeField] int numero2 = 6;
//    [SerializeField] int numero3 = 1;
//    [SerializeField] int numero4 = 5;
//    [SerializeField] int numero5 = 3;
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}

using System;
using System.Collections.Generic;

public class Atividade07R
{
    public static void Main()
    {
        List<int> numeros = new List<int> { 3, 7, 2, 15, 9 }; // Exemplo de lista de números

        if (numeros.Count == 0)
        {
            Console.WriteLine("A lista está vazia.");
            return;
        }

        int maior = numeros[0]; // Assume o primeiro elemento como o maior inicialmente

        foreach (int numero in numeros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine("O maior número na lista é: " + maior);
    }
}

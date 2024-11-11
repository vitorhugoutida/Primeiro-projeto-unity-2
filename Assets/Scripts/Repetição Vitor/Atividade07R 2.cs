using System.Collections.Generic;
using System;
using UnityEngine;

public class Atividade07R2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    List<int> numeros = new List<int> { 3, 7, 2, 15, 9 }; // Exemplo de lista de n�meros
    void Start()
    {
            if (numeros.Count == 0)
            {
                Console.WriteLine("A lista est� vazia.");
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

            print("O maior n�mero na lista �: " + maior);
        }
    }



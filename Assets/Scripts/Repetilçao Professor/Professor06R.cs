using NUnit.Framework;
using System;
using UnityEngine;

public class Professor06R : MonoBehaviour
{
    //6. (Fizz Buzz) Para cada n�mero entre 0 e 10000, escreva apenas
    //�fizz� no console quando for divis�vel por 3, �buzz� quando for
    //divis�vel por 5 e �fizz buzz� quando for divis�vel pelos dois.Se o
    //n�mero n�o for divis�vel por nenhum deles, escreva-o no console.

    void Start()
    {
        //for(inicializador; condi��o; incrementar/decrementar
        for (int i = 0; i < 10000; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                print("Fizz buzz");
            }
            else if (i % 5 == 0)
            {
                print("buzz");
            }
            else if (i % 3 == 0)
            {
                print("Fizz");
            }
            else
            {
                print(i);
            }

        }
    }

    void Update()
    {

    }
}

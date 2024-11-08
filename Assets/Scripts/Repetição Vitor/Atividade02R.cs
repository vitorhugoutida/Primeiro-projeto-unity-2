using NUnit.Framework;
using System.Threading;
using UnityEngine;

public class Atividade02R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created,

    //    (Multiplicação de dano) Um personagem ataca cinco vezes, e o
    //dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    //ataque.

    [SerializeField] int quantiAtaques = 0;
    [SerializeField] int numeroDeDano = 0;
    [SerializeField] float segundos;

    async void Start()
    {
        while (quantiAtaques >= 5)
        {
            print(numeroDeDano);
            quantiAtaques++;
            print(numeroDeDano);

            Thread.Sleep(1000);

            if (quantiAtaques == 5)
            {
                numeroDeDano++;
                quantiAtaques = 0;
                print("Dano atual: " + numeroDeDano);
            }
        }
    }

}
       


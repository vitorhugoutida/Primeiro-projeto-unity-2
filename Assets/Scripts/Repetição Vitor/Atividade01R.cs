using Mono.Cecil.Cil;
using System.Threading;
using UnityEngine;

public class Atividade01R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //    1. (Contagem regressiva de tempo) Crie uma contagem
    //regressiva de 5 a 1 e exiba "Início da partida!" ao final.

    [SerializeField] int segundos;
    [SerializeField] int x = 5;


    void Start()
    {
        //for (int numero = 0; numero <= 5; numero--)
        //{
        //    print(numero);
        //}
        // Trava
        S
        while (x >= 1)
        {
            print(x);
            x--;

            //Thread.Sleep(1000);

            if (x == 0)
            {
                print("Início da partida!");
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

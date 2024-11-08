using Mono.Cecil.Cil;
using UnityEngine;

public class Atividade01R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //    1. (Contagem regressiva de tempo) Crie uma contagem
    //regressiva de 5 a 1 e exiba "Início da partida!" ao final.


    void Start()
    {
        for (int i = 0; i <= 5; i--)
        {
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

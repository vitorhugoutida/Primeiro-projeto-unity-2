using System;
using Unity.VisualScripting;
using UnityEngine;

public class Atividade09 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Placar final) Crie um script que l� o placar de uma partida entre time A e time B.Depois, escreva no console qual dos tr�s resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B ou empate.Se o empate teve mais de 3 pontos para cada lado, escreva que foi �um empate emocionante�.

    [SerializeField] int timeA = 0;
    [SerializeField] int timeB = 0;

    void Start()
    {
        print("Time A: " +  timeA + ", " + "Time B: " +  timeB);
        
        if (timeA > timeB)
        {
            print("Vit�ria do time A");
        }
        if (timeB > timeA)
        {
            print("Vit�ria do time B");
        }
        if (timeA == timeB && timeA != 3 && timeB != 3 && timeB ! > 3 == timeA ! > 3)
        {
            print("Empate");
        }
        if (timeB == 3 && timeA == 3)
        {
            print("Um empate emociante!");
        }
        if (timeB == timeA && timeB > 3 == timeA > 3)
        {
            print("UM EMPATE EMOCIANTE!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

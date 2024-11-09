using UnityEngine;

public class Atividade02R : MonoBehaviour
{

//    (Multiplicação de dano) Um personagem ataca cinco vezes, e o
//dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
//ataque.

    void Start()
    {
        int dano = 1;
        int quantiVezes = 0;

        while (quantiVezes < 5)
        {
            print("DANO: " + dano);
            quantiVezes++;
            print("QuantiVezes: " + quantiVezes);
            dano += 2;
           
        }

    }

    void Update()
    {

    }
}



using UnityEngine;

public class Professor02R : MonoBehaviour
{
    //2. (Multiplica��o de dano) Um personagem ataca cinco vezes, e o
    //dano do ataque aumenta em 2 a cada vez.Exiba o dano a cada
    //ataque.

    [SerializeField] int dano = 10;

    void Start()
    {
        //for(inicializa; condi��o; incremento/decremento)
        for (int i = 1; i <= 5; i++)
        {
            print("Ataque " + i + ": Dano " + dano);
            //dano = dano + 2;
            dano += 2;
        }
    }


    void Update()
    {

    }
}

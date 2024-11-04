using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    // ATIVIDADE 01
    // (Verificação de pontos de vida) Um personagem perde pontos de vida após uma batalha. Verique se ele ainda está vivo. Caso tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso contrário, "Game Over".

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] public int vidaPlayer = 100;
    string resultado;
    void Start()
    {
        if (vidaPlayer > 0)
        {
            print("Personagem vivo! :)");
        }
        else
        {
            print("Game Over");
        }

        //Condição ? valor a ser chamado caso verdadeiro : caso falso
        resultado = (vidaPlayer > 0) ? "Personagem Vivo!" : "Game Over!";
        print(resultado);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
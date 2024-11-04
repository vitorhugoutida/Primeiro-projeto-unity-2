using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    // ATIVIDADE 01
    // (Verifica��o de pontos de vida) Um personagem perde pontos de vida ap�s uma batalha. Verique se ele ainda est� vivo. Caso tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso contr�rio, "Game Over".

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

        //Condi��o ? valor a ser chamado caso verdadeiro : caso falso
        resultado = (vidaPlayer > 0) ? "Personagem Vivo!" : "Game Over!";
        print(resultado);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
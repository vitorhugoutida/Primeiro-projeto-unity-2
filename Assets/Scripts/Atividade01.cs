using UnityEngine;

public class Atividade01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public int vidaJogador = 100;
    void Start()
    {
        // (Verifica��o de pontos de vida) Um personagem perde pontos de vida ap�s uma batalha. Verique se ele ainda est� vivo. Caso tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso contr�rio, "Game Over"
        if (vidaJogador == 0)
        {
            print("Game Over");
        } else {
            print("Personagem Vivo");
        }
        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

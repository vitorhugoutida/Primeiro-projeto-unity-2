using UnityEngine;

public class Atividade01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public int vidaJogador = 100;
    void Start()
    {
        // (Verificação de pontos de vida) Um personagem perde pontos de vida após uma batalha. Verique se ele ainda está vivo. Caso tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso contrário, "Game Over"
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

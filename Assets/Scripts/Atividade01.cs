using UnityEngine;

public class Atividade01 : MonoBehaviour
{
    // ATIVIDADE 01
    // (Verificação de pontos de vida) Um personagem perde pontos de vida após uma batalha. Verique se ele ainda está vivo. Caso tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso contrário, "Game Over".

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] public int vidaJogador = 100;
    void Start()
    {
        if (vidaJogador == 0)
        {
            print("Game Over");
        } else
        {
            print("Personagem Vivo");
        }
    }
        // Update is called once per frame
        void Update()
        {
        
        }
    }


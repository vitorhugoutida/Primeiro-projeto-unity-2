using UnityEngine;

public class Atividade01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public int VidaJogador = 100;
    void Start()
    {
        // (Verificação de pontos de vida) Um personagem perde pontos de vida após uma batalha. Verique se ele ainda está vivo. Caso tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso contrário, "Game Over"
        if (VidaJogador < 0)
        {
            print("Personagem Vivo");
        }
        else if (VidaJogador == 0)
        {
            print("Game Over");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
Oi por favor coloca o códigos no Git hub para eu ver os códigos porque não copiei tudo

vc precisa olhar o código agora

vc precisa fazer duas verificações
1 - se a vida for maior que 0 vivo
se não morto
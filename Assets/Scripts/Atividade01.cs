using UnityEngine;

public class Atividade01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public int VidaJogador = 100;
    void Start()
    {
        // (Verifica��o de pontos de vida) Um personagem perde pontos de vida ap�s uma batalha. Verique se ele ainda est� vivo. Caso tenha mais de 0 pontos de vida, exiba "Personagem Vivo", caso contr�rio, "Game Over"
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
Oi por favor coloca o c�digos no Git hub para eu ver os c�digos porque n�o copiei tudo

vc precisa olhar o c�digo agora

vc precisa fazer duas verifica��es
1 - se a vida for maior que 0 vivo
se n�o morto
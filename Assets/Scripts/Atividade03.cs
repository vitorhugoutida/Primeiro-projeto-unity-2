using UnityEngine;

public class Atividade03 : MonoBehaviour
{
    // ATIVIDADE 03
    // Considere que o jogo tem um power-up que revive o personagem caso ele morra. Caso o jogador morra e tiver coletado o power-up ele volta a vida com 50% de sua vida total e deve ser exibido a mensagem "Ainda não, vida atual XX". Caso ele não tenha coletado o power-up exiba "Game Over"

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] public int vidaJogador = 0;
    [SerializeField] public int powerUp = 1;
    void Start()
    {
        if (vidaJogador == 0)
        {
            print("Morreu");
        }
        else
        {
            print("Jogador Vivo, vida atual " + vidaJogador);
        }

            if (powerUp > 0)
            {
                vidaJogador = 50;
                powerUp--;
            print("Espera, você tem Power-Up, então Power-Up -1");
            print("Ainda não, vida atual  " + vidaJogador + "%");
            }
            else {
            print("Você não tem Power-Up");
            print("Game Over");
                 }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

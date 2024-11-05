using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Atividade11 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Di�logos) Implemente um sistema de di�logos onde o jogador pode interagir com um NPC(personagem n�o jog�vel), e o NPC responde com diferentes frases dependendo do estado do jogo. Use switch case para definir as respostas baseadas no estado do jogador.

    [SerializeField] int estadoNPC = 0;
    string resultado;

    // 1 - Ol�.
    // 2 - Hoje a promo��o � po��es, custa 30 moedas.
    // 3 - Otima escolha.
    // 4 - Tchau, boa sorte.
    // 5 - N�o tenho nada a dizer agora.


    void Start()
    {
        switch (estadoNPC)
        {
            case 1:
                resultado = "Ol�.";
                print(resultado);
                break;
            case 2:
                resultado = "O que voc� quer?";
                print(resultado);
                break;
            case 3:
                resultado = "O valor � 30 moedas.";
                print(resultado);
                break;
            case 4:
                resultado = "Tchau, boa sorte.";
                print(resultado);
                break;
            case 5:
                resultado = "N�o tenho nada a dizer agora.";
                print(resultado);
                break;
            default:
                print("O valor est� incorreto.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

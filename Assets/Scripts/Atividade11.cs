using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Atividade11 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Diálogos) Implemente um sistema de diálogos onde o jogador pode interagir com um NPC(personagem não jogável), e o NPC responde com diferentes frases dependendo do estado do jogo. Use switch case para definir as respostas baseadas no estado do jogador.

    [SerializeField] int estadoNPC = 0;
    string resultado;

    // 1 - Olá.
    // 2 - Hoje a promoção é poções, custa 30 moedas.
    // 3 - Otima escolha.
    // 4 - Tchau, boa sorte.
    // 5 - Não tenho nada a dizer agora.


    void Start()
    {
        switch (estadoNPC)
        {
            case 1:
                resultado = "Olá.";
                print(resultado);
                break;
            case 2:
                resultado = "O que você quer?";
                print(resultado);
                break;
            case 3:
                resultado = "O valor é 30 moedas.";
                print(resultado);
                break;
            case 4:
                resultado = "Tchau, boa sorte.";
                print(resultado);
                break;
            case 5:
                resultado = "Não tenho nada a dizer agora.";
                print(resultado);
                break;
            default:
                print("O valor está incorreto.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

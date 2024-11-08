using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Exercicio11 : MonoBehaviour
{
    //11. (Di�logos) Implemente um sistema de di�logos onde o jogador
    //pode interagir com um NPC(personagem n�o jog�vel), e o NPC
    //responde com diferentes frases dependendo do estado do jogo.
    //Use switch case para definir as respostas baseadas no estado do
    //jogador.

    [SerializeField] int estado;

    void Start()
    {
        switch (estado)
        {
            case 1:
                print("Da para fazer com ternario?");
                break;

            case 2:
                print("Sextooou!");
                break;

            case 3:
                print("Cad� o Thiago?");
                break;

            case 4:
                print("Cad� a Alana?");
                break;

            case 5:
                print("Jucelino, cad� meu aumento?");
                break;

            default:
                print("N�o tenho nada a dizer sobre isso!");
                break;
        }
    }


    void Update()
    {

    }
}
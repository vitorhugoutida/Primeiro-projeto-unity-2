using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Atividade06 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Escolha de personagem) O jogador pode escolher entre o personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o jogador selecionar Guerreiro e "Mago escolhido" se selecionar Mago.

    [SerializeField] bool guerreiro;
    [SerializeField] bool mago;
    void Start()
    {

        if (mago == true && guerreiro == true)
        {
            print("Personagem não escolhido, porque você escolheu dois personagem, renicie o jogo e escolha uma personagem");
        }
        else if (mago == false && guerreiro == false)
        {
            print("Personagem não escolhido, renicie o jogo e escolha uma personagem");
        }
        else if (mago == true)
        {
            print("Mago escolhido");
        }
        else if (guerreiro == true)
        {
            print("Guerreiro escolhido");
        }
        else
        {
            print("Personagem não escolhido, renicie o jogo e escolha uma personagem");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}


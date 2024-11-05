using UnityEngine;
using static UnityEditor.Progress;

public class Atividade10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Itens do inventário) Crie um script onde o jogador pode coletar diferentes tipos de itens(como moedas, poções, ou power-ups) que têm efeitos diferentes dependendo do tipo coletado.Use um switch case para determinar o efeito de cada tipo de item.

    [SerializeField] int itens = 0;
    string resultado;


    void Start()
    {
        //print("Moeda = 1");
        //print("Poções = 2");
        //print("Power-Up = 3");
        //print("Food = 4");

        switch (itens)
        {
            case 1:
                resultado = "Efeito de ouro";
                print(resultado);
                break;

            case 2:
                resultado = "Efeito de mágico";
                print(resultado);
                break;

            case 3:
                resultado = "Efeito de poder";
                print(resultado);
                break;

            case 4:
                resultado = "Efeito de energia";
                print(resultado);
                break;

            default:
                print("Valor não está na lista, renicie o jogo e insira valor correto");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

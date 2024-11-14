using UnityEngine;
using static UnityEditor.Progress;

public class Professor10 : MonoBehaviour
{
    //10. (Itens do invent�rio) Crie um script onde o jogador pode coletar
    //diferentes tipos de itens(como moedas, po��es, ou power-ups)
    //que t�m efeitos diferentes dependendo do tipo coletado.Use um
    //switch case para determinar o efeito de cada tipo de item.

    [SerializeField] string tipoItem;
    [SerializeField] int moeda = 10;
    [SerializeField] bool escudo;
    [SerializeField] bool poçaoVida;

    void Start()
    {
        switch (tipoItem)
        {
            case "Moeda":
                moeda++;
                print("Moeda coletada: " + moeda);
                break;

            case "Escudo":
                escudo = true;
                print("Escudo ativo");
                break;

            case "Poção":
                poçaoVida = true;
                print("Po��o de vida coletada");
                break;

            default:
                Debug.Log("Item desconhecido!");
                break;

        }
    }


    void Update()
    {

    }
}
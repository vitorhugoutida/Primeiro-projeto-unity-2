using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    //4. (Verificar item de invent�rio) Um jogador possui itens limitados
    //no invent�rio.Verifique se o jogador possui uma "Po��o de Vida".
    //Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
    //indispon�vel".

    [SerializeField] bool pocaoVida;

    void Start()
    {
        // condi��o ? caso vdd : caso falso
        //print(pocaoVida ? "Usando Po��o de Vida" : "Po��o indispon�vel");

        if (pocaoVida)
        {
            print("Usando Po��o de Vida");
        }
        else
        {
            print("Po��o indispon�vel");
        }




    }

    void Update()
    {

    }
}
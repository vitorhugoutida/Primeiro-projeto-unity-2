using UnityEngine;
using static Unity.Burst.Intrinsics.X86;
using static UnityEditor.PlayerSettings;
using static UnityEngine.EventSystems.EventTrigger;

public class Exercicio07 : MonoBehaviour
{

    //7. (Dado com N faces) Para fazer um jogo de RPG, vamos precisar
    //calcular probabilidades e simular a rolagem de dados.Crie um
    //script em que o usu�rio defina o n�mero de faces de um dado
    //(int) e calcule a rolagem de um dado com esse n�mero de faces.
    //Use a fun��o abaixo para o c�lculo: Random.Range (valor_min,
    //valor_max); (Coloque o c�digo dentro da fun��o-evento Start).

    [SerializeField] int faces;

    void Start()
    {
        //if (faces == 0)
        //{
        //    print("O n�mero de faces do dado n�o pode ser: " + faces);
        //}
        //else
        //{
        //    print(Random.Range(1, faces));
        //}

        //condi��o ? vdd : falso

        print(faces == 0 ? ("O n�mero de faces do dado n�o pode ser: " + faces) : (Random.Range(1, faces)));
    }

    void Update()
    {

    }
}
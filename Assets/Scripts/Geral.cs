using UnityEngine;

public class Geral : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //Operadores relacionais

    //    == (Igual)
    //    != (Diferente)
    //    > (Maior que)
    //    < (Menor que)
    //    <= (Menor igual)
    //    >= (Maior igual)

    //Operador L

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;
    [SerializeField] int estadoVilao = 1;

    void Start()
    {
        print(vidaVilao == vidaHeroi); //False
        print(vidaHeroi <= vidaVilao); //True
        print(vidaVilao != vidaHeroi); //True

        // Operador tern�rio

        //resultado = vidaHeroi < vidaVilao interrogacao "Vida Heroi Menor" : "Vida Heroi Maior";

        //print(resultado);

        //Estrutura condicional

        if (vidaHeroi < vidaVilao)
        {
            resultado = "Vida Heroi Menor";
            print(resultado);

        }
        else if (vidaHeroi == vidaVilao)
        {
            resultado = "Vida Heroi igual a vida Vilao";
            print(resultado);
        }
        else
        {
            resultado = "Vida Heroi Maior";
            print(resultado);
        }

        // Estado

        // Estado 01: vil�o ataca
        // Estado 02: vil�o defende
        // Estado 03: vil�o toma dano

        switch (estadoVilao)
        {
            case 1:
                print("Vil�o atacando");
                if (true)
                {
                    print("Danoo");
                }
                break;

            case 2:
                print("Vil�o defende");
                break;

            case 3:
                print("Vil�o tomando um coro");
                break;

            default:
                print("Valor n�o identificado");
                break;
        }
    }
    void Update()
    {
    }
}





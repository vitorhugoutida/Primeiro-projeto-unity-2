using UnityEngine;

public class Geral : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    /*
        Operadores relacionais
        
        == (igual)
        != (diferente)
        >  (Maior que)
        <  (Menor que)
        <= (Menor igual)
        >= (Maior igual)

        Operadores Lógicos

        && (E/ AND)
        || (OU / OR)
        ! (NÃO / NOT)
     
        Variáveis
    
        int vidaPlayer = 10;
        float velocidadePlayer = 50.2f;
        bool mortePlayer = true;
        string nomePlayer = "Tadola";
        char apelido = 'A';
    */

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string resultado;
    [SerializeField] int estadoVilao = 1;

    void Start()
    {
        print(vidaVilao == vidaHeroi); //False
        print(vidaHeroi <= vidaVilao); //True
        print(vidaVilao != vidaHeroi); //True

        // Operador ternário

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

        // Estado 01: vilão ataca
        // Estado 02: vilão defende
        // Estado 03: vilão toma dano

        switch (estadoVilao)
        {
            case 1:
                print("Vilão atacando");
                if (true)
                {
                    print("Danoo");
                }
                break;

            case 2:
                print("Vilão defende");
                break;

            case 3:
                print("Vilão tomando um coro");
                break;

            default:
                print("Valor não identificado");
                break;
        }
    }
    void Update()
    {
    }
}





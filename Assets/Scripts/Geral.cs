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

        Operadores L�gicos

        && (E/ AND)
        || (OU / OR)
        ! (N�O / NOT)
     
        Vari�veis
    
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





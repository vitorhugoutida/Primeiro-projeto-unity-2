using UnityEngine;

public class LacoRepeticao : MonoBehaviour
{
    //For -> � utilizado quando se sabe a qtd. de repeti��es 

    //While ou DoWhile -> � utilizado quando n�o se sabe a qdt. de repi��es

    //Foreach -> Usado em listas ou arrays para executar uma opera��o para cada item da lista

    //Array -> � uma lista 

    int x = 0; //While
    int y = 10; //DoWhile 




    void Start()
    {

        //for(inicializador; codi��o; incremento/decremento)
        //for(int i = 0; i <= 10; i++)
        //{
        //    //if(i == 5)
        //    //{
        //    //    break;
        //    //}

        //    if (i == 6)
        //    {
        //        continue;
        //    }

        //    print(i);
        //}

        //While
        //while (x<=10)
        //{
        //    print(x);
        //    x++;
        //}

        //Do While
        //do
        //{
        //    print(y);
        //    y--;
        //}
        //while (y >= 0);

        int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };

        print(num[3]);

        num[0]++;

        print(num[0]);

        string[] nomes;

        nomes = new string[5];
        nomes[0] = "Tadola";

        print(nomes[1]);
    }


    void Update()
    {

    }
}
using UnityEngine;

public class Atividade06R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

//    (Fizz Buzz) Para cada n�mero entre 0 e 10000, escreva apenas
//�fizz� no console quando for divis�vel por 3, �buzz� quando for
//divis�vel por 5 e �fizz buzz� quando for divis�vel pelos dois.Se o
//n�mero n�o for divis�vel por nenhum deles, escreva-o no console.

    [SerializeField] int numero = 0;

    void Start()
    {
        while (numero < 10000)
        {
            numero++;

            if (numero % 3 == 0 && numero % 5 == 0)
            {
                print("fizz buzz");
            }
            if (numero % 3 == 0)
            {
                print("fizz");
            }
            if (numero % 5 == 0)
            {
                print("buzz");
            }
            else
            {
                print(numero);
            }
        }
    }

// Update is called once per frame
void Update()
{

}
}
using UnityEngine;

public class Atividade07 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Dado com N faces) Para fazer um jogo de RPG, vamos precisar calcular probabilidades e simular a rolagem de dados. Crie um script em que o usu�rio defina o n�mero de faces de um dado (int) e calcule a rolagem de um dado com esse n�mero de faces. Use a fun��o abaixo para o c�lculo: Random.Range (valor_min, valor_max); (Coloque o c�digo dentro da fun��o-evento Start).

    [SerializeField] int numeroDeFaces;
    int resultado;
    int valorMin = 1;

    void Start()
    {
        resultado = Random.Range(valorMin, numeroDeFaces + 1);

        print("Resultado da rolagem do dado com " + numeroDeFaces + " faces: " + resultado);
    }
}
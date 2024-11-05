using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Contador de horas e dias) Crie um script que em que uma variável inteira hora seja incrementada de uma unidade a cada 10 segundos e volte a ser 0 quando alcançar o valor 24. Quando completar um ciclo, incremente uma variável dias e escreva o número de dias que se passaram no console. (Coloque o código dentro da função-evento Update).

    void Start()
    { 
    
    }

    int hora = 0;
    int dias = 0;
    float segundos = 0f;

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;

        if (segundos >= 10f)
        {
            hora++;
            segundos = 0f;
            print("Dia: " + dias + ", " + "Hora: " + hora);

            if (hora == 24)
            {
                hora = 0;
                dias++;
                print("Dias: " + dias);
            }
        }
    }
}
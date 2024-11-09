using Unity.VisualScripting;
using UnityEngine;

public class Atividade03R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //    (Cálculo de moedas coletadas) O jogador coleta 3 moedas a
    //cada fase.Após 10 fases, exiba o total de moedas coletadas.

    [SerializeField] int fase = 0;
    [SerializeField] int moedas = 0;

    void Start()
    {
        while (fase < 10)
        {
            fase++;
            print("Fase: " + fase);

            moedas += 3;
            print("Moedas: " + moedas);
            

            if (fase == 10)
            {
                print("Após 10 fases, você tem " + moedas + " moedas!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

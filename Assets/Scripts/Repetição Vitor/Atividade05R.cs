using UnityEngine;

public class Atividade05R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //    (Aumento de nível de dificuldade) A cada fase completada, a
    //dificuldade aumenta em 5 pontos.Exiba a dificuldade após cada
    //fase, em um total de 6 fases.

    [SerializeField] int fase = 1;
    [SerializeField] int nivelDificuldade = 0;
    void Start()
    {
        do
        {
            fase++;
            print("Fase: " +  fase);
            nivelDificuldade += 5;

            if (fase == 1)
            {
                nivelDificuldade -= 5;
            }
            print("Nível de dificuldade: " + nivelDificuldade);
        } while (fase < 6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

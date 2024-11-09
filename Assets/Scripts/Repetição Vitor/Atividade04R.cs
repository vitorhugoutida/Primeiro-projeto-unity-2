using UnityEngine;

public class Atividade04R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //    (Pontuação em combos) Cada combo realizado aumenta em 10
    //pontos.Exiba a pontuação total após 7 combos.

    [SerializeField] int combo = 0;
    [SerializeField] int pontos = 0;

    void Start()
    {
        while (combo < 7)
        {
            combo++;
            print("Combo: " + combo);
            pontos += 10;
            print("Pontos: " + pontos);
            

            if (combo == 7)
            {
                print("Após 7 combos reealizado, você tem " +  pontos + " pontos.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

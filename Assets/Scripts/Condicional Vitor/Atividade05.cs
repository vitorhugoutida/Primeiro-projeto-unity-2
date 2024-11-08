using UnityEngine;

public class Atividade05 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Pontuação de missão) Após completar uma missão, o jogador recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim, exiba "Missão bem-sucedida"; caso contrário, "Missão incompleta".

    [SerializeField] bool completarMissao = true;
    [SerializeField] int pontos = 50;
    void Start()
    {
        if (completarMissao == true && pontos >= 50)
        {
            print("Missão bem-sucedida");
        }
        else
        {
            print("Missão incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

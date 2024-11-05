using UnityEngine;
using UnityEngine.UIElements;

public class Professor02 : MonoBehaviour
{
    // ATIVIDADE 02
    // (Detecção de power-up) Ao coletar um power-up, o personagem aumenta sua velocidade. Se o jogador encontrar um power-up, exiba "Power-Up Coletado". Caso contrário, exiba "Nenhum power-up encontrado".

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Se quiser colocar variavel de true or false precisa usar public bool

    [SerializeField] public int velocidadeJogador = 20;

    [SerializeField] bool powerUp;
    void Start()
    {
        if (powerUp == true)
        {
            print("Power-Up Coletado!");

            print("Power-Up Coletado");
            velocidadeJogador = 40;
        }
        else
        {
            print("Nenhum Power-Up encontrado");
        }

        // Condição ? Caso verdade : Caso falso

        print(!powerUp ? "Power-Up Coletado!" : "Nenhum Power-Up encontrado");

    }

    // Update is called once per frame
    void Update()
    {

    }
}

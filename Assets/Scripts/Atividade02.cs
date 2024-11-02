using UnityEngine;
using UnityEngine.UIElements;

public class Atividade02 : MonoBehaviour
{
    // ATIVIDADE 02
    // (Detecção de power-up) Ao coletar um power-up, o personagem aumenta sua velocidade. Se o jogador encontrar um power-up, exiba "Power-Up Coletado". Caso contrário, exiba "Nenhum power-up encontrado".

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] public int powerUp = 1;

    // Se quiser colocar variavel de true or false precisa usar public bool

    [SerializeField] public int velocidadeJogador = 20;
    void Start()
    {
        if (powerUp > 0)
        {
            print("Power-Up Coletado");
            velocidadeJogador = 40;
            // Não consegui colocar qualquer número para aumentar e eu preciso pesquisar...
        }
        else
        {
            print("Nenhum Power-Up encontrado");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using UnityEngine;
using UnityEngine.UIElements;

public class Atividade02 : MonoBehaviour
{
    // ATIVIDADE 02
    // (Detec��o de power-up) Ao coletar um power-up, o personagem aumenta sua velocidade. Se o jogador encontrar um power-up, exiba "Power-Up Coletado". Caso contr�rio, exiba "Nenhum power-up encontrado".

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] public int powerUp = 1;

    // N�o consegui colocar True, eu substitui true == 1, false = != 1 e eu preciso pesquisar...

    public int velocidadeJogador = 1;
    void Start()
    {
        if (powerUp == 1)
        {
            print("Power-Up Coletado");
            velocidadeJogador++;
            // N�o consegui colocar qualquer n�mero para aumentar e eu preciso pesquisar...
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

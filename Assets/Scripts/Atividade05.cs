using UnityEngine;

public class Atividade05 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim, exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o incompleta".

    [SerializeField] bool completarMissao = true;
    [SerializeField] int pontos = 50;
    void Start()
    {
        if (completarMissao == true && pontos >= 50)
        {
            print("Miss�o bem-sucedida");
        }
        else
        {
            print("Miss�o incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

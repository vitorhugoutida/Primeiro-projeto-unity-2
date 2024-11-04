using UnityEngine;
using UnityEngine.Video;
using static Unity.Burst.Intrinsics.X86;

public class Atividade04 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Verificar item de inventário) Um jogador possui itens limitados no inventário.Verifique se o jogador possui uma "Poção de Vida". Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção indisponível".

    [SerializeField] int pocaoDeVida = 1;
    string resultado;
    void Start()
    {
        resultado = (pocaoDeVida > 0) ? "Usando Poção de Vida" : "Poção indisponível";
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

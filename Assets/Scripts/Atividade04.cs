using UnityEngine;
using UnityEngine.Video;
using static Unity.Burst.Intrinsics.X86;

public class Atividade04 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // (Verificar item de invent�rio) Um jogador possui itens limitados no invent�rio.Verifique se o jogador possui uma "Po��o de Vida". Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o indispon�vel".

    [SerializeField] int pocaoDeVida = 1;
    string resultado;
    void Start()
    {
        resultado = (pocaoDeVida > 0) ? "Usando Po��o de Vida" : "Po��o indispon�vel";
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

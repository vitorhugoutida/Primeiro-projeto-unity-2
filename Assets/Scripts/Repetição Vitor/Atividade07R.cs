using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;


public class Atividade07R : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //    (Maior número em uma lista) Dada uma lista de números,
    //encontre o maior valor.

    void Start()
    {

        List<int> lista = new List<int> { 3, 26, 31, 5, 80 };
        int maiorValor = lista.Max();
        print(maiorValor); 

        }
        // Update is called once per frame
        void Update()
    {
        
    }
}

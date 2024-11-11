using System;
using UnityEngine;

public class Desafio : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //    Escreva um programa que conta o número de consoantes em uma string.
    //    Faça um algoritmo que receba o dia, o mês e o ano em que uma pessoa nasceu, imprima na tela quantos anos,
    //    meses e dias essa pessoa já viveu.Leve em consideração o ano com 365 dias e o mês com 30 dias.

    [SerializeField] int anosNasceu = 2000;
    //[SerializeField] int mesesNasceu = 3;
    //[SerializeField] int diasNasceu = 14;
    string idadeAno;

    void Start()
    {
        //var anosNasceu = 2000;

        var mesesNasceu = 3;

        var diasNasceu = 14;

        var diaAtual = DateTime.Today.ToString("dd");

        var mesAtual = DateTime.Now.ToString("MM");

        var anoAtual = DateTime.Now.ToString("yy");

        var idadeAno = DateTime.Now.ToString("yy") - anosNasceu;

        print(diaAtual);

        print(mesAtual);

        print(anoAtual);

        //var idadeAno = anosNasceu - anoAtual;


        print(anoAtual - anosNasceu);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

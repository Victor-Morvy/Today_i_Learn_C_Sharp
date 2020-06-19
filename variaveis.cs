using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class variaveis : MonoBehaviour
{

    //Comentário de apenas uma linha

    /* Comentário de várias linhas
    Tudo é comentário aqui dentro 
    */ //Fil comentário


    /*int carteira;
    float carteira2 = 10.5f;
    bool teste = false;
    */

    int carteira = 10;

    /*
    int moedas;
    float dinheiro = 10.0f;
    bool duvida = false;
    string texto = "Alguma coisa";
    */

    string texto;

    // Start is called before the first frame update
    void Start()
    {
        /*
        moedas = 10;
        print(moedas);
        */

        /*
        carteira = (int)carteira2;

        print(carteira);
        */
        /*
        carteira = Convert.ToInt32(teste);
        print(carteira);
        */

        texto = carteira.ToString();
        //print(texto + " teste");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

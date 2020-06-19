using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dictionary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Dictionary<string, string> vilao = new Dictionary<string, string>();

        vilao.Add("Matador", "É o primeiro vilão");
        vilao.Add("Atirador", "É o segundo vilão");
        vilao.Add("Lanceiro", "É o terceiro vilão");

        //vilao.Remove("Matador");

        foreach (string chave in vilao.Keys)
        {

            //if (chave == "Atirador")
            //{
                print(vilao[chave]);
            //}

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

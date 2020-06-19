using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class list : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        List<int> lista = new List<int> ();

        lista.Add(100);
        lista.Add(150);
        lista.Add(500);
        lista.Add(100);

        
        /*
        lista.Remove(100);
        lista.Remove(100);
        */

        print(lista[0]);
        print(lista[1]);
        print(lista[2]);
        print(lista[3]);

        print(lista.IndexOf(100));
        print(lista.LastIndexOf(100));

        print("--------------");

        foreach(int valores in lista)
        {
            print(valores);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

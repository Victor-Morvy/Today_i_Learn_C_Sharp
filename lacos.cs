using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lacos : MonoBehaviour
{

    string[] inimigos;

    int i = 0, j = 0;

    // Start is called before the first frame update
    void Start()
    {
        
        
        for (int x = 0; x <= 10; x++)
        {
            if (x == 4)
            {
                continue;
            }else if (x == 8)
            {
                break;
            }
            else
            {
                print("x = " + x);
            }

        }
        
        /*
        while (i <= 10)
        {
            //print(i);
            i++;
        }

        do
        {

            print(++j);

        } while (j <= 10);
        */

        /*
        inimigos = new string[4];
        inimigos[0] = "caveira";
        inimigos[1] = "matador";
        inimigos[2] = "atirador";
        inimigos[3] = "mark";

        foreach (string nome in inimigos)
        {   
            
            if (nome == "matador")
            {
                print("pulou!!");
                
            } else
            {
                print(nome);
            }
                
        }
        */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

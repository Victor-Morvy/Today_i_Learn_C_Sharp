using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelse : MonoBehaviour
{

    //Estado = 1 - coragem
    //Estado = 2 - meio termo
    //Estado = 3 - covardia

    int estados = 3;

    // Start is called before the first frame update
    void Start()
    {

        if (estados == 0)
        {
            print("Oloco meu é 0");
        } else if (estados == 1)
        {
            print("Foi bixo!");
        }
        else
        {
            print("Tudo por água abaixo");
        }


        switch (estados)
        {
            case 1:
                print("mate o heroi");
                break;

            case 2:
                print("mate se puder");
                break;

            case 3:
                print("foge agora");
                break;

            default:
                print("deu ruim");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

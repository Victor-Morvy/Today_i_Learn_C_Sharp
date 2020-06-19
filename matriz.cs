using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matriz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        int[,] matriz = new int[2, 3];
        matriz[0, 1] = 2;

        print(matriz[0, 0]);
        print(matriz[0, 1]);
        */

        int[,,] matriz = new int[2, 2, 3];
        matriz[0, 0, 1] = 2;

        print(matriz[0, 0, 0]);
        print(matriz[0, 0, 1]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

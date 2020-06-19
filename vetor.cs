using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vetor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // int[] array = {1, 2, 3, 4};
        //int[] array = new int[4]{4, 3, 2, 1};

        /*
        int[] array = new int[4];
        array[0] = 2;
        array[1] = 4;
        array[3] = 6;
        array[4] = 8;
        */

        int[] array = new int[10];

        for (int i = 0; i <= 9; i++)
        {
            array[i] = i + 1;
            print(array[i]);
        }
        
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

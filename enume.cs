using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enume : MonoBehaviour
{

    enum AI {Atacar=1, Correr, Patrulhar} //Atacar=1 força o índice ser aquele valor

    // Start is called before the first frame update
    void Start()
    {

        AI vilaofase1 = AI.Patrulhar;
        AI vilaofase2 = AI.Atacar;

        print(vilaofase1);

        int v1 = (int)vilaofase1;

        print(v1);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encapsulamento : MonoBehaviour
{
    pPai p;

    // Start is called before the first frame update
    void Start()
    {

        p = new pPai();

        p.Idade = 8;

        print(p.Idade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


class pPai : MonoBehaviour
{
    private int idade = 10; //private, nenhuma outra class terá acesso

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value > 10)
            {
                idade = value;
            }
            else
            {
                print("Erro!");
            }
        }
            
    }
    
}
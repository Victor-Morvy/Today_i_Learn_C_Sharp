using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estatico : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int retorno = met.soma(2, 2);

        print(retorno);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class met
{
    public static int soma(int valor1, int valor2) 
        //com static é possível chamar o metodo sem ter iniciado o objeto
    {
        int result = valor1 + valor2;
        
        return result;
    }
}
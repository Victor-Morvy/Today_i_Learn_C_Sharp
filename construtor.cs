using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class construtor : MonoBehaviour
{
    __metodos obj;

    // Start is called before the first frame update
    void Start()
    {
        obj = new __metodos(200, "pqps");

       print(obj.valor1);
       print(obj.valor2);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

class __metodos
{
    public int valor1;
    public string valor2;

    public __metodos(int valor, string val) //inicia o objeto com os 2 atributos
    {
        this.valor1 = valor;
        this.valor2 = val;

    }
}

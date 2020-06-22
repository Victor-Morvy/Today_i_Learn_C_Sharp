using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class metodos : MonoBehaviour
{

    _metodos somar;

     // Start is called before the first frame update
    void Start()
    {
        int val;
        somar = new _metodos();

        val = somar.soma(12, 18);
        print(val);
        

    }

    // Update is called once per frame
    void Update()
    {

    }
}

class _metodos : MonoBehaviour //diferenciar do nome métodos
{

    public int soma(int valor1, int valor2)
    {
        int resultado = valor1 + valor2;

        return resultado;
    }


}

//public (acesso livre em qualquer classe)
//private (fica restrito interno da classe)
//protected (protege o método e características, apenas quem acessa é a classe filha
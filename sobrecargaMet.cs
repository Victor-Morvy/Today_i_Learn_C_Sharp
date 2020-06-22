using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sobrecargaMet : MonoBehaviour
{

    calculadora calc;

    // Start is called before the first frame update
    void Start()
    {
        int resultInt;
        float resultFloat;

        calc = new calculadora();

        resultInt = calc.calcula(5, 2);

        resultFloat = calc.calcula(2.5f, 2.1f);

        print(resultInt);
        print(resultFloat);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Sobrecarga de metodos - trabalha com metodos de mesmo nome, mas com tipos de variáveis diferentes

class calculadora
{

    public int calcula(int x, int y)
    {
        return x + y;
    }

    public float calcula(float x, float y)
    {
        return x + y;
    }

}
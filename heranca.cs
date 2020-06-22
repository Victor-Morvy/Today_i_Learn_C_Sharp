using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heranca : MonoBehaviour
{

    Filho teste;

    // Start is called before the first frame update
    void Start()
    {
        teste = new Filho();

        print(teste.pegaIdade());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class Pai
{
    public int idade = 20;

  
}

class Filho : Pai
{
    public int pegaIdade()
    {
        return this.idade;

        //return base.idade;
    }
}
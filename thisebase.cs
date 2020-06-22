using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thisebase : MonoBehaviour
{
    //pai p;
    filho f;
    // Start is called before the first frame update
    void Start()
    {

       // p = new pai(29);

        f = new filho();

        f.pegaIdade();

        //print(p.idade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class pai : MonoBehaviour
{
    public int idade = 30;

    /*
    public pai(int idade)
    {
        this.idade = idade; //Utilizando o this.idade é possível usar então o nome da variável idade no metodo
    }
    */
}

class filho : pai
{
    public void pegaIdade()
    {
        print(base.idade); //base pega a variável da classe pai
    }
}
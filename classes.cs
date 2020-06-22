using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class classes : MonoBehaviour
{

    felino gatoFase1;
    felino gatoFase2;
    filha filhos;

    // Start is called before the first frame update
    void Start()
    {
        gatoFase1 = new felino();
        gatoFase2 = new felino();
        filhos = new filha();

        filhos.acessa();


        
       

        gatoFase1.atacar();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class felino : MonoBehaviour
{
    ///Características
    protected string nome;
    public string corPelo;
    private int forca;

    ///Ações
    public void atacar()
    {

    }

    private void defender()
    {

    }

    protected void curar()
    {

    }

 

}

class filha : felino
{
    public void acessa()
    {
        corPelo = "amarelo;";
        nome = "Gato";
        print(nome);
    }

    

}

//public (acesso livre em qualquer classe)
//private (fica restrito interno da classe)
//protected (protege o método e características, apenas quem acessa é a classe filha
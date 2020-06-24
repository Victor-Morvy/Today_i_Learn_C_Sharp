using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    /*/exercício 1
    int vidas_n, moeda_n, nome, energia;
    */

    /*/exercício 2
    void soma(int valor1, int valor2)
    {
        int result = valor1 + valor2;

        print(result);
    }
    */

    /*/exercício 5
    string[] viloes = new string[5];
    */

    /*/exercício 6
    List<int> lista = new List<int>();
    */


    //Zombie zombie;

    Zombie_filho zombie;

    // Start is called before the first frame update
    void Start()
    {
        /*/exercício 2
        soma(12, 15);
        */

        /*/exercício 4
        for (int i = 0; i <= 10; i++)
        {
            print(i);
        }
        */

        /*/exercício 5
        viloes[0] = "Lex Lutor";
        viloes[1] = "Coringa";
        viloes[2] = "Tanus";
        viloes[3] = "Dr. Eggman";
        viloes[4] = "Destruidor";

        foreach (string v in viloes)
        {
            print(v);
        }
        */

        /*/exercício 6
        
        lista.Add(470);
        lista.Add(14);
        lista.Add(49);
        lista.Add(1);
        lista.Add(18);
        lista.Add(24);
        lista.Add(92);
        lista.Add(24);
        lista.Add(92);
        lista.Add(24);
        

        int i = 0;
        foreach (var a in lista)
        {

            print(a + " " + i);
            i++;
        }
        */

        //Exercício 7
        zombie = new Zombie_filho(30.0f, 3, 2);

        //Exercício 8
        print("Vida: " + zombie.vidaAtual + "/" + zombie.vidaTotal);
        print("Ataque: " + zombie.ataque);
        print("Defesa: " + zombie.defesa);

        zombie.atacar();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//Exercício 7
public class Zombie : MonoBehaviour
{
    public float vidaAtual;
    public float vidaTotal;
    public int ataque;
    public int defesa;
    public bool bracoDir = true;
    public bool bracoEsq = true;
    public bool pernaDir = true;
    public bool pernaEsq = true;
   
    public virtual void atacar() //virtual pode reescrever o metodo
    {
        print("O Zombie atacou!");
    }

    /*
    public Zombie(float vida_total, int atk, int def)
    {
        this.vidaTotal = vida_total;
        this.vidaAtual = vida_total;
        this.ataque = atk;
        this.defesa = def;
    }
    */
    
}

//Exercício 9

public class Zombie_filho : Zombie
{
    public Zombie_filho(float vida_total, int atk, int def)
    {
        base.vidaTotal = vida_total;
        base.vidaAtual = vida_total;
        base.ataque = atk;
        base.defesa = def;
    }
    
    //Exercício 10
    public override void atacar()
    {
        print("O Zombie Filho atacou!");
    }
    


}
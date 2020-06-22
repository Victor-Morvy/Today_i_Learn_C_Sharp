using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polimorfismo : MonoBehaviour
{
    leao leo;
    gato cat;

    // Start is called before the first frame update
    void Start()
    {

        leo = new leao();

        cat = new gato();

        leo.comer();

        cat.comer();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


class animal : MonoBehaviour
{
    public virtual void comer()
    {
        print("Animal está comendo");
    }
}

class leao : animal
{
    public override void comer()
    {
        print("Leão está comendo"); //base.comer();
    }
}

class gato : animal
{
    public override void comer()
    {
        print("Gato está comendo");
    }

}

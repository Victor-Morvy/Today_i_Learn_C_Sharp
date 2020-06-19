using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variaveis2 : MonoBehaviour
{

    // int carteira = 100;

    // Start is called before the first frame update

    int carteira;

    void Start()
    {
        /*
        num1 = 10;
        num2 = 27;
        num3 = 4;

        resultado = num1 + num2;
        resultado = num1 - num2;
        resultado = num1 * num2;
        resultado = num2 / num1;
        resultado = num2 % num3; //módulo, retorna o resto da divisão (6 x 4 - 27 = 3)

        print(resultado);
        */

        /*
        print(carteira++); //++ é pós incremento, por conta disso o print ainda não atualizou a variável com o incremento
        print(carteira);
        print(++carteira); //++ é pré incremento, por conta disso o print já aparece com a carteira atualizada
        print(carteira--);
        print(carteira);
        print(--carteira);
        */

        carteira = 10;

        carteira += 2;

        //print(carteira);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScrpt : MonoBehaviour
{
    //Variables
    //El Tipo de Datp       Nombre
    int numeroDeSaltos =0;

    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int tercerLogroSaltos = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        numeroDeSaltos = numeroDeSaltos + 1;

        /* Debug.Log(gameObject.name + ":" + "He chocado con" + " " + collision.gameObject.name);
        Debug.Log("Veces que ha colisionado" + " " + gameObject.name + " " + miVariable);
        */
        
        if (numeroDeSaltos == primerLogroSaltos || numeroDeSaltos == segundoLogroSaltos || numeroDeSaltos == tercerLogroSaltos)
        {
            Debug.Log(gameObject.name + ":" + "He chocado " + numeroDeSaltos + " veces");
        }

    }
}

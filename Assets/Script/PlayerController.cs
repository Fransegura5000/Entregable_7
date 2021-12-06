using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public TextMeshProUGUI mensajeCanvas;
    private string mensajePorPantalla;


    void Start()
    {
       mensajePorPantalla = "Pulsa cualquiera de las cuatro flechas";   // con esta linea hacemos que cuando empieze tenga el valor de ese texto. 
       mensajeCanvas.text = mensajePorPantalla;                         // 
       

    }

    // Update is called once per frame
    void Update()
    {
        mensajeCanvas.text = mensajePorPantalla;            // Actualiza por pantalla el valor de mensajeCanvas:

        ShowMessage(mensajePorPantalla,KeyCode.LeftArrow);  // funciona pero no se como, a la hora de poner el KeyCode, left arrow, no se por que la verdad, para que mentirnos.

    }


    public void ShowMessage(string message, KeyCode key) //esta es la función que hemos creado, que cada vez que se pulsa una tecla le cambia el valor a la variable.
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            mensajePorPantalla = "Derecha";
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            mensajePorPantalla = "Izquierda";
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            mensajePorPantalla = "Arriba";
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            mensajePorPantalla = "Abajo";
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mensajePorPantalla = "!PUM!";
        }

    }

    //Gracias por la ayuda en discord :P
}

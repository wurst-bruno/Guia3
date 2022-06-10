


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosTipoNtivos : MonoBehaviour
{
    public float mifloat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HolaMundoEnLaConsola();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EscribirParametroEnConsola("El martes se entregan los juegos");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EscribirParametroEnConsola(ObtenerParteEnteraEnString(mifloat));
        }
    }
       ////Definir una función que escriba en consola “Hola Mundo!” al ser invocada.Invocar la función al presionar la barra espaciadora.

    void HolaMundoEnLaConsola()
    {
        Debug.Log("Hola Mundo!");

    }

    //Definir una función que escriba en consola la cadena pasada por parámetro.

    void EscribirParametroEnConsola(string cadena)
    {
        Debug.Log(cadena);
    }

    //Recibe un float por parámetro y lo procesa para devolver la parte entera 
    //como un string. mostrar el dato devuelto en la consola utilizando la funcion del punto 1.2

    string ObtenerParteEnteraEnString(float num)
    {
        string retorno = "";
        retorno =  Mathf.Floor(num).ToString();
        return retorno;

    }

    //Definir una función que reciba tres enteros y devuelva el mayor de ellos.Si son los tres iguales 
    //retornar -1.  Mostrar el dato devuelto en la consola utilizando la función del punto 1.2.


}

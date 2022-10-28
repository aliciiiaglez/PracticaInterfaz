using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;


//Lo colocamos en el objeto de las opciones
public class ChangeLanguage : MonoBehaviour
    
{
    int idiomaActual = 0;
    void Awake()
    {
        //Array con los diferentes idiomas que tiene el juego
        //LocalizationSettings.AvailableLocales.Locales
        //idiomas = (Español, Inglés, Francés, Italiano, Alemán)

        //El idio que se está utilizando
        //LocalizationSettings.SelectedLocale

        //Total de idiomas disponibles
        //Códigos de prueba
        
        
        
        int langAvailables = LocalizationSettings.AvailableLocales.Locales.Count;
    }

    public void NextLanguage()
    {
        
        idiomaActual++;
        if (idiomaActual > 5)
        {
            Debug.Log("Reinicio cuenta" + idiomaActual);

            idiomaActual = 0;

        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaActual];
        
    }
    //Funcion next language

    /*
        arrayNumeros = {5 10 15 0 2 8}

        arrayNumeros[4] => 2
        arrayNumeros[1] => 10

    */

    //Funcion previous Language
}


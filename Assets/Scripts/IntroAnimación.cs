using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAnimación : MonoBehaviour
{
    [SerializeField]
    GameObject logo;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveLocalY(logo, -450f, 0f);
        //hago aparecer el logo desde su posición hacia la posicion 110f en el eje Y
        LeanTween.moveLocalY(logo, 68f, 1.0f).setEaseInElastic().setOnComplete(Latido);
        //para moverlo localmente en ambos ejes
        //LeanTween.moveLocal(LogoCinematic, new Vector3(10f,2f, 0f,), 1.5f)
    }

    // Update is called once per frame
    void Latido()
    {
        LeanTween.scale(logo, Vector3.one * 1.5f, 1f).setEaseOutBack().setOnComplete(() => {
            LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 0.5f).setOnComplete(Desactivar);
        
        });
    }
    void Desactivar()
    {
        gameObject.SetActive(false);
        //Activar el menú principal...
    }
    //On disable pa que deje de aparecer
}


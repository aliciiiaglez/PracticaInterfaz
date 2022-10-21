using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFile : MonoBehaviour
{
    Image image;

    
    private void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 0.5f;
    }

    // Update is called once per frame
    public void Health_Damage(float valor)
    {
        image.fillAmount += valor;
    }
}

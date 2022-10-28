using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScaler : MonoBehaviour
{
    // Start is called before the first frame update
    public void ScaleUp()
    {
        LeanTween.scale(gameObject, Vector3.one * 4f, 0.5f).setEaseInBounce();

    }

    // Update is called once per frame
    public void ScaleDown()
    {
        LeanTween.scale(gameObject, Vector3.one, 2f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthPlayer : MonoBehaviour
{
    [SerializeField]
    int MAX_HEALTH = 20;
    [SerializeField]
    int healthPlayer = 5;
    [SerializeField]
    Slider sliderHealth;

    // Start is called before the first frame update
    void Start()
    {
        sliderHealth.maxValue = MAX_HEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

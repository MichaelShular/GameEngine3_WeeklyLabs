using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class lightscript : MonoBehaviour
{
    [SerializeField] private float lightPulserate = 1.0f;
    private float nextPulse = 0.0f;
    private float signCheck = 1.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextPulse)
        {
            nextPulse = Time.time + lightPulserate;
            if(GetComponent<Light2D>().pointLightInnerRadius == 3.0f) 
            {
                signCheck = -1;
            }
            if (GetComponent<Light2D>().pointLightInnerRadius == 0.5f)
            {
                signCheck = 1;
            }
            GetComponent<Light2D>().pointLightInnerRadius = GetComponent<Light2D>().pointLightInnerRadius + (signCheck * 0.5f);
            Debug.Log("1");
        }

    }
}

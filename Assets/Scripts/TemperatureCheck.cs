using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemperatureCheck : MonoBehaviour
{
    [SerializeField] private float porridgeTemperature = 85f;

    private float hotLimitTemperature = 70f;
    private float coldLimitTemperature = 40f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        porridgeTemperature -= Time.deltaTime * 5f;
    }
    void TemperatureTest()
    {
        if(porridgeTemperature > hotLimitTemperature)
        {
            Debug.Log("The porridge is too hot!");
        }
        else if(porridgeTemperature < coldLimitTemperature)
        {
            Debug.Log("The porridge is too cold!" + (int)porridgeTemperature);
        }
        else
        {
            Debug.Log("Porridge is just right");
        }
    }
}

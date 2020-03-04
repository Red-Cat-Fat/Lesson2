using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetected : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("В "+ gameObject.name + " вошёл " + other.gameObject.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Внутри "+ gameObject.name + " находится " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Из "+ gameObject.name + " вышел " + other.gameObject.name);
    }
}

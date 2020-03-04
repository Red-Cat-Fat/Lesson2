using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class OnEnableAndDestroyMessage : MonoBehaviour
{
    [SerializeField]
    private string _enableMessage;
    [SerializeField]
    private string _destroyMessage;

    //этот метод вызовется когда объект станет активным в сцене
    private void OnEnable()
    {
        Debug.Log(gameObject.name + " говорит при создании: \n" + _enableMessage);
    }

    //этот метод вызовется перед уничтожением объекта
    private void OnDestroy()
    {
        Debug.Log(gameObject.name + " говорит перед смертью: \n" + _destroyMessage);
    }
}

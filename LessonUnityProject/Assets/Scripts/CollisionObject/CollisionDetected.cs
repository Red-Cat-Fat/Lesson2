using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetected : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("С "+ gameObject.name + " столкнулся " + other.gameObject.name);
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log("С "+ gameObject.name + " соприкасается " + other.gameObject.name);
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log(gameObject.name + " и " + other.gameObject.name + " перестали соприкасаться");
    }
}

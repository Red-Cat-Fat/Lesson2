using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputDemo : MonoBehaviour
{
    [Tooltip("Отследивание удержания кнопки")]
    [SerializeField]
    private KeyCode _checkKeyPress;
    [Tooltip("Отследивание нажатия кнопки")]
    [SerializeField]
    private KeyCode _checkKeyDown;
    [Tooltip("Отследивание отпускания кнопки")]
    [SerializeField]
    private KeyCode _checkKeyUp;
    private void Update()
    {
        if (Input.GetKey(_checkKeyPress))
        {
            Debug.Log("В данный момент удерживается кнопка " + _checkKeyPress);
        }

        if (Input.GetKeyDown(_checkKeyDown))
        {
            Debug.Log("Была нажата кнопка " + _checkKeyDown);
        }

        if (Input.GetKeyUp(_checkKeyUp))
        {
            Debug.Log("Была отпущена кнопка " + _checkKeyUp);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovebleObject : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Коеффицент для настройки чуствительности перемещения")]
    private float _movebleCoef = 20f;
    private bool _isMove;
    private Vector3 _startObjectPosition;
    private Vector3 _startCursorePosition;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //если в этом кадре ЛКМ была нажата
        {
            _isMove = true;
            _startCursorePosition = Input.mousePosition;
            _startObjectPosition = transform.position;
        }

        if (Input.GetMouseButtonUp(0)) //если в этом кадре ЛКМ была поднята
        {
            _isMove = false;
        }

        if (_isMove)
        {
            var mouseShift = Input.mousePosition - _startCursorePosition;
            transform.position = _startObjectPosition + mouseShift/_movebleCoef;
        }
    }
}

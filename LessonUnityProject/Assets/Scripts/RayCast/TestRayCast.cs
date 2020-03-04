using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRayCast : MonoBehaviour
{
    private enum ActionType
    {
        None,
        Create,
        Destroy
    }
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private GameObject _createPrefab;
    private ActionType _action;
    
    void Update()
    {
        _action = ActionType.None;
        if (Input.GetMouseButton(0))
        {
            _action = ActionType.Create;
        }

        if (Input.GetMouseButton(1))
        {
            _action = ActionType.Destroy;
        }

        if (_action != ActionType.None)
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition); //отправляем луч из камеры

            if (Physics.Raycast(ray, out var hit))     //если луч с чем-то столкнулся
            {
                if (_action == ActionType.Create)
                {
                    var hitPoint = hit.point;     //берём трансформ точки соприкосновения
                    Instantiate(_createPrefab, hitPoint, Quaternion.identity);    //создаём указаный префаб
                }
                else
                {
                    if (hit.collider != null && hit.collider.gameObject != null)
                    {
                        Destroy(hit.collider.gameObject);     //удаляем объект по которому клинули
                    }
                }
            }
        }
    }
}

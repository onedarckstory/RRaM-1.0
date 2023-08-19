using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public GameObject childObject;
    public Transform newParent;

    // Вызывается при нажатии кнопки.
    public void SetNewParent(Transform newParent)
    {
        // Устанавливаем нового родителя для дочернего объекта.
        childObject.transform.SetParent(newParent);

        // Если нужно сохранить локальную ориентацию дочернего объекта,
        // можно использовать второй аргумент метода SetParent и передать в него значение false.
        childObject.transform.SetParent(newParent, false);

        // Если нужно удалить объект из текущего родителя и сделать его объектом верхнего уровня,
        // можно передать null в качестве нового родителя.
        childObject.transform.SetParent(null);
    }
}
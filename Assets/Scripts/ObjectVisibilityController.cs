using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVisibilityController : MonoBehaviour
{
    public GameObject parentObject; // родительский объект
    public GameObject objectToFollow; // объект, который будет следовать за передвижением камеры

    private bool isVisible = true; // флаг видимости объекта

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleObjectVisibility();
        }

        if (objectToFollow != null && parentObject != null)
        {
            objectToFollow.transform.position = parentObject.transform.position; // устанавливаем позицию объекта равной позиции родительского объекта
            objectToFollow.transform.rotation = parentObject.transform.rotation; // устанавливаем поворот объекта равным повороту родительского объекта
        }
    }

    private void ToggleObjectVisibility()
    {
        isVisible = !isVisible; // инвертируем флаг видимости
        objectToFollow.SetActive(isVisible); // устанавливаем активность объекта в соответствии с флагом видимости
    }
}
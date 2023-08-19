using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceController : MonoBehaviour
{
    public GameObject interfaceObject; // объект интерфейса

    private void Update()
    {
        // Проверяем нажатие кнопки Tab
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Если интерфейс активен, отключаем его
            if (interfaceObject.activeSelf)
            {
                interfaceObject.SetActive(false);
            }
            // Если интерфейс отключен, включаем его
            else
            {
                interfaceObject.SetActive(true);
            }
        }
    }
}
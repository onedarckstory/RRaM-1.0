using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceUpdater : MonoBehaviour
{
    public Transform target;
    public Transform uiElement;
   

    private void Update()
    {
        if (target != null && uiElement != null)
        {
            // Обновление позиции элемента интерфейса
            Vector3 uiPosition = Camera.main.WorldToScreenPoint(target.position);
            uiElement.position = uiPosition;

            
        }
    }
}
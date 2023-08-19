using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            offset = gameObject.transform.position -
                     Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

            isDragging = true;
        }
    }

    void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            gameObject.transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }

    void OnMouseUp()
    {
        isDragging = false;
    }
}
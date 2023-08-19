using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Rigidbody2D rb2D;
    private Rigidbody rb3D;
    public float moveSpeed = 10f;
    public float heightAdjustment = 0f; // Поле для регулировки высоты поднятия

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb3D = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            isDragging = true;
            offset = transform.position - GetMouseWorldPosition();

            if (rb2D != null)
            {
                rb2D.bodyType = RigidbodyType2D.Kinematic;
            }
            else if (rb3D != null)
            {
                rb3D.isKinematic = true;
            }
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;

        if (rb2D != null)
        {
            rb2D.bodyType = RigidbodyType2D.Dynamic;
        }
        else if (rb3D != null)
        {
            rb3D.isKinematic = false;
        }
    }

    private void Update()
    {
        if (isDragging)
        {
            Vector3 mousePos = GetMouseWorldPosition() + offset;
            mousePos.y += heightAdjustment; // Добавляем высоту поднятия к позиции мыши
            Vector3 newPos = Vector3.Lerp(transform.position, mousePos, moveSpeed * Time.deltaTime);
            if (rb2D != null)
            {
                rb2D.MovePosition(newPos);
            }
            else if (rb3D != null)
            {
                rb3D.MovePosition(newPos);
            }
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
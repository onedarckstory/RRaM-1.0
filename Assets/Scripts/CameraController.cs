using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowwMouse : MonoBehaviour
{
    public GameObject targetObject;
    public float minDistance = 5f;
    public float maxDistance = 10f;
    public float moveSpeed = 1f;
    public float damping = 1f;

    private Vector3 offset;
    private bool isMoving;

    private void Start()
    {
        if (targetObject != null)
        {
            offset = transform.position - targetObject.transform.position;
        }
        else
        {
            Debug.LogError("Target object is not assigned!");
        }
    }

    private void Update()
    {
        if (targetObject == null)
        {
            return;
        }

        float distanceToTarget = Vector3.Distance(transform.position, targetObject.transform.position);

        // Проверяем, достигнут ли минимальный порог приближения к объекту
        if (distanceToTarget <= minDistance)
        {
            isMoving = true;
        }

        // Проверяем, достигнут ли максимальный порог расстояния от объекта
        if (distanceToTarget >= maxDistance)
        {
            isMoving = false;
        }

        // Если камера приближается к объекту, перемещаем камеру
        if (isMoving)
        {
            Vector3 targetPosition = targetObject.transform.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject targetObject;
    public float minDistance = 5f;
    public float maxDistance = 10f;
    public float moveSpeed = 1f;
    public float damping = 1f;

    private Vector3 offset;
    private bool isMoving;
    private bool isShiftPressed;

    private void Start()
    {
        offset = transform.position - targetObject.transform.position;
    }

    private void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, targetObject.transform.position);

        if (distanceToTarget <= minDistance)
        {
            isMoving = true;
        }

        if (distanceToTarget >= maxDistance)
        {
            isMoving = false;
        }

        if (isMoving)
        {
            Vector3 targetPosition = targetObject.transform.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isShiftPressed = true;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isShiftPressed = false;
        }

        if (isShiftPressed)
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            Vector3 movement = new Vector3(-mouseX, -mouseY, 0f) * moveSpeed * Time.deltaTime;
            targetObject.transform.Translate(movement);

            float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
            Vector3 forward = transform.forward * scrollWheel * moveSpeed * Time.deltaTime;
            targetObject.transform.Translate(forward, Space.World);
        }
    }
}
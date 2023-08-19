using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMovement : MonoBehaviour
{
    public Button moveButton;
    public GameObject targetObject;
    public GameObject interfaceUI;

    private bool isMoving = false;

    void Start()
    {
        if (moveButton != null)
        {
            moveButton.onClick.AddListener(MoveCameraToTarget);
        }
        else
        {
            Debug.LogError("Move button is not assigned!");
        }
    }

    void FixedUpdate()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetObject.transform.position, Time.deltaTime * 15f);

            if (Vector3.Distance(transform.position, targetObject.transform.position) < 21f)
            {
                if (interfaceUI != null)
                {
                    interfaceUI.SetActive(true);
                }
                else
                {
                    Debug.LogError("Interface UI is not assigned!");
                }
                isMoving = false;
            }
        }
    }

    void MoveCameraToTarget()
    {
        if (!isMoving)
        {
            if (interfaceUI != null)
            {
                interfaceUI.SetActive(false);
            }
            else
            {
                Debug.LogError("Interface UI is not assigned!");
            }
            isMoving = true;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControlller : MonoBehaviour
{
    public GameObject interfaceObject; // объект интерфейса

    private void Start()
    {
        AttachToObject();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleInterfaceObject();
        }
    }

    private void AttachToObject()
    {
        if (interfaceObject != null)
        {
            transform.SetParent(interfaceObject.transform, false);
            transform.localPosition = Vector3.zero;
        }
    }

    private void DetachFromObject()
    {
        transform.SetParent(null, true);
    }

    private void ToggleInterfaceObject()
    {
        if (interfaceObject != null)
        {
            interfaceObject.SetActive(!interfaceObject.activeSelf);

            if (interfaceObject.activeSelf)
            {
                AttachToObject();
            }
            else
            {
                DetachFromObject();
            }
        }
    }
}
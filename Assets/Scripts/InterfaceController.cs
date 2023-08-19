using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceController : MonoBehaviour
{
    public GameObject interfaceObject; // ������ ����������

    private void Update()
    {
        // ��������� ������� ������ Tab
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // ���� ��������� �������, ��������� ���
            if (interfaceObject.activeSelf)
            {
                interfaceObject.SetActive(false);
            }
            // ���� ��������� ��������, �������� ���
            else
            {
                interfaceObject.SetActive(true);
            }
        }
    }
}
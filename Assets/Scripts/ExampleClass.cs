using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    public GameObject childObject;
    public Transform newParent;

    // ���������� ��� ������� ������.
    public void SetNewParent(Transform newParent)
    {
        // ������������� ������ �������� ��� ��������� �������.
        childObject.transform.SetParent(newParent);

        // ���� ����� ��������� ��������� ���������� ��������� �������,
        // ����� ������������ ������ �������� ������ SetParent � �������� � ���� �������� false.
        childObject.transform.SetParent(newParent, false);

        // ���� ����� ������� ������ �� �������� �������� � ������� ��� �������� �������� ������,
        // ����� �������� null � �������� ������ ��������.
        childObject.transform.SetParent(null);
    }
}
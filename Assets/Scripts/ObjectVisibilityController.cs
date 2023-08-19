using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVisibilityController : MonoBehaviour
{
    public GameObject parentObject; // ������������ ������
    public GameObject objectToFollow; // ������, ������� ����� ��������� �� ������������� ������

    private bool isVisible = true; // ���� ��������� �������

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleObjectVisibility();
        }

        if (objectToFollow != null && parentObject != null)
        {
            objectToFollow.transform.position = parentObject.transform.position; // ������������� ������� ������� ������ ������� ������������� �������
            objectToFollow.transform.rotation = parentObject.transform.rotation; // ������������� ������� ������� ������ �������� ������������� �������
        }
    }

    private void ToggleObjectVisibility()
    {
        isVisible = !isVisible; // ����������� ���� ���������
        objectToFollow.SetActive(isVisible); // ������������� ���������� ������� � ������������ � ������ ���������
    }
}
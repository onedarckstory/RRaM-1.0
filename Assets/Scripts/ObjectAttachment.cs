using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAttachment : MonoBehaviour
{
    public GameObject parentObject; // ������, � �������� ����� ��������� ������ ������
    public GameObject objectToAttach; // ������, ������� ����� ��������

    private void Start()
    {
        // ����� SetParent ����������� ������ � ������������� �������
        objectToAttach.transform.SetParent(parentObject.transform);
    }
}
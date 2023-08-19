using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraController : MonoBehaviour
{
    private bool isCtrlPressed = false;

    private void Update()
    {
        // ���������, ������ �� ������� "Ctrl"
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            isCtrlPressed = true;
        }
        else
        {
            isCtrlPressed = false;
        }

        // ���� ������� "Ctrl" ������, ����������� ������
        if (isCtrlPressed)
        {
            float moveSpeed = 10f; // �������� ������������

            // �������� �������� �������� �� ����
            float moveX = Input.GetAxis("Mouse X");
            float moveY = Input.GetAxis("Mouse Y");

            // ����������� ������ �� ������ �������� ��������
            transform.Translate(new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime);
        }
    }
}
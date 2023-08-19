using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraController : MonoBehaviour
{
    private bool isCtrlPressed = false;

    private void Update()
    {
        // Проверяем, нажата ли клавиша "Ctrl"
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            isCtrlPressed = true;
        }
        else
        {
            isCtrlPressed = false;
        }

        // Если клавиша "Ctrl" нажата, передвигаем камеру
        if (isCtrlPressed)
        {
            float moveSpeed = 10f; // Скорость передвижения

            // Получаем значения движения по осям
            float moveX = Input.GetAxis("Mouse X");
            float moveY = Input.GetAxis("Mouse Y");

            // Передвигаем камеру на основе значений движения
            transform.Translate(new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectObjects : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    private FixedJoint joint;

    void Start()
    {
        // Добавляем компонент FixedJoint к object1
        joint = object1.AddComponent<FixedJoint>();

        // Устанавливаем объект, к которому должно быть прикреплено соединение
        joint.connectedBody = object2.GetComponent<Rigidbody>();
    }
}
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
        // ��������� ��������� FixedJoint � object1
        joint = object1.AddComponent<FixedJoint>();

        // ������������� ������, � �������� ������ ���� ����������� ����������
        joint.connectedBody = object2.GetComponent<Rigidbody>();
    }
}
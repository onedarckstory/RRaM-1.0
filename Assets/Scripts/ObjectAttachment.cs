using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAttachment : MonoBehaviour
{
    public GameObject parentObject; // объект, к которому нужно подвязать другой объект
    public GameObject objectToAttach; // объект, который будет подвязан

    private void Start()
    {
        // Метод SetParent привязывает объект к родительскому объекту
        objectToAttach.transform.SetParent(parentObject.transform);
    }
}
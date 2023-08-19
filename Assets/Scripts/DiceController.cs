using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController : MonoBehaviour
{
    private Rigidbody rb;
    private bool isRolling = false;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

   
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isRolling)
        {
            RollDice();
        }
       
        
    }

    void RollDice()
    {
        isRolling = false;

        float randomForce = Random.Range(2f, 1f);
        float randomTorque = Random.Range(2f, 1f);

        rb.AddForce(Vector3.up * randomForce, ForceMode.Impulse);
        rb.AddTorque(new Vector3(randomTorque, randomTorque, randomTorque), ForceMode.Impulse);
        Debug.Log("—брос кубика на:");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public int speed = 100;
    public GameObject cam;
    public float leftPos, rightPos, upPos, downPos;
    public static bool camScroll = true, camMove = true;
    public float minCam, maxCam;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        float z = Input.GetAxis("Mouse ScrollWheel");
        if(z != 0 && camScroll)
        {
            cam.transform.Translate(new Vector3(0, 0, z * speed / 10));
            cam.transform.localPosition = new Vector3(cam.transform.localPosition.x, Mathf.Clamp(cam.transform.localPosition.y, minCam, maxCam), cam.transform.localPosition.z);

        }
        


        if (camMove)
        {
            if ((transform.position.z <= leftPos) && ((int)Input.mousePosition.x < 2))
                transform.position += transform.forward * Time.deltaTime * speed;
            if ((transform.position.z >= rightPos) && ((int)Input.mousePosition.x > Screen.width - 2))
                transform.position -= transform.forward * Time.deltaTime * speed;
            if ((transform.position.x <= upPos) && Input.mousePosition.y > Screen.height - 2)
                transform.position += transform.right * Time.deltaTime * speed;
            if ((transform.position.x >= downPos) && Input.mousePosition.y < 2)
                transform.position -= transform.right * Time.deltaTime * speed;
        }
        
    }
}

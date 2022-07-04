    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public GameObject movingComponent;
    public float rotMult = 4f;
    public Transform localTrans;
    float yaw = 0f;
    float pitch = 0f;
    public float minYrot = -70f;
    public float maxYrot = 70f;
    public float maxY = -65;
    public float minY = 50;


    
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    
    void Update()
    {

        
        yaw += rotMult * Input.GetAxis("Mouse X");
        pitch += rotMult * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -15f, 19f);
        yaw = Mathf.Clamp(yaw, -220f, -140f);
        transform.eulerAngles = new Vector3(-pitch, yaw, 0f);
        
    }

    


}




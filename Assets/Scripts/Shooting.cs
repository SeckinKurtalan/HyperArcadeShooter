    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject movingObject;
    public int hitCounter=0;
    bool hitControl = false;
    public float range = 1000f;
    public Camera fpsCam;
    RaycastHit hit;
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            Debug.Log(hitControl);
            MoveCharacter();
        }   
    }

    void Shoot()
    {
        
        hitControl = false;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
           if(hit.transform.name == "Enemy1" || hit.transform.name == "Enemy2" || hit.transform.name == "Enemy3")
            {
                hitControl = true;
                GameObject.Find(hit.transform.name).SetActive(false);
            }
        }
    }

    void MoveCharacter()
    {
        if(hitControl)
        {
            Debug.LogError($"{movingObject.name} {movingObject.transform.position}");
            movingObject.transform.position = new Vector3(movingObject.transform.position.x, movingObject.transform.position.y, movingObject.transform.position.z + 20f);
        }
    }

}

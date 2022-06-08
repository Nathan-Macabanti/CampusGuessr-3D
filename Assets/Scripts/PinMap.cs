using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinMap : MonoBehaviour
{
    public GameObject pin;
    public static bool PinIsSpawned = false;
    // Update is called once per frame

    void Update()
    {
        if(MoveCamera.mapIsOpen == true)
        {
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                PinIsSpawned = true;
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray))
                {
                    Debug.Log(ray.origin);
                    pin.transform.position =new Vector3(ray.origin.x,ray.origin.y,0.3006f);
                }
                }
            }
        }
        
        
        
    }
}

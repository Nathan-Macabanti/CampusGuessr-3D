using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Touch touch;
    private Quaternion rotationY;
    private float rotationSpeedModifier = 0.1f;
    public static bool mapIsOpen = false;

    // Update is called once per frame
    void Update()
    {
        if(mapIsOpen == false)
        {
            if(Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
            }

            if(touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(0.0f, touch.deltaPosition.x * rotationSpeedModifier, 0.0f);
                transform.rotation = rotationY * transform.rotation;
            }
        }
    }
        
}

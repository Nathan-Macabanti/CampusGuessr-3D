using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Touch touch;
    private Quaternion rotationY;
    private float rotationSpeedModifier = 0.1f;
    public static bool mapIsOpen = false;
    public static Vector3 newDPos;
    private void Start() 
    {
        
        Destination[] newDestination = Resources.LoadAll<Destination>("Destinations");
        Destination newD = newDestination[Random.Range(0,newDestination.Length)];
        this.GetComponent<Renderer>().material.mainTexture = newD.image;
        Shader flip = Shader.Find("Flip Normals");
        this.GetComponent<Renderer>().material.shader = flip;
        newDPos = newD.position;

        

    }
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

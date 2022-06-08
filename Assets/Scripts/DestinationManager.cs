using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationManager : MonoBehaviour
{
    public static bool PinIsOnDestination;
    //Upon collision with another GameObject, this GameObject will reverse direction
   private void OnTriggerStay(Collider other) 
   {
       if(other.gameObject.tag == "Pin Object")
       {
           PinIsOnDestination = true;
       }
       else
       {
            PinIsOnDestination = false;

       }
   }

    void Update() 
    {
        transform.position = OnSubmit.newDPos;
    }
}

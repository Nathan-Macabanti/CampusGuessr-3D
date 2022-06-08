using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSubmit : MonoBehaviour
{
    public MeshRenderer destination;
    public GameObject Submit;
    public GameObject Next;
    public GameObject Sphere;
    public static Vector3 newDPos;

    
    
    
    //Texture2D newImage;
    Texture2D[] newImages;
    Destination[] newDestination;

    void Start() 
    {
        newImages = Resources.LoadAll<Texture2D>("Images");
        newDestination = Resources.LoadAll<Destination>("Destinations");
    }

    
    public void submitButton()
    { 
        destination.enabled = true;
        Submit.SetActive(false);
        Next.SetActive(true);
    }

    public void nextImage()
    {
        Next.SetActive(false);
        Submit.SetActive(true);
        destination.enabled = false;
        Texture2D newImage = newImages[Random.Range(0,newImages.Length)];
        Destination newD = newDestination[Random.Range(0,newDestination.Length)];
        Sphere.GetComponent<Renderer>().material.mainTexture = newD.image;
        newDPos = newD.position;
        
    }
}

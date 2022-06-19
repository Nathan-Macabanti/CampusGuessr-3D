using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class OnSubmit : MonoBehaviour
{
    public MeshRenderer destination;
    public GameObject Submit;
    public GameObject Next;
    public GameObject Sphere;
    public static Vector3 newDPos;
    public TextMeshProUGUI score;
    public static float newScore;
    int curr_map; 
    

    //Texture2D newImage;
    Texture2D[] newImages;
    Destination[] newDestination;
    Destination newD;

    void Start() 
    {
        destination.enabled = false;
        newDestination = Resources.LoadAll<Destination>("Destinations");
        newD = newDestination[Random.Range(0,newDestination.Length)];
        newDPos = newD.position;

    }

    
    public void submitButton()
    { 
        destination.enabled = true;
        Submit.SetActive(false);
        Next.SetActive(true);
        newScore = newScore + CalculatePoints.totalPoints;
        score.text = "" + newScore;
    }

    public void nextImage()
    {
        Next.SetActive(false);
        Submit.SetActive(true);
        destination.enabled = false;
        newD = newDestination[Random.Range(0,newDestination.Length)];
        Sphere.GetComponent<Renderer>().material.mainTexture = newD.image;
        newDPos = newD.position;
        curr_map++;
        

        if(curr_map == UIMainMenuScreen.numberOfMaps)
        {
            SceneManager.LoadScene("EndScreen", LoadSceneMode.Single);
        }
        
        
    }
}

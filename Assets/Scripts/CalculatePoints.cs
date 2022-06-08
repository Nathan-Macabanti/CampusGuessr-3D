//This script calculates the distance between where the player places the pin and where the destination
//This also prints out test numbers which can be removed later on 
//this script also provides calculations for the amount of points the player gets

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CalculatePoints : MonoBehaviour
{

    public Camera cam;
    public Transform pin;
    public Transform destination;
    //public Text points;
    float totalPoints; //Total points earned
    public TextMeshProUGUI score;
    
    
    // Update is called once per frame
    void Update()
    {
        
        
        float PointPerPixel = 2.5f; //Deduct points per pixel away from destination 
        int mapValue = 500; //Value of the map destination (can be changed depending on the map/image to enhance difficulty)
        int mapStreak = 1; //Streak if player hasn't guessed wrong
        
        
        //Get position of pin location on the screen
        Vector2 screenPos = cam.WorldToScreenPoint(pin.transform.position);
        var difference = cam.WorldToScreenPoint(pin.transform.position) - cam.WorldToScreenPoint(destination.transform.position);
        //Calculate total points. Deducting the distance of the pin and the destination to the value of the map.
        //For every [PointPerPixel] in difference from pin to destination, it will deduct 1 point
        //Ex. For every 2.5 pixels of difference it will deduct 1 point on the totalPoints scored for the player
        totalPoints = (mapValue - (Mathf.Abs(difference.x) / PointPerPixel + Mathf.Abs(difference.y) / PointPerPixel)) * mapStreak;
        //Displays distance of x and y  
        

        if(totalPoints < 0)
            totalPoints = 0;

        //Checks if pin is on the exact placement of destination. If it is, it gives the exact mapValue
        
        
        //Displays points
        if(PinMap.PinIsSpawned == false)
        {
            score.text = "0";
        }
        else if(PinDetection.PinIsOnDestination == true)
        {
            score.text = "" + mapValue;
        }
        else
        {
            score.text = "" + Mathf.RoundToInt(totalPoints);
        }
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Destination", menuName = "Destination")]
public class Destination : ScriptableObject
{
    public string destinationName;
    public Vector3 position;
    public Texture2D image;
}

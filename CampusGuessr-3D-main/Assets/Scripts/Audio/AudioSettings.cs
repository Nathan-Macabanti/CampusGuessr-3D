using UnityEngine;

[CreateAssetMenu(menuName = "Audio/Audio Settings")]
public class AudioSettings : ScriptableObject
{
    [Range(0, 1)]
    public float Volume;
}

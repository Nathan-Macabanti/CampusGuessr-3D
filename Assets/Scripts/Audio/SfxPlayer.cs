using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SfxPlayer : MonoBehaviour
{
    [SerializeField] private AudioSettings GlobalAudioSettings;

    [SerializeField] private SfxEvent OnPlaySfx;
    
    private AudioSource audioSource;
    
    public void OnEnable()
    {
        audioSource = GetComponent<AudioSource>();
        OnPlaySfx.Attach(Play);
    }

    public void OnDisable()
    {
        OnPlaySfx.Detach(Play);
    }

    private void Play(SfxData sfxData)
    {
        audioSource.volume = GlobalAudioSettings.Volume;
        audioSource.PlayOneShot(sfxData.SfxClip);
    }
    
    
}

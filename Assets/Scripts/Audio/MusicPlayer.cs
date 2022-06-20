using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private AudioSettings GlobalAudioSettings;

    [SerializeField] private TriggerEvent OnPlayMusic;
    [SerializeField] private TriggerEvent OnPauseMusic;
    [SerializeField] private TriggerEvent OnStopMusic;

    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        UpdateVolume();
        
        if (OnPlayMusic)
            OnPlayMusic.Attach(Play);
        if (OnPauseMusic)
            OnPauseMusic.Attach(Pause);
        if (OnStopMusic)
            OnStopMusic.Attach(Stop);
    }

    private void OnDisable()
    {
        if (OnPlayMusic)
            OnPlayMusic.Detach(Play);
        if (OnPauseMusic)
            OnPauseMusic.Detach(Pause);
        if (OnStopMusic)
            OnStopMusic.Detach(Stop);
    }

    private void UpdateVolume()
    {
        audioSource.volume = GlobalAudioSettings.Volume;
    }

    private void Play()
    {
        audioSource.Play();
    }

    private void Pause()
    {
        audioSource.Pause();
    }

    private void Stop()
    {
        audioSource.Stop();
    }
}

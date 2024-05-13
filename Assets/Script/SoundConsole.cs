using SteamAudio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundConsole : MonoBehaviour
{
    public AudioSource LeftAudioEstudio;
    public AudioSource RightAudioEstudio;
    public AudioClip clip;

    public SteamAudioSource steamAudio;
    void Start()
    {
        LeftAudioEstudio.PlayOneShot(clip);
        RightAudioEstudio.PlayOneShot(clip);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            steamAudio.occlusionValue = 0f;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            steamAudio.occlusionValue = 1f;
        }
    }
}

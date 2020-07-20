using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sound_Menu : MonoBehaviour
{

    public AudioMixer mixer;

    public void SetLevel(float sliderValue)
    {
        Debug.Log(sliderValue);
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }
}
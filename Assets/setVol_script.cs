using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setVol_script : MonoBehaviour
{

    public AudioMixer mixer;

    public void SetLevel (float sliderVal)
    {
        mixer.SetFloat("MasterVolParam", Mathf.Log10(sliderVal) * 20);
    }
}

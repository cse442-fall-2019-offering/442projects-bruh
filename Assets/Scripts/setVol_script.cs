using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

/// <summary>
/// Volume slider vlaues controlled here
/// </summary>

public class setVol_script : MonoBehaviour
{

    public AudioMixer mixer;

    // master levels value set here
    public void SetMasterLevel (float sliderVal)
    {
        mixer.SetFloat("MasterVolParam", Mathf.Log10(sliderVal) * 20);
    }

    // music levels value set here
    public void SetMusicLevel(float sliderVal)
    {
        mixer.SetFloat("MusicVolParam", Mathf.Log10(sliderVal) * 20);
    }

    // sound effects levels value set here
    public void SetSFXLevel(float sliderVal)
    {
        mixer.SetFloat("sfxVolParam", Mathf.Log10(sliderVal) * 20);
    }

}

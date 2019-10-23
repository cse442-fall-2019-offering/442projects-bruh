<<<<<<< HEAD:Assets/setVol_script.cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setVol_script : MonoBehaviour
{

    public AudioMixer mixer;

    public void SetMasterLevel (float sliderVal)
    {
        mixer.SetFloat("MasterVolParam", Mathf.Log10(sliderVal) * 20);
    }

    public void SetMusicLevel(float sliderVal)
    {
        mixer.SetFloat("MusicVolParam", Mathf.Log10(sliderVal) * 20);
    }

    public void SetSFXLevel(float sliderVal)
    {
        mixer.SetFloat("sfxVolParam", Mathf.Log10(sliderVal) * 20);
    }

}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setVol_script : MonoBehaviour
{

    public AudioMixer mixer;

    public void SetMasterLevel (float sliderVal)
    {
        mixer.SetFloat("MasterVolParam", Mathf.Log10(sliderVal) * 20);
    }

    public void SetMusicLevel(float sliderVal)
    {
        mixer.SetFloat("MusicVolParam", Mathf.Log10(sliderVal) * 20);
    }

    public void SetSFXLevel(float sliderVal)
    {
        mixer.SetFloat("sfxVolParam", Mathf.Log10(sliderVal) * 20);
    }

}
>>>>>>> dev:Assets/Scripts/setVol_script.cs

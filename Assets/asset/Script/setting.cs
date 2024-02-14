using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class setting : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    public Dropdown drop;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volume", 0.75f);
    }

    public void SetLevel()
    {
        float sliderValue = slider.value;
        mixer.SetFloat("volume", sliderValue);
    }
    public void SetQuality ()
    {
        int index = drop.value;
        QualitySettings.SetQualityLevel(index);
    }
}


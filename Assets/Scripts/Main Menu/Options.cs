using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//https://youtu.be/yWCHaTwVblk?si=EJu5BXZyyK783sP4

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] Slider Volume_Slider;


    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Music"))
        {
            PlayerPrefs.SetFloat("Music", 1);
            LoadVolume();
        }

        else
        {
            LoadVolume();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = Volume_Slider.value;
        SaveVolume();
    }

    private void LoadVolume()
    {
        Volume_Slider.value = PlayerPrefs.GetFloat("Music");
    }

    private void SaveVolume()
    {
        PlayerPrefs.SetFloat("Music", Volume_Slider.value);
    }

    public void IsFullscreen(bool SetFullScreen)
    {

        Screen.fullScreen = SetFullScreen;


        Debug.Log("Full Screen is set");
    }
}

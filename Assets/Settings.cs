using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Settings : MonoBehaviour
{
    
    bool isFullScreen;
    public void FullScreenToggle()
    {
       
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }


    public MasterVolume am;

    public void AudioVolume(float sliderValue)
    {
    Am.setFloat("masterVolume", sliderValue); 
    }
   
}

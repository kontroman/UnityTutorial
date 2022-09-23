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
}

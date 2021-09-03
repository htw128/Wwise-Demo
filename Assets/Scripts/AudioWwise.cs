using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWwise : MonoBehaviour
{
    private static int soundCount = 0;
    private static GameObject AudioManager = new GameObject("AudioManager");
    public static void PlayOnce (string eventName)
    {
        string soundName = "WwiseSource" + soundCount;
        soundCount++;

        GameObject WwiseSound = new GameObject(soundName);
        WwiseSound.transform.parent = AudioManager.transform;
        
        AkSoundEngine.PostEvent(eventName, WwiseSound);
        
        Destroy(WwiseSound);
    }
}

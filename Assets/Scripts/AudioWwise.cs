using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioWwise : MonoBehaviour
{
    protected static int soundCount = 0;
    public static void PlayOnce (string eventName)
    {
        string soundName = "WwiseSource" + soundCount;
        soundCount++;
        GameObject WwiseSound = new GameObject(soundName);
        AkSoundEngine.PostEvent(eventName, WwiseSound);
        Destroy(WwiseSound);
    }
}

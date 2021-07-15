using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRTPC : MonoBehaviour
{
    public AK.Wwise.RTPC musicVolume;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RTPCname = musicVolume.getName();
        AkSoundEngine.SetRTPC("RTPCname", gameObject.GetComponet<Slider.cs>().value);
    }
}

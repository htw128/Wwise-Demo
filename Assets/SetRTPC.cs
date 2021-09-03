using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRTPC : MonoBehaviour
{
    public AK.Wwise.RTPC RTPCName;
    public Slider Slider;

    public void SetVolume()
    {
        float sliderValue = Slider.value;

        RTPCName.SetGlobalValue(sliderValue);
    }
}

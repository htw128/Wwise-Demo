using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostOnClick : MonoBehaviour
{
    //public AK.Wwise.Event EventName;
    //public AK.Wwise.RTPC MyRTPC;
    //public AK.Wwise.State MyState;
    //public AK.Wwise.Switch MySwtich;
    //public AK.Wwise.Trigger MyTrigger;
    //public AK.Wwise.Bank MyBank;
    //public AK.Wwise.AuxBus myAuxBus;
    //public AK.Wwise.AcousticTexture myAcousticTexture;
    //public AK.Wwise.BaseGroupType baseGroupType;
    //public AK.Wwise.BaseType baseType;
    //public AK.Wwise.CallbackFlags callbackFlags;
    //public float valueOfRTPC;
    void Start()
    {
        Button btn = this.GetComponent<Button> ();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        //EventName.Post(gameObject);
        AkSoundEngine.PostEvent("Play1", gameObject);
    }
    void Update()
    {
        //AkSoundEngine.SetRTPC("Volume", valueOfRTPC);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostOnClick : MonoBehaviour
{
    void Start()
    {
        Button btn = this.GetComponent<Button> ();
        btn.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        //EventName.Post(gameObject);
        //AkSoundEngine.PostEvent("Play1", gameObject);
        AudioWwise.PlayOnce(SoundNameConstents.General_click);
    }
    void Update()
    {
        //AkSoundEngine.SetRTPC("Volume", valueOfRTPC);
    }
}

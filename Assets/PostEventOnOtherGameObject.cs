using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PostEventOnOtherGameObject : MonoBehaviour
{
     public AK.Wwise.Event MyEvent;
     public GameObject otherGameObject;
     private void OnTriggerEnter(Collider other)
     {
          MyEvent.Post(otherGameObject);
     }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carteles_TriggerAnimatorContoller : MonoBehaviour
{
    public Animator _cartel_Controller;

    private void OnTriggerEnter(Collider other)
    {
        _cartel_Controller.SetBool("PopUp", true);
    }
}

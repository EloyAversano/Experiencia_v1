using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTriggerAnimatorContoller : MonoBehaviour
{
    public Animator _arbolAnimatorControler;

    private void OnTriggerEnter(Collider other)
    {
        _arbolAnimatorControler.SetBool("PopUp_arbol", true);
    }
}

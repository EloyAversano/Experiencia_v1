using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon_TriggerAnimatorContoller : MonoBehaviour
{
    public Animator _dragon_treeController;

    private void OnTriggerEnter(Collider other)
    {
        _dragon_treeController.SetBool("PopUp_arbol", true);
    }
}

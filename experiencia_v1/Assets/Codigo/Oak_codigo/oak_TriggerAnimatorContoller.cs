using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oak_TriggerAnimatorContoller : MonoBehaviour
{
    public Animator _oak_treeController;

    private void OnTriggerEnter(Collider other)
    {
        _oak_treeController.SetBool("PopUp_arbol", true);
    }
}

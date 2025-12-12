using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree1_TriggerAnimatorContoller : MonoBehaviour
{
    public Animator _tree1_treeController;

    private void OnTriggerEnter(Collider other)
    {
        _tree1_treeController.SetBool("PopUp_arbol", true);
    }
}

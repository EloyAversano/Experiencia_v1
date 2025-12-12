using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oak_arbolAnimatorController : MonoBehaviour
{
    private Animator _oak_treeController;

    private void Start()
    {
        _oak_treeController = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _oak_treeController.SetBool("PopUp_arbol", true);
    }

    public void ArbolPopUp()
    {
        _oak_treeController.SetBool("PopUp_arbol", true);
    }
}

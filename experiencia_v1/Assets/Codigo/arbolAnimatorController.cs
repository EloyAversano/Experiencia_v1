using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbolAnimatorController : MonoBehaviour
{
    private Animator _arbolAnimatorController;

    private void Start()
    {
        _arbolAnimatorController = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _arbolAnimatorController.SetBool("PopUp_arbol", true);
    }

    public void ArbolPopUp()
    {
        _arbolAnimatorController.SetBool("PopUp_arbol", true);
    }
}

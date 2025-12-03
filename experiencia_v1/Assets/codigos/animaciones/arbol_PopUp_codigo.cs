using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arbol_PopUp_codigo : MonoBehaviour
{
    private Animator _arbolAnimatorControler;

    private void Start()
    {
        _arbolAnimatorControler = GetComponent <Animator>();
    }

    private void ArbolPopUp()
    { 
        _arbolAnimatorControler.SetBool("PopUp_arbol", true);
    }
}

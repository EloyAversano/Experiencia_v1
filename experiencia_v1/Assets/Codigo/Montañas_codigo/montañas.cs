using UnityEngine;

public class montañas : MonoBehaviour
{
    public Animator _animatorMontañas;
    public Animator _animatorTotem;
    public GameObject textoInteraccion;

    private bool jugadorEnTrigger = false;
    private bool activado = false;

    void Start()
    {
        textoInteraccion.SetActive(false);
    }

    void Update()
    {
        if (jugadorEnTrigger && Input.GetKeyDown(KeyCode.E))
        {
            _animatorMontañas.SetBool("PopUp_Bool", true);
            _animatorTotem.SetBool("PopDown_Bool", true);
            textoInteraccion.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            jugadorEnTrigger = true;
            if (!activado)
                textoInteraccion.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorEnTrigger = false;
            textoInteraccion.SetActive(false);
        }
    }
}

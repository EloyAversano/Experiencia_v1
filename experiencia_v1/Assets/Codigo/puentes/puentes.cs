using UnityEngine;

public class puentes : MonoBehaviour
{
    public Animator _animatorPuente;   // Animator del puente
    public Animator _animatorIslas;
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
            _animatorPuente.SetBool("PopUp_Bool", true);
            _animatorIslas.SetBool("PopUp_Bool", true);
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

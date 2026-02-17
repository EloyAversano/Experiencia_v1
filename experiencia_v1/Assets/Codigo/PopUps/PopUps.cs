using UnityEngine;

public class PopUps : MonoBehaviour
{
    public GameObject textoInteraccion;

    private bool activado = false;

    private bool jugadorEnTrigger = false;


    void Start()
    {
        textoInteraccion.SetActive(false);
    }

    void Update()
    {
        if (jugadorEnTrigger && Input.GetKeyDown(KeyCode.E))
        {
            
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

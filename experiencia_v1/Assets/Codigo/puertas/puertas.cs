using UnityEngine;

public class puertas : MonoBehaviour
{
    public Animator _animatorPuertas;  
    public GameObject textoInteraccion;

    private bool jugadorEnTrigger = false;
    private bool activado = false;
    private bool playerNearby;

    private AudioSource audioSource;

    void Start()
    {
        textoInteraccion.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

        if (jugadorEnTrigger && Input.GetKeyDown(KeyCode.E))
        {
            _animatorPuertas.SetBool("OpenBool", true);
            textoInteraccion.SetActive(false);
            audioSource.PlayOneShot(audioSource.clip);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = true;

        Debug.Log("Algo entró al panel: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER DETECTADO");
            playerNearby = true;
        }

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

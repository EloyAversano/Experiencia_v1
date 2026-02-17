using UnityEngine;

public class EnvironmentPanel : MonoBehaviour
{
    public EnvironmentManager environmentManager;
    public float interactDistance = 2f;
    public LayerMask buttonLayer;

    public GameObject textoInteraccion;


    private Camera playerCamera;
    private bool playerNearby;

    private AudioSource audioSource;



    void Start()
    {
        playerCamera = Camera.main;
        audioSource = GetComponent<AudioSource>();
        textoInteraccion.SetActive(false);

    }

    void Update()
    {
        if (!playerNearby) return;

        textoInteraccion.SetActive(false);


        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckButtonInteraction();
        }
    }

    void CheckButtonInteraction()
    {
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactDistance, buttonLayer))
        {
            EnvironmentPanelButton button = hit.collider.GetComponent<EnvironmentPanelButton>();
            if (button != null)
            {
                environmentManager.ApplyEnvironment(button.environmentIndex);
                audioSource.PlayOneShot(audioSource.clip);
            }
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
            textoInteraccion.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = false;
        textoInteraccion.SetActive(false);

    }

}

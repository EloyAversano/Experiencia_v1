using UnityEngine;
using UnityEngine.SceneManagement;

public class aNivel3 : MonoBehaviour
{
    public string sceneName = "seccion_3";
    public GameObject textoInteraccion;

    private bool playerInside = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = true;
            textoInteraccion.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInside = false;
            textoInteraccion.SetActive(false);
        }
    }

    private void Update()
    {
        if (playerInside && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}

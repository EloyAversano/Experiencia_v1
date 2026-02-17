using UnityEngine;
using UnityEngine.SceneManagement;

public class aNivel2 : MonoBehaviour
{
    public string sceneName = "seccion_2_abismo";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
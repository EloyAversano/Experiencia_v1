using UnityEngine;

public class MusicPanelController : MonoBehaviour
{
    public MusicManager musicManager;
    public float interactDistance = 3f;

    private Camera playerCamera;
    private bool playerNearby;

    private AudioSource audioSource;

    void Start()
    {
        playerCamera = Camera.main;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (!playerNearby) return;

        if (Input.GetKeyDown(KeyCode.E))
            CheckMusicButton();
    }

    void CheckMusicButton()
    {
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactDistance))
        {
            MusicButton button = hit.collider.GetComponent<MusicButton>();

            if (button != null)
            {
                musicManager.PlayTrack(button.trackIndex);
                audioSource.PlayOneShot(audioSource.clip);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = false;
    }
}

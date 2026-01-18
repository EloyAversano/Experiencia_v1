using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public static RespawnManager instance;

    public Transform currentCheckpoint;
    public GameObject player;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void SetCheckpoint(Transform newCheckpoint)
    {
        currentCheckpoint = newCheckpoint;
    }

    public void Respawn()
    {
        if (currentCheckpoint != null)
        {
            player.transform.position = currentCheckpoint.position;
        }
    }
}
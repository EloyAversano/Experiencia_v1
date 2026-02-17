using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip[] tracks;

    public void PlayTrack(int index)
    {
        if (index < 0 || index >= tracks.Length) return;

        if (musicSource.clip == tracks[index]) return;

        musicSource.clip = tracks[index];
        musicSource.Play();
    }
}

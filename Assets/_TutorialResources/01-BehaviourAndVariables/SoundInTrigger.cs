using UnityEngine;

/// <summary>
/// This component plays an audio clip when a player tagged object enters it's 
/// collider (the collider needs to be trigger type)
/// </summary>
[RequireComponent(typeof(AudioSource))]
public class SoundInTrigger : MonoBehaviour
{
    private AudioSource sound;
    
    // Use this for initialization
    private void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Only react to player GOs
        if (other.tag != "Player") return;
        // Play the audio clip
        sound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        // Only react to player GOs
        if (other.tag != "Player") return;
        // Stop the audio clip
        sound.Pause();
    }
}
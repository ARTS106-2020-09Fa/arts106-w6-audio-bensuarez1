using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioS;

    public void PlayClip(AudioClip clip)
    {
        audioS.PlayOneShot(clip);
    }
}

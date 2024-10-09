using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTrigger1 : MonoBehaviour
{
    public GameObject[] trees; // Drag and drop tree1, tree2, tree3 (three object trees)
    public Transform cameraOffset; // Camera Offset for transmission
    public Vector3 teleportPosition = new Vector3(44.17757f, 4.83053f, -3.58039f); // Teleport position
    public AudioSource audioSource; // Audio source for playing music

    void OnTriggerEnter(Collider other)
    {
        // Detect if the incoming object is a blue stone tagged 'disappearance'
        if (other.CompareTag("disappearance"))
        {
            // Randomly select a tree and make it disappear
            int randomTreeIndex = Random.Range(0, trees.Length);
            trees[randomTreeIndex].SetActive(false); // boom! disappear
        }

        // Detect if the incoming object is a green stone tagged 'transmission'
        if (other.CompareTag("transmission"))
        {
            // Teleport the Camera Offset to the specified position
            cameraOffset.position = teleportPosition;
        }

        // Detect if the incoming object is a red stone tagged 'audible'
        if (other.CompareTag("audible"))
        {
            // Play the audio when red stone touches the target
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTrigger1 : MonoBehaviour
{
    public GameObject[] trees; // Drag and drop tree1, tree2, tree3 (three objecy trees)

    void OnTriggerEnter(Collider other)
    {
        // Detect if the incoming object is a blue stone tagged 'disappearance'
        if (other.CompareTag("disappearance"))
        {
            // Randomly select a tree
            int randomTreeIndex = Random.Range(0, trees.Length);
            trees[randomTreeIndex].SetActive(false); // make it Boo! Gone
        }
    }
}

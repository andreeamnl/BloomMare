using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentDisabler : MonoBehaviour
{
    
    public GameObject parentObject; // Reference to the parent GameObject you want to disappear

    void Start()
    {
        StartCoroutine(DisableParentAfterDelay());
    }

    IEnumerator DisableParentAfterDelay()
    {
        // Wait for 4 seconds
        yield return new WaitForSeconds(4f);

        // Disable the parent GameObject
        parentObject.SetActive(false);
    }
}





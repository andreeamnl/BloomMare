using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartAppLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Start the coroutine to load the next scene after 4 seconds
        StartCoroutine(LoadNextSceneAfterDelay());
    }

    IEnumerator LoadNextSceneAfterDelay()
    {
        // Wait for 4 seconds
        yield return new WaitForSeconds(4);

        // Load the "AlegeClasa" scene
        SceneManager.LoadScene("AlegeClasa");
    }
}

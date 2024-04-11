using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoaderHistory : MonoBehaviour
{
    public void LoadScene(){
        Debug.Log("Attempting to load scene 'History'...");
        SceneManager.LoadScene("History");
    }
}

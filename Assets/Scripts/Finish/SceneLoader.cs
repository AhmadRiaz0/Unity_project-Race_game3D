using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName; 

    public void LoadScene()
    {
        Debug.Log("Chargement de la sc�ne : " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bMoveSceneManager : MonoBehaviour
{
    //public string tampilan;

    public void nextScene (string tampilan) {
        SceneManager.LoadScene(tampilan);
    }
    
    public void prevScene(string tampilan) {
        SceneManager.LoadScene(tampilan);
    }

    
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public void ChangeSceneWithName(string sceneName)
    {
        // loads the scene specified by the button click
        SceneManager.LoadScene(sceneName);
    }
}

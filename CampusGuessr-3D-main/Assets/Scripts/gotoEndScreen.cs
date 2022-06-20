using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoEndScreen : MonoBehaviour
{
    public void MoveScene()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("MainMenuScene", LoadSceneMode.Single);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void GoToSceneFive()
    {
        SceneManager.LoadScene("Scene5");
    }

    public void GoToSceneFour()
    {
        SceneManager.LoadScene("Scene4");
    }

    public void GoToSceneThree()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void GoToSceneTwo()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void GoToSceneOne()
    {
        SceneManager.LoadScene("Scene1");
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sp : MonoBehaviour
{
    int ScreenNumber;
    public void start()
    {
        ScreenNumber = 1;
        SceneManager.LoadScene(ScreenNumber);
    }

    public void returnn()
    {
        ScreenNumber = 0;
        SceneManager.LoadScene(ScreenNumber);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartBtn : MonoBehaviour
{
    public void RestarGame()
    {
        if (!StartGame.isStart) 
        { 
            SceneManager.LoadScene("Main");
            StartGame.isStart = true;
        }
    }
}

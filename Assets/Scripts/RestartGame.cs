using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    GameObject ball;

    public void Restart()
    {
        ball = GameObject.FindGameObjectWithTag("Player");
        Destroy(ball);
        SceneManager.LoadScene(0);
    }
}

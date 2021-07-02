using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
    CircleCollider2D _holeCollider;
    
    Ball _ball;
    public int nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        _holeCollider = GetComponent<CircleCollider2D>();
        _ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_holeCollider.bounds.Contains(_ball.GetComponent<Rigidbody2D>().position))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}

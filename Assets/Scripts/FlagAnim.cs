using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagAnim : MonoBehaviour
{
    CircleCollider2D _flagCollider;
    Animator flagAnimation;
    Ball _ball;

    // Start is called before the first frame update
    void Start()
    {
        flagAnimation = GetComponentInChildren<Animator>();
        _flagCollider = GetComponent<CircleCollider2D>();
        _ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    public void Update()
    {
        if(_flagCollider.bounds.Contains(_ball.GetComponent<Rigidbody2D>().position))
        {
            flagAnimation.SetBool("IsNear", true);
        }
        else
        {
            flagAnimation.SetBool("IsNear", false);
        }
    }
}

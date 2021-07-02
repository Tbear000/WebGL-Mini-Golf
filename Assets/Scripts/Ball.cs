using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector2 _currentPosition;

    public bool IsDragging { get; private set; }
    public int hitMultiplier;

    Vector2 _mousePosition;
    Rigidbody2D _rigidBody;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void OnMouseDown()
    {
        if(_rigidBody.velocity.magnitude < 0.4f)
        {
            _currentPosition = _rigidBody.position;
            IsDragging = true;
        }
    }

    void OnMouseUp()
    {
        if(IsDragging)
        {
            ScoreScript.scoreValue += 1;
            IsDragging = false;
            Vector2 direction = _currentPosition - _mousePosition;
            _rigidBody.AddForce(direction * hitMultiplier);
        }
    }
    void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _mousePosition = new Vector2(mousePosition.x, mousePosition.y);
    }

    private void OnLevelWasLoaded(int level)
    {
        findStartPos();
        _rigidBody.velocity = Vector2.zero;
    }

    void findStartPos()
    {
        transform.position = GameObject.FindWithTag("StartPos").transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragLine : MonoBehaviour
{
    LineRenderer _lineRenderer;
    Ball _ball;

    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        _ball = FindObjectOfType<Ball>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_ball.IsDragging)
        {
            _lineRenderer.enabled = true;
            _lineRenderer.SetPosition(1, _ball.transform.position);
            _lineRenderer.SetPosition(0, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
        else
        {
            _lineRenderer.enabled = false;
        }
    }
}

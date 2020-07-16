using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    //public GameObject Canvas;
    public float Speed_Cam = 5f;
    //private CanvasButtons _c;

    // Start is called before the first frame update
    void Start()
    {
       // _c = Canvas.GetComponent<CanvasButtons>;
    }

    // Update is called once per frame
    void Update()
    {
       //if (Canvas.GetComponent<>)
        transform.Rotate(0, Speed_Cam * Time.deltaTime, 0);
    }
}

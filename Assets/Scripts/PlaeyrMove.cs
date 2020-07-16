using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaeyrMove : MonoBehaviour
{
    public GameObject obj;
    public float MoveSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float h = Input.GetAxis("Horizontal");
        //float xPos = h * speed;
        //obj.transform.position = new Vector3(xPos, 0.35f, 0);

        if (Input.GetKey(KeyCode.UpArrow))
            obj.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            obj.transform.Translate(-Vector3.forward * MoveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            obj.transform.Translate(-Vector3.right * MoveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            obj.transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);

    }
}

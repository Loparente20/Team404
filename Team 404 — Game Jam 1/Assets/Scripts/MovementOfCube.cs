using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementOfCube : MonoBehaviour
{

    public float speed = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, 0, 30 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, 0, -30 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(0, -70 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(0, 70 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * speed * Time.deltaTime * .5f;
        }
    }
}

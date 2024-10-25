using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube: MonoBehaviour
{
    public bool movecuberight = true;
    public float speed = 3.0f;

    void Update()
    {
        if (movecuberight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (transform.position.x >= 10.0f)
            {
                movecuberight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (transform.position.x <= 0.0f)
            {
                movecuberight = true;
            }
        }
    }
}

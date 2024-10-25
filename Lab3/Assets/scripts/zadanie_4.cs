using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Pomaga³em sobie w tym zadaniu 3 odcinkiem Kursu Unity z Kana³u YouTube "Kana³ o Wszystkim"

public class MoveBall : MonoBehaviour
{
    public float speed = 50f;

    private Rigidbody rb;
    private bool isRigidbody;
    void Start()
    {
        transform.position = new Vector3(0, 0.75f, 0);
        isRigidbody = TryGetComponent<Rigidbody>(out rb);
    }

    void Update()
    {
        float Hdirection;
        float Vdirection;

        if (isRigidbody && (Hdirection = Input.GetAxis("Horizontal")) != 0)
        {
            rb.AddTorque(0, 0, -Hdirection * Time.deltaTime * speed);
        }

        if (isRigidbody && (Vdirection = Input.GetAxis("Vertical")) != 0)
        {
            rb.AddTorque(Vdirection * Time.deltaTime * speed, 0, 0);
        }

    }

}

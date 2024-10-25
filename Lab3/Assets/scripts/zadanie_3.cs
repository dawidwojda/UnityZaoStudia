using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// jako element, kt�ry wskazuje na kierunek ruchu cube doda�em drugiego cube'a o wymiarach Vector3(0.00999999885,0.200000003,0.899999976),
// znajduje si� on nad g��wnym cube'em i ma na�o�ony materia� czerwonej strza�ki, obracaj�� si� razem z nim wskazuje
// kierunek.

public class MoveCubeRotate : MonoBehaviour
{
    private Vector3 direction = Vector3.right;
    private int lap = 0;
    private float distance = 4.5f;

    void Start()
    {
        transform.position = new Vector3(-distance, transform.position.y, distance);
    }

    void Update()
    {
        transform.Translate(direction * 15.0f * Time.deltaTime);

        if ((lap == 0 && transform.position.x >= distance) ||
            (lap == 1 && transform.position.z <= -distance) ||
            (lap == 2 && transform.position.x <= -distance) ||
            (lap == 3 && transform.position.z >= distance))
        {
            transform.Rotate(0, 90, 0);
            lap = (lap + 1) % 4;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie6_lab5 : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Obstacle"))
        {
            Debug.Log("You have touched the Obstacle");
        }
    }
}

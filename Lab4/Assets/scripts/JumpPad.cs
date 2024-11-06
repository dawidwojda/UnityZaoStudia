using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float launchMultiplier = 3.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Zadanie5_Lab_5 playerScript = other.GetComponent<Zadanie5_Lab_5>();
            if (playerScript != null)
            {
                playerScript.LaunchPlayer(launchMultiplier);
            }
        }
    }
}

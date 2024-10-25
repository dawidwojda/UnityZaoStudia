using UnityEngine;

public class Zadanie_6 : MonoBehaviour
{
    public Transform target;
    private float yVelocity = 0.0f;

    void Update()
    {
        float newYPosition = Mathf.SmoothDamp(transform.position.y, target.position.y, ref yVelocity, 0.3f);
        float newXPosition = Mathf.Lerp(transform.position.x, target.position.x, 0.1f * Time.deltaTime);
        float newZPosition = Mathf.Lerp(transform.position.z, target.position.z, 0.1f * Time.deltaTime);
        transform.position = new Vector3(newXPosition, newYPosition, newZPosition);
    }
}

using UnityEngine;

public class Scroll : MonoBehaviour
{
    private float ScrollSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.left * ScrollSpeed * Time.deltaTime);
    }
}

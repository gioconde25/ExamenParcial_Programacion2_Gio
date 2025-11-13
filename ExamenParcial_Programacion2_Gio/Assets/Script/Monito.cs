using UnityEngine;

public class Monito : MonoBehaviour
{
    private Rigidbody monitoRb;

    private void Start()
    {
        monitoRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            monitoRb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}

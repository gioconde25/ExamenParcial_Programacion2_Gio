using UnityEngine;

public class Monito : MonoBehaviour
{
    [SerializeField]
    private Transform groundCheck;

    [SerializeField]
    private float upForce;

    [SerializeField]
    private LayerMask ground;

    [SerializeField]
    private float radius;

    private Rigidbody monitoRb;

    private void Start()
    {
        monitoRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        bool isGrounded = Physics2D.OverlapCircle(groundCheck.position, radius, ground);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            monitoRb.AddForce(Vector3.up * upForce);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, radius);
    }
}

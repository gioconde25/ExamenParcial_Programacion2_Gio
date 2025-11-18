using UnityEngine;

public class Monito : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private CapsuleCollider collider;

    [SerializeField]
    private float jumpForce = 5f;

    [SerializeField]
    private bool isGrounded = true;

    [SerializeField]
    private float normalHeight = 2f;

    [SerializeField]
    private float crouchHeight = 1f;

    [SerializeField]
    private float crouchSpeed = 10f;

    private float targetHeight;

    void Start()
    {
        if (!rb) rb = GetComponent<Rigidbody>();
        if (!collider) collider = GetComponent<CapsuleCollider>();

        targetHeight = normalHeight;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            targetHeight = crouchHeight;
        }
        else
        {
            targetHeight = normalHeight;
        }

        float newHeight = Mathf.Lerp(collider.height, targetHeight, Time.deltaTime * crouchSpeed);

        collider.height = newHeight;
        collider.center = new Vector3(0, newHeight / 2f, 0);

        transform.localScale = new Vector3(1, newHeight / normalHeight, 1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0.5f)
        {
            isGrounded = true;
        }
    }
}
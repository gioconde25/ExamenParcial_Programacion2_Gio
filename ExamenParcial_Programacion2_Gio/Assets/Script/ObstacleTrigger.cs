using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
    private bool counted = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !counted)
        {
            AudioManager.Instance.PlaySFX("Point");
            GameManager.instance.AddScore(1);
            counted = true;
        }
    }
}

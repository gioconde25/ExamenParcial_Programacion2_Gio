using UnityEngine;
using UnityEngine.SceneManagement;

public class ReinicioEscena : MonoBehaviour
{
    private string obstacleTag = "Obstacle";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(obstacleTag))
        {
            AudioManager.Instance.PlaySFX("Death");
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}

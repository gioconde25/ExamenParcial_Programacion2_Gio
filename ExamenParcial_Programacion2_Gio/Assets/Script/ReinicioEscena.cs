using UnityEngine;
using UnityEngine.SceneManagement;

public class ReinicioEscena : MonoBehaviour
{
    private string obstacleTag = "Obstacle";

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(obstacleTag))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
    }
}

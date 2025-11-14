using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;

    [SerializeField]
    private float minTime = 1f;

    [SerializeField]
    private float maxTime = 2f;

    [SerializeField]
    private float[] posY = new float[] { -2f, 0f, 2f };

    private float posX = 30f;

    void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    System.Collections.IEnumerator SpawnObstacles()
    {
        while (true)
        {
            float t = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(t);

            float y = posY[Random.Range(0, posY.Length)];

            Instantiate(obstaclePrefab, new Vector3(posX, y, 0), Quaternion.identity);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(collision.gameObject);
    }
}

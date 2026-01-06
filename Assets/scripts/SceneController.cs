using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class SceneController : MonoBehaviour
{
    [SerializeField] public GameObject enemyPrefab;
    private GameObject enemy;

    private void Update()
    {
        if (enemy == null)
        {
            TryToSpawnEnemy();
        }
    }

    public void TryToSpawnEnemy()
    {
        for (int i = 0; i < 20; i++) 
        {
            Vector3 randomPoint = new Vector3(Random.Range(-24f, 24f), 20f, Random.Range(-17, 17));

            if (Physics.Raycast(randomPoint, Vector3.down, out RaycastHit hit, 50f))
            {
                enemy = Instantiate(enemyPrefab);
                enemy.transform.position = new Vector3(hit.point.x, 1, hit.point.y);
                enemy.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
                return;
            }
        }
    }
}

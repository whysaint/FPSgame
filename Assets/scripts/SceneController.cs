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
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = new Vector3(0, 2, 0f);
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0f);
        }
    }
}

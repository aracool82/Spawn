using System.Collections.Generic;
using UnityEngine;

public class Spawn : ObjectPool
{
    [SerializeField] private float _intervalBitweenSpawn = .5f;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField]  private List<Transform> _poitList = new List<Transform>();
    private float _stepTime = 0f;

    private void Start()
    {
        Init(_enemyPrefab);
    }

    private void Update()
    {
        _stepTime += Time.deltaTime;
        if (_stepTime >= _intervalBitweenSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _stepTime = 0f;
                int numSpawn = Random.Range(0, _poitList.Count);
                SetEnemy(enemy,_poitList[numSpawn].position);
            }
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}

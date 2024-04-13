using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    [SerializeField] private float _timeSpawn = 2f;

    [SerializeField] private Transform _target;

    private void Start()
    {
        StartCoroutine(SpawnEnenmy());
    }

    private IEnumerator SpawnEnenmy()
    {
        WaitForSeconds wait = new WaitForSeconds(_timeSpawn);

        while (true)
        {
            Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);

            enemy.Init(_target);

            yield return wait;
        }
    }
}

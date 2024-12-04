using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    [SerializeField] private float _spawnRate = 2f;
    private float _nextSpanw = 0.0f, _spawnSpeedUp = 0.00f;
    private Vector2 whereToSpawn;

    private void Update()
    {
        if (!GameOver._gameOver)
            Spawn();
    }

    private void Spawn()
    {
        if (Time.time > _nextSpanw)
        {
            _nextSpanw = Time.time + _spawnRate - _spawnSpeedUp;
            whereToSpawn = new Vector2(Random.Range(-9.5f, 8.8f), Random.Range(5.81f, 10f));
            Instantiate(spawnObject, whereToSpawn, Quaternion.identity);
            if (_spawnRate - _spawnSpeedUp > 0.28f)
                _spawnSpeedUp += 0.03f;
        }
    }
}

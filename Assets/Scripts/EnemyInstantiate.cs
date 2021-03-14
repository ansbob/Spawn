using System.Collections;
using UnityEngine;

public class EnemyInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;

    private void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    private IEnumerator CreateEnemies()
    {
        Hole[] holes = GameObject.FindObjectsOfType<Hole>();

        int numberOfSpawns = 10;

        for (int i = 0; i < numberOfSpawns; i++)
        {
            Vector3 point = holes[i % holes.Length].transform.position;

            Instantiate(Enemy, point, Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }
}

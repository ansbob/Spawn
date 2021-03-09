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

        int frames = 1800;
        int framesPerSpawn = 350;

        for (int i = 0; i <= frames; i++)
        {
            if (i % framesPerSpawn == 0)
            {
                Vector3 point = holes[i / framesPerSpawn].transform.position;

                Instantiate(Enemy, point, Quaternion.identity);
            }

            yield return null;
        }
    }
}

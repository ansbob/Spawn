using System.Collections;
using UnityEngine;

public class EnemyInstantiate : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;

    void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    private IEnumerator CreateEnemies()
    {
        Hole[] holes = GameObject.FindObjectsOfType<Hole>();

        int frames = 1800;
        int framesPerInstantiate = 350;

        for (int i = 0; i <= frames; i++)
        {
            if (i % framesPerInstantiate == 0)
            {
                Vector3 point = holes[i / framesPerInstantiate].transform.position;

                Instantiate(Enemy, point, Quaternion.identity);
            }

            yield return null;
        }
    }
}

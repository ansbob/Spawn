using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiate : MonoBehaviour
{
    public GameObject Enemy;

    void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    private IEnumerator CreateEnemies()
    {
        GameObject[] holes = GameObject.FindGameObjectsWithTag("Hole");

        for(int i = 0; i != 1800; i++)
        {
            if (i % 360 == 0)
            {
                Vector3 point = holes[i / 360].transform.position;

                Instantiate(Enemy, point, Quaternion.identity);
            }

            yield return null;
        }
    }
}

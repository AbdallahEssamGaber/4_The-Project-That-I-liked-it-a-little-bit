using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHandler : MonoBehaviour
{

    [Tooltip("Boss-Children")] [SerializeField] GameObject[] childrenEnemies;
    [Tooltip("Normal-Enemies")] [SerializeField] GameObject[] normalEnemies;



    void Update()
    {
        if (normalEnemies[0] == null)
        {
            childrenEnemies[0].SetActive(false);
        }
        if (normalEnemies[1] == null)
        {
            childrenEnemies[1].SetActive(false);
        }
        if (normalEnemies[2] == null)
        {
            childrenEnemies[2].SetActive(false);
        }

    }
}

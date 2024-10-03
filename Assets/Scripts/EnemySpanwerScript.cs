using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpanwerScript : MonoBehaviour
{
    [SerializeField]
    GameObject prefabs;

    [SerializeField]
    int period;

    [SerializeField]
    Vector3 startPosition;

    float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > period)
        {
            GameObject newEnemy = Instantiate(prefabs);
            newEnemy.transform.position = startPosition;
            time = 0;
        }
    }
}

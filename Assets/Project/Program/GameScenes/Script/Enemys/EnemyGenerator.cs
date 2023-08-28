
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public int count = 0;
    float span = 5.0f;
    public float time = 0f;
    public GameObject EnemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > span && count < 4)
        {
            //GameObject enemy = (GameObject)Instantiate(EnemyPrefab, new Vector3(Random.Range(10,30), 5, Random.Range(10,30)), Quaternion.identity);
            //GameObject enemy = (GameObject)Instantiate(EnemyPrefab, new Vector2(Random.Range(10,30), 5, Random.Range(10,30)), Quaternion.identity);

            count++;
            time = 0;
        }

    }
}
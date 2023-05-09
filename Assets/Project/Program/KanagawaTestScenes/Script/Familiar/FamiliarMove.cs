using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamiliarMove : MonoBehaviour
{
    // インスペクター用変数
    public GameObject target;

    // 移動スピード
    public float speed = 1.0f;

    // 移動モード
    private int MoveMode; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //指定したターゲットに向かって移動
         transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);       
    }

    private int MoveModeChoice()
    {
        return 0;
    }

    private void Move()
    {
        switch (MoveMode)
        {
            case 1:
                break;
            case 2:
                break;
           default:
                break;
        }
    }
}

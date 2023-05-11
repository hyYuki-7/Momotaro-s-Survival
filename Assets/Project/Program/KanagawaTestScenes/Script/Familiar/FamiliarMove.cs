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
    private int MoveMode = 2;

    // Enemyタグ検索用変数
    GameObject EnemyTag;

    // Start is called before the first frame update
    void Start()
    {
        EnemyTag = GameObject.FindWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        MoveModeChoice();
    }

    private void MoveModeChoice()
    {
        switch (MoveMode)
        {
            case 1:
                // Momotaro配下のTargetPointに向かって移動
                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                break;
            case 2:
                // 近くのEnemyタグを持つオブジェクトを検索して移動
                Debug.Log(EnemyTag.transform.position.x　+ "です");
                transform.position = Vector2.MoveTowards(transform.position, EnemyTag.transform.position, speed * Time.deltaTime);

                break;
           default:
                break;
        }
    }
}

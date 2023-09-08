using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamiliarMove : Character
{
    // インスペクター用変数
    public GameObject target;

    // 移動スピード
    public float speed = 1.0f;

    // 移動モード
    [SerializeField] private int MoveMode = 1;

    // Playerタグ検索用変数
    GameObject PlayerTag;

    // Enemyタグ検索用変数
    GameObject EnemyTag;

    // Start is called before the first frame update
    void Start()
    {
        PlayerTag = GameObject.FindWithTag("Player");
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
            case 1://MomotaroTarget
                // Momotaro配下のTargetPointに向かって移動
                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

                // プレイヤーから見て近くにEnemyタグを持つ敵がいればゲームモードを2へ変更
                //if(プレイヤーの半径n以内に敵がいるか検索処理);
                break;
            case 2://EnemyTarget
                EnemyTag = GameObject.FindWithTag("Enemy");

                Debug.Log(EnemyTag.transform.position.x + "です");
                Debug.Log("呼ばれてる");

                // 近くのEnemyタグを持つオブジェクトを検索して移動                
                transform.position = Vector2.MoveTowards(transform.position, EnemyTag.transform.position, speed * Time.deltaTime);

                // プレイヤーから見て近くにEnemyタグを持つ敵がいなければゲームモードを1へ変更
                break;
           default:
                break;
        }
    }
}

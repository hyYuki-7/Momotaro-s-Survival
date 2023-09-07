using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public string PlayerTag = "Player"; // プレイヤーオブジェクトのタグ
    public float MoveSpeed = 1.0f; // 敵の移動速度
    public float StopDistance = 2.0f; // プレイヤーの手前で停止する距離
    private Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        // プレイヤーをタグで検索し、プレイヤーのTransformを取得
        Player = GameObject.FindGameObjectWithTag(PlayerTag).transform;
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーへの方向ベクトルを計算
        Vector3 MoveDirection = Player.position - transform.position;

        // プレイヤーとの距離を計算
        float distanceToPlayer = MoveDirection.magnitude;

        // プレイヤーが一定の距離未満に近づいたら停止
        if (distanceToPlayer > StopDistance)
        {
            MoveDirection.Normalize(); // 方向ベクトルを正規化
            transform.Translate(MoveDirection * MoveSpeed * Time.deltaTime);
        }
        else
        {
            // 一定の距離未満でプレイヤーに近づいた場合、移動を停止
            // ここで停止のアクションを追加できます
            Debug.Log("停止中");
        }
    }
}


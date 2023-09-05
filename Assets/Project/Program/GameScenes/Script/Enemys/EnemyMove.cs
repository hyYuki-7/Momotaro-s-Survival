using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public string PlayerTag = "Player"; // プレイヤーオブジェクトのタグ
    public float MoveSpeed = 1.0f; // 敵の移動速度
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
        Vector3 MoveDirection = (Player.position - transform.position).normalized;
        transform.Translate(MoveDirection * MoveSpeed * Time.deltaTime);
    }
}

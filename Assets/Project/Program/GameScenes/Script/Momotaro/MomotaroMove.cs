using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//これでEnemyのpublicがインスペクタに表示される
#if UNITY_EDITOR
[CustomEditor(typeof(Character))]
#endif

public class MomotaroMove : Character
{
    Character Momotaro;

    // アニメーターコンポーネント取得変数
    private Animator MoveAnimetor;

    // 移動変数
    float vx = 0;
    float vy = 0;

    // 移動スピード
    public float speed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        // アニメーションコンポーネントを取得
        MoveAnimetor = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MomotaroWalke();
    }

    void MomotaroWalke()
    {
        // 毎フレーム数値を初期化
        vx = 0;
        vy = 0;

        // 斜め移動時用変数
        float move = 1.0f;

        // 右左キーが入力されているか
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            {
                // 斜め移動を検知
                move = 0.71f;
            }
            else
            {
                // 斜め移動を未検知 
                move = 1.0f;
            }
        }

        // 横移動
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            // 左へ移動
            vx = -speed * move;

            // 左向きのアニメーションを再生
            MoveAnimetor.SetFloat("InputX", -1);
            MoveAnimetor.SetFloat("InputY", 0);
            MoveAnimetor.SetBool("IsMoving", true);

        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            // 右へ移動
            vx = speed * move;

            // 右向きのアニメーションを再生
            MoveAnimetor.SetFloat("InputX", 1);
            MoveAnimetor.SetFloat("InputY", 0);
            MoveAnimetor.SetBool("IsMoving", true);
        }

        // 縦移動
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            // 上へ移動
            vy = speed * move;

            // 上向きのアニメーションを再生
            MoveAnimetor.SetFloat("InputY", 1);
            MoveAnimetor.SetFloat("InputX", 0);
            MoveAnimetor.SetBool("IsMoving", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            // 下へ移動
            vy = -speed * move;

            // 下向きのアニメーションを再生
            MoveAnimetor.SetFloat("InputY", -1);
            MoveAnimetor.SetFloat("InputX", 0);
            MoveAnimetor.SetBool("IsMoving", true);
        }
        else if (!Input.anyKey)
        {
            // 何もキーが押されていない場合、アニメーションを停止
            MoveAnimetor.SetBool("IsMoving", false);
        }

        // 実際の移動処理
        this.transform.Translate(vx * Time.deltaTime, vy * Time.deltaTime, 0);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratePontMove : MonoBehaviour
{

    // 移動モード
    public enum MoveType
    {
        LeftRight,
        UpDown,
    }

    // 移動モード選択用変数
    [SerializeField] MoveType MoveMode = MoveType.LeftRight;

    // 回転用変数
    float vz = 0;

    private bool SwitchingFlag = true;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*         //キーを押した逆方向へ回転
                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                {
                    vz = 90;
                }
                else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    vz = -90;
                }
                if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
                {
                    vz = 0;
                }
                else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
                {
                    vz = 180;
                }

                // 実際の移動処理
                this.transform.rotation = Quaternion.Euler(0, 0, vz); */

        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;
        Debug.Log(pos.x);

        if (pos.x < 18.5 && SwitchingFlag == true)
        {
            pos.x += 0.1f;    // x座標へ0.01加算
            if (pos.x > 18.5)
            {
                SwitchingFlag = false;
            }
        }
        if (pos.x > -18.5 && SwitchingFlag == false)
        {
            pos.x -= 0.1f;    // x座標へ0.01加算
            if (pos.x < -18.5)
            {
                SwitchingFlag = true;
            }
        }
        // else if (pos.x > -18.5 || SwitchingFlag == false)
        // {
        //     pos.x -= 0.1f;    // x座標へ0.01加算
        //     if (pos.x < -18.5)
        //     {
        //         SwitchingFlag = true;
        //     }

        // }

        //pos.y += 0.01f;    // y座標へ0.01加算
        //pos.z += 0.01f;    // z座標へ0.01加算

        myTransform.position = pos;  // 座標を設定

        switch (MoveMode)
        {
            case MoveType.LeftRight:


                Debug.Log("A");
                break;
            case MoveType.UpDown:
                Debug.Log("B");
                break;
            default:
                break;
        }
        // 実際の移動処理
        //this.transform.position = Quaternion.Euler(0, 0, vz);
    }
}
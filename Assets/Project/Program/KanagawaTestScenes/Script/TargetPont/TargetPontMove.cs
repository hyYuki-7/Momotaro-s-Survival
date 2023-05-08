using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPontMove : MonoBehaviour
{
    // 回転用変数
    float vz = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //キーを押した逆方向へ回転
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
        this.transform.rotation = Quaternion.Euler(0, 0, vz);
    }
}
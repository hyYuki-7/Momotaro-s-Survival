using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyGenerator : MonoBehaviour
{
    // プレハブ格納用
    public GameObject EnemyPrefab;

    Camera CamPos;

    private int GeneratPoint;
    private bool GeneratFlag;

    // Start is called before the first frame update
    void Start()
    {
        // フレームレートを60FPSで固定。
        Application.targetFrameRate = 60;

        GeneratFlag = false;

    }

    // Update is called once per frame
    void Update()
    {
        Generator();
    }

    void Generator()
    {
        // 一定時間ごとにプレハブを生成
        if(Time.frameCount % 60 == 0)
        {
            // 生成位置
            Vector2 PosCentar = new Vector2(-20.0f, 10.0f);
            Vector3 PosLeft = new Vector3(-20.0f, 10.0f, 0.0f);
            Vector3 PosRight = new Vector3(-20.0f, 10.0f, 0.0f);
            
            var parent = this.transform;
            // プレハブを指定位置に生成
            Instantiate(EnemyPrefab, PosCentar, Quaternion.identity,parent);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // プレハブ格納用
    public GameObject EnemyPrefab;

    GameObject CamPos;

    int Count;

    // Start is called before the first frame update
    void Start()
    {
        //フレームレートを60で固定している。
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // 一定時間ごとにプレハブを生成
        if(Time.frameCount % 60 == 0)
        {
            // 生成位置
            Vector3 pos = new Vector3(-20.0f, 10.0f, 0.0f);
            var parent = this.transform;
            // プレハブを指定位置に生成
            Instantiate(EnemyPrefab, pos, Quaternion.identity,parent);
        }  
        Debug.Log(Count / 600);
        Count++;
    }
}
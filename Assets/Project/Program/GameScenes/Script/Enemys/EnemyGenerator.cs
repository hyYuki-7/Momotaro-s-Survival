using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // プレハブ格納用
    public GameObject EnemyPrefab;

    // インスペクター用変数
    // Enemy生成場所
    [SerializeField] private GameObject[] targetPont = new GameObject[4];

    // Enemy生成タイミング用
    [SerializeField] private bool GeneratFlag = true;



    // Start is called before the first frame update
    void Start()
    {
        // フレームレートを60FPSで固定。
        Application.targetFrameRate = 60;

    }

    // Update is called once per frame
    void Update()
    {
        Generator();
    }

    // Enemy生成フラグがtrueの時生成
    void Generator()
    {
        //Debug.Log(targetPont[0]);
        // Enemy生成フラグがtrueの時生成
        if (GeneratFlag)
        {
            // 一定時間ごとにプレハブを生成
            if (Time.frameCount % 30 == 0)
            {
                // ランダムな生成位置を取得
                GameObject randomTargetPoint = targetPont[Random.Range(0, targetPont.Length)];
                Vector2 randomPosition = randomTargetPoint.transform.position;

                var parent = this.transform;
                // プレハブをランダムな位置に生成
                Instantiate(EnemyPrefab, randomPosition, Quaternion.identity, parent);
            }
        }
    }

}
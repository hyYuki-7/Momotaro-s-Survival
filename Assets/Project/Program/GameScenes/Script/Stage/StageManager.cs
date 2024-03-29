using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//タイルマップを操作する時に必要
using UnityEngine.Tilemaps;
//シーンの読み込み/再読み込み時に必要
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    //マップチップのyサイズ
    const int StageChipSize = 20;
    int currentChipIndex = 1;
    //マップチップ
    [SerializeField] Tilemap tilemap;
    [SerializeField] Tile grassTile;
    //キャラクター
    public Transform PlayreCharacter;

    //マップの最大数
    int i_max_x;
    int i_max_y;

    //マップの最小数
    int i_min_x;
    int i_min_y;

    void Start()
    {
        //マップの最大値設定
        i_max_x = 9;
        i_max_y = 3;

        //マップの最小値設定
        i_min_x = -5;
        i_min_y = 1;

        //StartCoroutine(SetTile());
    }

    void Update()
    {
        //キャラクターのy座標取得
        int charaPositionIndex = (int)(PlayreCharacter.position.y);
        //現在のチップ位置
        int chipPosition = currentChipIndex * StageChipSize;
        //キャラクターがマップチップを上に通過した場合
        if (charaPositionIndex > chipPosition)
        {
            StartCoroutine(UpdateTile());
            currentChipIndex++;
        }
    }

    public IEnumerator UpdateTile()
    {
        for (int y = i_min_y; y < i_max_y; y++)
        {
            for (int x = i_min_x; x < i_max_x; x++)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), grassTile);
                yield return new WaitForEndOfFrame();
            }
        }
    }

    /// <summary>
    /// スタート時マップ作製処理
    /// </summary>
    /// <returns></returns>
    public IEnumerator SetTile()
    {
        ////マップをクリアする（重複しないようにする）
        tilemap.ClearAllTiles();
        for (int y = i_min_y; y < i_max_y; y++)
        {
            for (int x = i_min_x; x < i_max_x; x++)
            {
                tilemap.SetTile(new Vector3Int(x, y, 0), grassTile);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // スタートボタンクリックイベント
    public void ClickStart()
    {
        // ステージ1に遷移
        SceneManager.LoadScene("GameScene");
    }
/*
    //スコアボタンクリックイベント
    public void ClickCharacterChoice()
    {
        //スコア画面に遷移
        //SceneManager.LoadScene("ScoreScene");
    }
*/
    // 終了ボタンクリックイベント
    public void ClickExit()
    {
        // ゲームプレイ終了
        Application.Quit();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


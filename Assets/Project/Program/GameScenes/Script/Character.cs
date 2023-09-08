using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //レベル
    public int Level=10;
    //体力
    public float Hp;
    //速度
    public float Speed = 1.0f;
    //攻撃力
    public float Attack;
    //フィジカル
    public float Physical;
    //生死
    public bool ExistFlag = true;
    //一時停止用フラグ
    public bool MovediSable = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CharacterPause()
    {
        MovediSable = true;
        return MovediSable;
    }

}

﻿using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour
{
    // static 靜態 隱藏
    // 此類別共用 包含子類別
    [Header("速度"), Range(0, 100.5f)]
    public static float speed = 3f;

    [Header("移動")]
    public Transform tran;

    /// <summary>
    /// 地板移動功能
    /// </summary>
    private void Move()
    {
        // Time.deltaTime 一幀的時間
        tran.Translate(-speed * Time.deltaTime, 0, 0);
    }

    private void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //speed = speed + 2;
        }
    }
}

using UnityEngine;  //引用Unity API

//類別 類別名稱
public class First : MonoBehaviour
{
    // 定義欄位 Field(宣告變數)
    // 語法:
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // 私人 private  - 隱藏(預設)
    // 公開 public   - 顯示
    public int level = 1;         // 整數 預設 0
    public float speed = 10.5f;   // 浮點數 預設 0
    public string prop = "道具";  // 字串 預設 ""
    public bool mission = true;   // 布林值(是/否) 預設 false

    // 屬性
    // 語法:[屬性名稱(屬性內容)]
    // [標題("標題內容")]
    [Header("血量"),Range(0,100)]
    public int HP = 100;
    // [範圍(最小值，最大值)]
    [Header("法力值"), Range(0,99)]
    public int Mp = 50;
    [Header("跳躍高度")]
    public float jump = 2.5f;

    // [提示("提示內容")]
    [Header("死亡")]
    [Tooltip("紀錄玩家是否死亡，打勾：死亡，取消：存活")]
    public bool dead;
}

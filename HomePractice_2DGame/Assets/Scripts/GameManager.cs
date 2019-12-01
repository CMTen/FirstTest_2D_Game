using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int Score;
    [Header("最高分數")]
    public int TopScore;
    [Header("水管")]
    public GameObject pipe; // GameObject 可以存放預製物以及場景上的物件

    /// <summary>
    /// 生成水管功能
    /// </summary>
    public void SpawnPipe()
    {
        // 因為有繼承此類別才可簡寫
        // Object.Instantiate(pipe);

        float y = Random.Range(0.9f, -1.7f);

        // 三維向量 Vector3 - x, y, z
        Vector3 pos = new Vector3(6f, y, 0);
        // 四元數 Quaternion - x, y, z, w
        Quaternion rot = new Quaternion(0, 0, 0, 0);

        Instantiate(pipe, pos, rot);
    }

   /// <summary>
   /// 加分功能
   /// </summary>
   /// <param name="add">分數</param>
    public void AddScore(int add)
    {

    }

    /// <summary>
    /// 設定最高分數
    /// </summary>
    private void SetTopScore()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {

    }

    private void Start()
    {
        //SpawnPipe();

        InvokeRepeating("SpawnPipe", 0, 140f * Time.deltaTime);
    }
}

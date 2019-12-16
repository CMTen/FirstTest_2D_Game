using UnityEngine;
using UnityEngine.UI;  // 引用 介面API
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int Score;
    [Header("最高分數")]
    public int TopScore;
    [Header("水管")]
    public GameObject pipe; // GameObject 可以存放預製物以及場景上的物件
    [Header("介面群組")]
    public GameObject goUI;
    [Header("分數介面")]
    public Text textScore;
    public Text textTop;


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
        Score = Score + add;
        textScore.text = Score + "";
        // textScore.text = Score.ToString();

        SetTopScore();
    }

    /// <summary>
    /// 設定最高分數
    /// </summary>
    private void SetTopScore()
    {
        if (Score > TopScore)
        {
            TopScore = Score;

            PlayerPrefs.SetInt("最高分數", TopScore);
        }
        textTop.text = TopScore.ToString();
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {
        goUI.SetActive(true);
        Ground.speed = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene("遊戲場景");
    }

    public void Exit()
    {
        Application.Quit();
    }

    private void Start()
    {
        //SpawnPipe();

        InvokeRepeating("SpawnPipe", 0, 140f * Time.deltaTime);

        TopScore = PlayerPrefs.GetInt("最高分數");
        textTop.text = TopScore.ToString();

        Ground.speed = 3f;
    }
}

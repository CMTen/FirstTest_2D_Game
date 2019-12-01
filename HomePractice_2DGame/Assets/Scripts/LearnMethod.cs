using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 定義方法 Method (宣告函式、功能)
    // 語法：
    // 修飾詞 方法傳回類型 方法名稱 (參數) { }
    // 參數語法：參數類型 參數名稱
    // void 無傳回
    private void Test()
    {

    }

  
    /// <summary>
    /// 開車
    /// </summary>
    /// <param name="speed">車速</param>
    private void Drive(int speed)
    {
        // 字串可以使用 + 號與其他型態串接，結果為字串
        print("車子正在往前開，時速：" + speed);
    }

    // 多重參數使用，逗號隔開
    // 參數不能重複名稱，可以與欄位相同
    // 參數可以給預設值，選填式參數
    // 選填式參數只能寫在最後面
    private void Shoot(int count, string direction = "前方", string prop = "無")
    {
        print("弓箭數量：" + count + "，弓箭向" + direction + "發射");
        print("弓箭屬性：" + prop);
    }

    //有傳回
    private string Hi(string name)
    {
        return "嗨 " + name + "，歡迎使用本軟體。";
    }

    private void Start()
    {
        // 呼叫方法，給予對應的引數
        Drive(99);
        // 不填寫選填式參數，以預設值執行方法
        Shoot(5);
        Shoot(10, "左右");
        Shoot(3, prop: "火");

        // 區域欄位，不需要修飾詞
        string hi = Hi("王小明");
        print(hi);

        print(Hi("王小明"));
    }
}

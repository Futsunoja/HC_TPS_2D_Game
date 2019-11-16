using UnityEngine;

public class LearIF : MonoBehaviour
{
    public bool test;
    public string prop;

    [Header("剩餘HP"),Range(0,100)]
    public int hp;

    // 更新事件:一秒執行60次
    private void Update()
    {
        #region 練習if
        // 判斷式 if 語法
        // if (布林植){陳述式或演算法}
        // () 裡面的布林植 true 才會執行{}
        if (test)
        {
            print("打開開關");
        }
        // ()裡面的布林值為false才會執行else{}
        else
        {
            print("關閉開關");
        }

        if (prop == "紅色藥水")
        {
            print("補血");
        }
        else if (prop == "藍色藥水")
        {
            print("補魔");
        }
        else if (prop == "黃色藥水")
        {
            print("補體力");
        }
        else
        {
            print("無事發生");
        }
        #endregion

        if (70 <= hp)
        {
            print("安全");
        }
        else if (50 <= hp)
        {
            print("警告");
        }
        else if (20 <= hp)
        {
            print("危險");
        }
        else
        {
            print("快死了");
        }
    }
}

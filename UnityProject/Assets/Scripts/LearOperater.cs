using UnityEngine;

public class LearOperater : MonoBehaviour
{
    public int a = 10, b = 3, c = 10, d = 10;
    public int score = 50;
    public int num1 = 90, num2 = 10;

    public bool boolA = true, boolB = false;
    public int hp = 100;
    public int prop = 10;

    private void Start()
    {
        #region 數學運算子區域
        // 數學運算子
        print(a + b);  //13
        print(a - b);  //7
        print(a * b);  //30
        print(a / b);  //3
        print(a % b);  //1

        // 遞增++  遞減--
        print(c++);  //先輸出，再遞增
        print(++d);  //先遞增，再輸出

        // 指定運算
        // = 指定
        // 適用所有數學運算
        score = score + 10;
        score += 10;
        #endregion

        // 比較運算子 (結果為布林值)
        print(num1 > num2);
        print(num1 < num2);
        print(num1 >= num2);
        print(num1 <= num2);
        print(num1 == num2);  //等於
        print(num1 != num2);  //不等於

        // 邏輯運算子
        // 並且 &&
        print(boolA && boolB);  //只要有一個false，結果為false
        print(boolA && boolA);  //T
        print(boolB && boolA);  //F
        print(boolB && boolB);  //F
        // 或者 ||
        print(boolA || boolB);  //只要有一個true，結果為true
        print(boolA || boolA);  //T
        print(boolB || boolA);  //T
        print(boolB || boolB);  //F

        //  過關條件:HP>50 並且 道具>7
        print(hp > 50 && prop > 7);

        //  相反
        print(!true);  //F
        print(!false);  //T
    }
}

using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"),Range(1,2000)]
    public int jump = 100;
    [Header("旋轉角度"), Range(0, 100)]
    public float angle = 10;
    [Header("是否死亡")]
    public bool dead;
    [Header("小雞跳躍元件")]
    public Transform bird;
    [Header("剛體")]
    public Rigidbody2D r2d;

    private void Start()
    {
        print(bird.rotation);
    }

    /// <summary>
    /// 小雞跳躍方法
    /// </summary>
    private void Jump()
    {
        // 如果 玩家 按下 左鍵
        // 輸入.按下左鍵(按鍵列舉.滑鼠左鍵)(手機觸控)
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("玩家按下左鍵");
            r2d.Sleep();
            r2d.gravityScale = 1; //小雞剛體.重力=1;
            r2d.AddForce(new Vector2(0, jump)); // 小雞剛體.增加推力(二維向量(左右,上下));
            // 小雞 往上跳
        }
        // Rigidbody2D.SetRotation(float) 設定角度(角度)
        // Rigidbody2D.velocity 加速度（二維向量　ｘ,ｙ）
        r2d.SetRotation(10*r2d.velocity.y);
    }

    /// <summary>
    /// 小雞死亡方法
    /// </summary>
    private void Dead()
    {

    }
    // 固定幀數 0.002 一幀：要控制物理請寫在此事件內
    private void Update()
    {
        Jump();
    }
}

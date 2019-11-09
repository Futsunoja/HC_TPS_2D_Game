using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"),Range(1,2000)]
    public int jump = 100;
    [Header("是否死亡")]
    public bool dead;
    [Header("小雞跳躍元件")]
    public Transform bird;

    private void Start()
    {
        print(bird.rotation);
    }

    /// <summary>
    /// 小雞跳躍方法
    /// </summary>
    private void Jump()
    {

    }

    /// <summary>
    /// 小雞死亡方法
    /// </summary>
    private void Dead()
    {

    }
}

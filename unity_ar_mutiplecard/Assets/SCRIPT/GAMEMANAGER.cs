using UnityEngine;

public class GAMEMANAGER : MonoBehaviour
{
    //註解:說明
    //修飾詞 public(公開可以看到) private(反之)
    [Header("兔子")]
    public Transform rabbit;
    [Header("蝙蝠")]
    public Transform bat;
    [Header("虛擬搖桿")]
    public FixedJoystick Joystick;
    [Header("旋轉速度"),Range(0.1f,20f)]
    public float turn = 1.5f;
    [Header("放大縮小"), Range(0,5f)]
    public float bigsmall = 0.1f;
    //事件:(藍色)-初始設定
    private void Start()
    {
        print("開始事件設定");
    }
    private void Update()
    {
        print(Joystick.Vertical);       //float 浮點數   //. 取得裡面功能
        bat.Rotate(0, Joystick.Horizontal*turn, 0);
        bat.localScale += new Vector3(1, 1, 1) * Joystick.Vertical*bigsmall;
        rabbit.Rotate(0, Joystick.Horizontal*turn, 0);
        rabbit.localScale += new Vector3(1, 1, 1) * Joystick.Vertical*bigsmall;
    }
}

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
    [Header("兔子動畫元件")]
    public Animator aniRabbit;
    [Header("蝙蝠動畫元件")]
    public Animator aniBat;

    public float test = 1;
    public float test2 = 1;

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

        bat.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(bat.localScale.x, 0.5f, 40f);
        rabbit.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(bat.localScale.x, 0.5f, 40f);


        test = Mathf.Clamp(test, 0.1f, 10f);
        print(Mathf.Clamp(test2, 0.1f, 10f))
            ;
    }
    //方法   修飾詞 類型  名稱(){}
    public void Attack() 
    {
        print("攻擊");
        aniRabbit.SetTrigger("兔子攻擊");
        aniBat.SetTrigger("攻擊觸發");

    }
    public void DIE()
    {
        print("死亡");
        aniRabbit.SetTrigger("兔子死亡");
        aniBat.SetTrigger("死亡觸發");

    }
    public void MOVE()
    {
        print("移動");
        aniRabbit.SetTrigger("兔子移動");
        aniBat.SetTrigger("移動觸發");

    }
    //public void Attack(參數)
    //參數  類型 名稱
    //public void PlayAnimation(string aniName) 
    //{
    //  aniRabbit.SetTrigger(aniName);
    //  aniBat.SetTrigger(aniName);
    //然後到按鈕的click設定  打各自的攻擊名稱，由於我名稱不一樣不適合
    //} 

}

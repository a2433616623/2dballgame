using System.Collections;
using System.Collections.Generic;
using UnityEngine

//引入常见的库，还有引入unity引擎

public class palyer ： MonoBehavior
{
    public float moveSpeed = 3;  //设置移动速度
    //从这里第一帧开始
    void Start()
    {

    }

    //每一帧都会刷新的函数
    void  Update() {
        float h = Input.GetAxisRaw("Horizontal");    //垂直方向
        transform.Translate(Vector3.right*h*moveSpeed*Time.deltaTime);   //控制时间微分和速度向量
        float v = Intput.GetAxisRaw(Vertical);      //水平方向
        transform.Translate(Vector3.up*v*moveSpeed*Time.deltaTime);
    }
   
}

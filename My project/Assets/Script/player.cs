using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f; // 移动速度
    public Rigidbody2D rb; // 物理组件
    private Vector2 moveInput; // 输入方向

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // 获取 Rigidbody2D
    }

    void Update()
    {
        // 获取 WASD 输入
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D 或 左/右方向键
        float moveY = Input.GetAxisRaw("Vertical");   // W/S 或 上/下方向键
        moveInput = new Vector2(moveX, moveY).normalized; // 归一化，避免对角线加速
    }

    void FixedUpdate()
    {
        // 物理移动
        rb.velocity = moveInput * moveSpeed;
    }
}

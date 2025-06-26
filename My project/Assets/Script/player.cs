using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f; // �ƶ��ٶ�
    public Rigidbody2D rb; // �������
    private Vector2 moveInput; // ���뷽��

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // ��ȡ Rigidbody2D
    }

    void Update()
    {
        // ��ȡ WASD ����
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D �� ��/�ҷ����
        float moveY = Input.GetAxisRaw("Vertical");   // W/S �� ��/�·����
        moveInput = new Vector2(moveX, moveY).normalized; // ��һ��������Խ��߼���
    }

    void FixedUpdate()
    {
        // �����ƶ�
        rb.velocity = moveInput * moveSpeed;
    }
}

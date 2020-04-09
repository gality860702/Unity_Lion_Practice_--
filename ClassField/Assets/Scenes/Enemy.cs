using UnityEngine;



public class Enemy : MonoBehaviour
{
    [Header("Hp"), Tooltip("顯示怪物的血量"), Range(50, 500)]
    public int Hp;

    [Header("Mp"), Tooltip("顯示怪物的魔量與上限"), Range(1, 100)]
    public int Mp = 100;

    [Header("Speed"), Tooltip("顯示怪物的速度值"), Range(1, 50.5f)]
    public float Speed = 10.5f;

    [Header("Attack"), Tooltip("顯示怪物的攻擊力"), Range(20, 200)]
    public int Attack = 50;

    [Header("Defence"), Tooltip("顯示怪物的防禦力"), Range(0, 100)]
    public int Defence;

    [Header("Weapon"), Tooltip("顯示怪物身上的武器")]
    public string Weapon;

    [Header("Equip"), Tooltip("顯示怪物身上的裝備")]
    public string Equip = "皮衣";

    [Header("Key"), Tooltip("顯示怪物身上是否有鑰匙")]
    public bool key;

    [Header("Chest"), Tooltip("顯示怪物身上是否有寶箱")]
    public bool chest;


}

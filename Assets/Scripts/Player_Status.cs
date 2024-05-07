using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Status : MonoBehaviour
{
    [SerializeField] private Slider hpBar;

    private int ATK, DEF, _HP;
    
    public int HP
    {
        get => _HP;
        private set => _HP = Mathf.Clamp(value, 0, _HP);
    }

    private void Awake()
    {
        _HP = 100;
        SetMaxHealth(_HP);
    }
    public void SetMaxHealth(int health)
    {
        hpBar.maxValue = health;
        hpBar.value = health;
    }

    public void GetDamage(int damage)
    {
        int getDamagedHp = HP - damage;
        HP = getDamagedHp;
        hpBar.value = HP;
    }
}

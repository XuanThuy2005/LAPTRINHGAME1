using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;

    public event Action<int> OnHealthChanged;
    public event Action OnDead;

    void Start()
    {
        currentHP = maxHP;
        OnHealthChanged?.Invoke(currentHP);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int dmg)
    {
        currentHP -= dmg;
        if (currentHP < 0) currentHP = 0;

        Debug.Log("HP: " + currentHP);
        OnHealthChanged?.Invoke(currentHP);

        if (currentHP <= 0)
        {
            OnDead?.Invoke();
        }
    }
}

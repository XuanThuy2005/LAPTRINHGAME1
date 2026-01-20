using UnityEngine;
using UnityEngine.Events;

public class MiniPlayerHealth : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;

    public UnityEvent<int> OnHealthChanged;
    public UnityEvent OnDead;

    void Awake()
    {
        currentHP = maxHP;
    }

    void Start()
    {
        // ÉP update UI ngay lúc start
        if (OnHealthChanged != null)
            OnHealthChanged.Invoke(currentHP);
    }

    public void TakeDamage(int dmg)
{
    Debug.Log("TAKE DAMAGE: " + dmg);

    currentHP -= dmg;
    if (currentHP < 0) currentHP = 0;

    Debug.Log("CURRENT HP: " + currentHP);

    if (OnHealthChanged != null)
        OnHealthChanged.Invoke(currentHP);

    if (currentHP <= 0)
    {
        Debug.Log("PLAYER DEAD");

        if (OnDead != null)
            OnDead.Invoke();
    }
}

}

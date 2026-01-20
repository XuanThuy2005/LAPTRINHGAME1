using UnityEngine;
using UnityEngine.Events;

public class PlayerHealthUnityEvent : MonoBehaviour
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
        // Delay 1 frame cho UI bind xong
        Invoke(nameof(InitUI), 0.05f);
    }

    void InitUI()
    {
        OnHealthChanged.Invoke(currentHP);
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
        OnHealthChanged.Invoke(currentHP);

        if (currentHP <= 0)
        {
            OnDead.Invoke();
        }
    }
}

using UnityEngine;

public class MiniTurretDamage : MonoBehaviour
{
    public int damagePerHit = 10;

    void OnTriggerEnter2D(Collider2D other)
    {
        MiniPlayerHealth hp = other.GetComponent<MiniPlayerHealth>();
        if (hp != null)
        {
            hp.TakeDamage(damagePerHit);
        }
    }
}

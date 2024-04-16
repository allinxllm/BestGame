using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float value = 100;

    public PlayerProgress playerProgress;

    public bool IsAlive()
    {
        return value > 0;
    }

    private void Awake()
    {
        playerProgress = FindObjectOfType<PlayerProgress>();
    }

    public void DealDamage(float damage)
    {
        Awake();
        playerProgress.AddExperience(damage);
        value -= damage;
        if (value <= 0)
        {
            Destroy(gameObject);
        }
    }
}

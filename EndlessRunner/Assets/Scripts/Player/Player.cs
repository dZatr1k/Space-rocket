using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private UnityEvent _hit;

    public UnityAction<int> HealthChanged;
    public UnityAction Died;

    public void takeDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);
        _hit?.Invoke();

        if (_health <= 0)
            Die();
    }
    private void Die()
    {
        Died?.Invoke();
        gameObject.SetActive(false);
    }
}

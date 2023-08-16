using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] TMP_Text healthText;

    private int _health = 100;
    private int _maxHealth = 100;
    public Bar healthBar;

    private void Start()
    {
        DisplayHealth();
    }

    public void DisplayHealth()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + _health;
        }

        if (healthBar != null)
        {
            healthBar.SetBar(_health, _maxHealth);
        }
    }

    public void Damage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            Destroy(gameObject);
        }
        DisplayHealth();
    }
    public void Heal(int heal)
    {
        _health = Mathf.Min(_maxHealth, _health + heal);
    }

}

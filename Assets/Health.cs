using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;

public struct Health
{
    private int _maxHealth;
    private int _health;
    public int MaxHealth { get { return _maxHealth; } set { _maxHealth = value; } }
    public int CurrentHealth { get { return _health; } set { _health = value; } }
    public bool IsDead { get { return (_health <= 0); } }
    public Health(int maxHealth, int health)
    {
        _maxHealth = maxHealth;
        _health = health;
    }
    public Health(int health)
    {
        _health = health;
        _maxHealth = health;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour
{
    public float CurrentHealth;
    private float MaxHealth = 100f;
    PlayerController Player;
    private void Start()
    {
        Player = FindObjectOfType<PlayerController>();
    }
    private void Update()
    {
        CurrentHealth = Player.Health;
    }
}

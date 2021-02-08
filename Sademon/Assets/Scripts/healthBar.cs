using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    PlayerController Player;
    public RectTransform healthBarRect;

    private Quaternion rotation;
    private Vector3 position;

    void Awake()
    {
        rotation = transform.rotation;
        position = transform.parent.position - transform.position;
    }

    private void Start()
    {
        //find
        HealthBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        transform.rotation = rotation;
        transform.position = transform.parent.position - position;
        CurrentHealth = Player.Health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}

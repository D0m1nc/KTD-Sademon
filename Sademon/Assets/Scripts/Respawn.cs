using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter2D(Collider2D other)
    {
        Player.transform.position = respawnPoint.transform.position;
    }
}

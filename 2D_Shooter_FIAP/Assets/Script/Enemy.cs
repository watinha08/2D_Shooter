using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float velocity = 5;
    private int lives;
    private Transform enemyTransform;

    private void Awake()
    {
        enemyTransform = GetComponent<Transform>();
    }

    Vector2 targetPosition;

    void Update()
    {
        targetPosition = Player.instance.GetPlayerPosition();
        enemyTransform.position = Vector3.MoveTowards(enemyTransform.position, targetPosition, velocity * Time.deltaTime);
    }
}

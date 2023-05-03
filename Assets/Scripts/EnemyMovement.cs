using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
     private Vector3 playerTransform;
    [SerializeField] private float speed;

    private void Start()
    {
        playerTransform = FindObjectOfType<FirstPersonMovement>().transform.position;
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerTransform, speed * Time.deltaTime);
            transform.LookAt(playerTransform);
        }
    }
}

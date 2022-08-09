using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Range(1f, 10f)] 
    [SerializeField] 
    int speed = 4;

    enum EnemyTypes { Cyborg, BadGuy}
    [SerializeField] EnemyTypes enemyType;

    Vector3 Direction;

    [SerializeField] Transform TransformPlayer;

    void Start()
    {
        

    }
    void Update()
    {
        switch (enemyType)
        {
            case EnemyTypes.Cyborg:
                LookPlayerForever();
                break;

            case EnemyTypes.BadGuy:
                ChasePlayer();
                break;
        }
    }
    private void RandomBehavior()
    {
        //
    }

    private void ChasePlayer()
    {
        LookPlayer();
        Direction = (TransformPlayer.position - transform.position);
        if (Direction.magnitude >= 2f)
        {
            transform.position += Direction.normalized * speed * Time.deltaTime;
        }
    }

    private void LookPlayerForever()
    {
        LookPlayerLerp();
        transform.RotateAround(TransformPlayer.position, Vector3.up, 5f * Time.deltaTime);

    }

    private void LookPlayer()
    {
        transform.LookAt(TransformPlayer);
    }

    private void LookPlayerLerp()
    {
        Quaternion NewRotation = Quaternion.LookRotation(TransformPlayer.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, NewRotation, 2f * Time.deltaTime);
    }
    
}

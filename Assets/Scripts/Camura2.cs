using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camura2 : MonoBehaviour
{
    Transform _player;

    void Start ()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate() 
    {
        transform.position = new Vector3(transform.position.x, _player.transform.position.y, 0);
    }
}
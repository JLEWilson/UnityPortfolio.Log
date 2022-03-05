using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform _player;
    private Vector3 _targetPos;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        _targetPos = new Vector3(_player.position.x, _player.position.y, transform.position.z);
        transform.position = _targetPos;
    }
}

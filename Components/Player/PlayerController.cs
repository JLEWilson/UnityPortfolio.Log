using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;

    [SerializeField]
    private bool _canMove = true;
    [SerializeField]
    private float _moveSpeed = 1;
    [SerializeField]
    private Vector2 _movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_canMove)
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");
        }
    }

    void FixedUpdate()
    {
        if(_movement.x != 0 || _movement.y != 0){
            rb.MovePosition(rb.position + _movement.normalized * _moveSpeed * Time.fixedDeltaTime);
        }
    }
}

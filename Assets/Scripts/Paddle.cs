using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 7f;

    private void Update()
    {
        float verticalMovement = Input.GetAxisRaw("Vertical");

        GetComponent<Rigidbody2D>().velocity = new Vector2(
            0,
            verticalMovement * speed
        );
    }
}

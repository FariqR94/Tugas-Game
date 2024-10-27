using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D body;

    public float moveSpeed;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()    
    {
        TouchMove();    
    }

    public void TouchMove()
    {
        if(Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(touchPos.x < 0)
            {
                body.linearVelocity = Vector2.left * moveSpeed;
            }
            else
            {
                body.linearVelocity = Vector2.right * moveSpeed;
            }
        }
            else
            {
                body.linearVelocity = Vector2.zero;
            }
        }
    }


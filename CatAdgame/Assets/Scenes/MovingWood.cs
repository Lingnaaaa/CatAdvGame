using UnityEngine;

public class MovingWood : MonoBehaviour
{
    [Header("Move Setting")]
    public float speed = 2.0f; 
    public float distance = 3.0f;   // (each f is 1 grid)
    public bool moveRight = true;   // moving to the right

    private Vector2 startPos; //Initial Position

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // The distance
        float movement = Mathf.PingPong(Time.time * speed, distance);

        // 根据勾选框决定方向
        if (moveRight)
        {
            transform.position = new Vector2(startPos.x + movement, startPos.y);
        }
        else
        {
            transform.position = new Vector2(startPos.x - movement, startPos.y);
        }
    }
}
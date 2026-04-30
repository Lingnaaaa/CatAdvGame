using UnityEngine;

public class MovingWood : MonoBehaviour
{
    public float speed = 2.0f;  //setting the speed
    public float distance = 3.0f;   // setting the distance
    public bool moveRight = true;   // moving to the right

    private Vector2 startPos; //Initial Position

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // When the board reach the distance(set at first), then Mathf.PingPong will
        //let the board return to the initial position
        float movement = Mathf.PingPong(Time.time * speed, distance);

        // Adding in X-axis, moving horizontally
        transform.position = new Vector2(startPos.x + movement, startPos.y);
    }
}
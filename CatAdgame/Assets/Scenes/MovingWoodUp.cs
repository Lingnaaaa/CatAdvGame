using UnityEngine;

public class MovingWoodUp : MonoBehaviour
{
    [Header("Moving Up setting")]
    public float speed = 2.0f;  
    public float distance = 3.0f;

    private Vector2 startPos;    

    void Start()
    {
        //initial Position (use to calculate the distance)
        startPos = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);

        // Moving back to initial position
        transform.position = new Vector2(startPos.x, startPos.y + movement);
    }
}

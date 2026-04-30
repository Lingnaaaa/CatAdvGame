using UnityEngine;

public class MovingWoodUp : MonoBehaviour
//Almost same as MovingWood.cs. 
//In the end of code, the movement adding on Y-axis, so moving vertically
{
    public float speed = 2.0f;  
    public float distance = 3.0f;

    private Vector2 startPos;    

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);

        transform.position = new Vector2(startPos.x, startPos.y + movement);
    }
}

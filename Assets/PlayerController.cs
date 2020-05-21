using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public float forwardSpeed = 200f;
    public float upwardForce = 400f;
    public int minY = -100;
    public int maxY = 100;

    // Update is called once per frame
    void Update()
    {
        // keep the player always in the same x position (so we don't pass the obstacle from the side)
        player.transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        player.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            player.AddForce(0, upwardForce * Time.deltaTime, 0);
        }

        if (player.transform.position.y < minY || player.transform.position.y > maxY)
        {
            // KILL THE PLAYER
        }
    }
}

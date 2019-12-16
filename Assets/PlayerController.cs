using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    public float forwardSpeed = 1200f;
    public float upwardForce = 500f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            player.AddForce(0, upwardForce * Time.deltaTime, 0);
        }
    }
}

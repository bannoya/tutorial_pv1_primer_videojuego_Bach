using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;

    private Vector3 speed;
    private IMovementStrategy movementStrategy;
    private Player player;

    void Start()
    {
        forceToApply = new Vector3(0, 0, 400f);
        timeSinceLastForce = 0f;
        intervalTime = 1f;
        player = new Player(5f, 1000f);
        //SetMovementStrategy(new AccelerateMovementStrategy());
        //SetMovementStrategy(new SmoothMovementStrategy());

    }




    private void FixedUpdate()
    {
        timeSinceLastForce += Time.deltaTime;
        if (timeSinceLastForce > intervalTime)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(forceToApply);
            timeSinceLastForce = 0f;
        }

    }
    public void SetMovementStrategy(IMovementStrategy movementStrategy)
    {

        this.movementStrategy = movementStrategy;
    }
    public void MovePlayer(float input)
    {

        movementStrategy.Move(transform, player, input);
    }
}

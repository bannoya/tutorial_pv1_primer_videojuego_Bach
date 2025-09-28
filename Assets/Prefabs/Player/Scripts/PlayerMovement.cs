using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;

    private Vector3 speed;
    private IMovementStrategy movementStrategy;
    private Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        forceToApply = new Vector3(0, 0, 300);
        timeSinceLastForce = 0f;
        intervalTime = 2f;
        player = new Player(5f, 5f);
        //SetMovementStrategy(new AccelerateMovementStrategy());
        SetMovementStrategy(new SmoothMovementStrategy());

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
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
    public void SetMovementStrategy(IMovementStrategy movementStrategy) {
    
        this.movementStrategy = movementStrategy;
    }
    public void MovePlayer() {

        movementStrategy.Move(transform, player);
    }
}

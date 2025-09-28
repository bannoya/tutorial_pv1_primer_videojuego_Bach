using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 forceToApply;
    private float timeSinceLastForce;
    private float intervalTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        forceToApply = new Vector3(0, 0, 300);
        timeSinceLastForce = 0f;
        intervalTime = 2f;

    }

    // Update is called once per frame
    void Update()
    {

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
}

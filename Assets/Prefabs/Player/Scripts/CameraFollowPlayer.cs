using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    private Vector3 offSet;
    private PlayerMovement playerMovement;
    void Start()
    {
        offSet = new Vector3(0, 2, -5);
        playerMovement = FindAnyObjectByType<PlayerMovement>();
    }

  
    private void LateUpdate()
    {
        gameObject.transform.position = playerMovement.transform.position + offSet;
    }
}

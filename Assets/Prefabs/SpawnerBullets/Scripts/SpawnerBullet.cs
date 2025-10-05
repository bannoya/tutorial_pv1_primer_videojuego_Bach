using UnityEngine;

public class SpawnerBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject bullet;
    void Start()
    {
        InvokeRepeating("CreateBullet", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void CreateBullet()
    {

        Instantiate(bullet, transform.position, transform.rotation);

    }
}

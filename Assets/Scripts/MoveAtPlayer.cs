using UnityEngine;

public class MoveAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPos;

    [SerializeField] float moveSpeed = 20f;


    void Awake()
    {
        gameObject.SetActive(false);

    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, moveSpeed * Time.deltaTime);
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPos)
        {
            Destroy(gameObject);
        }
    }

}

using UnityEngine;

public class MoveAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPos = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos, 20f * Time.deltaTime);
    }
}

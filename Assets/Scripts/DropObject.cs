using UnityEngine;

public class DropObject : MonoBehaviour
{

    [SerializeField] float dropDelay = 2f;
    MeshRenderer meshRenderer;
    Rigidbody rb;

    void Awake()
    {
        gameObject.SetActive(false);

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rb.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropDelay)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }

    }
}

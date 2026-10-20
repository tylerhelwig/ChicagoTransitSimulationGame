using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class sidescroll : MonoBehaviour
{
    [SerializeField] private float scrollSpeed;
    [SerializeField] private Transform leftEndpoint;
    [SerializeField] private Transform rightEndpoint;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float halfWidth = spriteRenderer.bounds.extents.x;
        float width = spriteRenderer.bounds.size.x;
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        if (transform.position.x + halfWidth < leftEndpoint.position.x) // If the left corner of the sprite is past the endpoint
        {
            //move the sprite back 2x its width
            transform.position = new(rightEndpoint.position.x - halfWidth, transform.position.y, transform.position.z);
        }
    }
}

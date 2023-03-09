using UnityEngine;

public class Player1 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;

    public float strength = 5f;
    public float gravity = -9.81f;
    public float tilt = 5f;

    private Vector3 direction;

    private void Awake()
    {
       
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

   void Start()
    {
        //  Debug.Log("wazup222");
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    void Update()
    {
        //  Debug.Log("wazup333");
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            
            direction = Vector3.up * strength;
        }

        // Apply gravity and update the position
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

        // Tilt the bird based on the direction
        Vector3 rotation = transform.eulerAngles;
        rotation.z = direction.y * tilt;
        transform.eulerAngles = rotation;
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        if (spriteIndex < sprites.Length && spriteIndex >= 0)
        {
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        if (other.gameObject.CompareTag("Scoring"))
        {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }

}
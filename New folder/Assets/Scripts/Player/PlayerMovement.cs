using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField] private float speed;

    private bool ok = true;

    private Animator anim;

    private BoxCollider2D boxCollider;

    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private LayerMask wallLayer;

    [Header("SFX")]
    [SerializeField]private AudioClip jumpSound;
    private void Awake(){
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update() {

        float horizontalInput = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        if(horizontalInput > 0.01f){
            transform.localScale = new Vector3(3.829964f, 4.539542f, 1);
            if(ok == false){
                transform.localPosition = new Vector3(transform.localPosition.x + 2.33999f, transform.localPosition.y, transform.localPosition.z);
                ok = true;
            }
        }
        else if(horizontalInput < -0.01f){
            transform.localScale = new Vector3(-3.829964f, 4.539542f, 1);
            if(ok == true){
                transform.localPosition = new Vector3(transform.localPosition.x - 2.33999f, transform.localPosition.y, transform.localPosition.z);
                ok = false;
            }
        }
        
        if(Input.GetKey(KeyCode.Space)){
            body.velocity = new Vector2(body.velocity.x, speed);
            
            
            if(Input.GetKeyDown(KeyCode.Space))
                SoundManager.instance.PlaySound(jumpSound);
        }

        anim.SetBool("run", horizontalInput != 0);

    }

    private bool isGrounded(){
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }

    private bool onWall(){
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, wallLayer);
        return raycastHit.collider != null;
    }

    public bool canAttack(){
        float horizontalInput = Input.GetAxis("Horizontal");
        return horizontalInput == 0 && isGrounded() && !onWall();
    }


}
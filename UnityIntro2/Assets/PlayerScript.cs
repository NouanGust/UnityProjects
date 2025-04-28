using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float jumpForce;
    [SerializeField] bool isGrounded = false;
    Rigidbody2D RB;
    

    void Awake() {
        RB = GetComponent<Rigidbody2D>();  
    }

    void Update() {
        
        // Pula -- Aqui pega o input do Espaço e aplica uma força para cima.
        if(Input.GetKeyDown(KeyCode.Space)) {
            if(isGrounded == true) {
                RB.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
            }
        }      
    }

    // Detecta colisão com o chão e obstaculo
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.CompareTag("ground")) {
            if(isGrounded == false){
                isGrounded = true;
            }
        }
    }
}

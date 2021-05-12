using UnityEngine;
public class PlayerMov : MonoBehaviour
{
    [SerializeField]
    public float speed;         //velocidade de movimento, regula no Unity
    private Vector2 direction; //direção que o player vai andar
    public Animator anim;      //chama a animação
    void Start()
    {
        anim = GetComponent<Animator>(); //inicia a animação do cenario
        direction = Vector2.up;
    }
    void Update()
    {
        GetInput();  //tecla que você pressionar
        MOVE();      //executa o movimento de acordo com o IF
        
    }
    public void MOVE()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void GetInput()
    {
        direction = Vector2.zero;
        if (Input.GetKey(KeyCode.W))   // pode trocar o W pelo UpArrow
        {
            direction += Vector2.up;
            anim.SetBool("player_up", true);
            anim.SetBool("player_down", false);
            anim.SetBool("player_left", false);
            anim.SetBool("player_right", false);
            anim.SetBool("parado", false);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("player_up", false);
            anim.SetBool("player_down", false);
            anim.SetBool("player_left", false);
            anim.SetBool("player_right", false);
            anim.SetBool("parado", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
            anim.SetBool("player_up", false);
            anim.SetBool("player_down", true);
            anim.SetBool("player_left", false);
            anim.SetBool("player_right", false);
            anim.SetBool("parado", false);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("player_up", false);
            anim.SetBool("player_down", false);
            anim.SetBool("player_left", false);
            anim.SetBool("player_right", false);
            anim.SetBool("parado", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
            anim.SetBool("player_up", false);
            anim.SetBool("player_down", false);
            anim.SetBool("player_left", true);
            anim.SetBool("player_right", false);
            anim.SetBool("parado", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("player_up", false);
            anim.SetBool("player_down", false);
            anim.SetBool("player_left", false);
            anim.SetBool("player_right", false);
            anim.SetBool("parado", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
            anim.SetBool("player_up", false);
            anim.SetBool("player_down", false);
            anim.SetBool("player_left", false);
            anim.SetBool("player_right", true);
            anim.SetBool("parado", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("player_up", false);
            anim.SetBool("player_down", false);
            anim.SetBool("player_left", false);
            anim.SetBool("player_right", false);
            anim.SetBool("parado", true);
        }

    }
}

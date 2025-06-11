using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class EnemyAnimationControled : MonoBehaviour
{
    public int speed;
    public int speedy;
    public int speedx;
    public Animator anin;
    Rigidbody2D _compRigidbody2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       anin.GetComponent<Animation>();
        _compRigidbody2D = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
  //      bool istryingTorun = anin.GetBool("Run");
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            anin.SetBool("Run",true);
            speed = 3;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift)){
            anin.SetBool("Run", false);
            speed = 1;
        }
        if (Input.GetKey(KeyCode.W)) {
            // anin.Play(istryingTorun ? "EnemyRunUp" : "OrcWalkUp");
            //anin.Play("Enemicorrerarriba");
            //anin.SetBool("PressedKey",true);

            if (anin.GetBool("Run"))
            {
                anin.Play("Enemicorrerarriba");
            }
            else
            {
                anin.Play("OrcWalkUp");
            }
            speedy = 3;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //anin.Play("Enemicorrerabajo");
            // anin.SetBool("PressedKey", true);

            /*string _anim = anim.GetBool("Run")? "EnemyRunDown": OrcWalkDown"
             */
            if (anin.GetBool("Run"))
            {
                anin.Play("Enemicorrerabajo");
            }
            else
            {
                anin.Play("OrcWalkDown");
            }
            speedy = -3;
        }
        if (Input.GetKey(KeyCode.A))
        {
            //anin.Play("Enemicorrerizquierda");
            // anin.SetBool("PressedKey", true);
            if (anin.GetBool("Run"))
            {
                anin.Play("Enemicorrerizquierda");
            }
            else
            {
                anin.Play("OrcWalkLeft");
            }
            speedx = -3;
        }
        if (Input.GetKey(KeyCode.D))
        {
           // anin.Play("Enemicorrerderecha");
            if (anin.GetBool("Run"))
            {
                anin.Play("Enemicorrerderecha");
            }
            else
            {
                anin.Play("OrcWalkRight");
            }
            // anin.SetBool("PressedKey", true);
            speedx = 3;
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S )|| Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))   {
            // anin.SetBool("PressedKey", false);
            anin.SetTrigger("trigger");
            speedx = 0;
            speedy = 0;
        }
        _compRigidbody2D.linearVelocity = new Vector2(speed * speedx, speed * speedy);
        anin.SetTrigger("SetIdle");
    }
}


//https://anotepad.com/notes/7m8ac77q


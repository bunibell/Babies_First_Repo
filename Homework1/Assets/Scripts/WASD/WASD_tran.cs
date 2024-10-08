using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class WASD_tran : MonoBehaviour
{
    //Variables 
    public float speed = 3f;

    public GameObject pl2;

    private bool spawn = true;

    //public GameManager gameManager;

    //Awake happens on spawn of an item
    private void Awake()
    {
        pl2 = this.gameObject;
        //gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //Find the position of the object every frame and make a vector 
        Vector2 pos = transform.position;

        //If I press right arrow move the position to the right 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        //If I press left arrow move the position to the left 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }
        //If I press up arrow move the position up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }
        //If I press the down arrow move the position down 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }
        transform.position = pos;*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Only spawn if true 
        if (spawn)
        {
            spawn = false;
            if (collision.transform.tag == "Player")
            {
                //gameManager.sc_num++;
                GameManager.instance.sc_num++;
            }else if (collision.transform.tag == "Player 3")
            {
                //gameManager.p3sc_num++;
                GameManager.instance.p3sc_num++;
            }


            //Spawn a new Player 2 at a random location 
            var pos = new Vector2(Random.Range(-8, 8), Random.Range(-2, 3));
            Instantiate(pl2, pos, Quaternion.identity);

            //Destroy player
            Destroy(this.gameObject);
            spawn = true;
        }

    }
    
}

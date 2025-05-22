using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    private Gamemanager manager;
    public PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<Gamemanager>();
        Debug.Log(manager);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "trap")
        {
            manager.loseHealth(1);
            playerController.knockBack(15f, 5f);
        }

        if (collision.gameObject.tag == "InstaKill")
        {
            manager.loseHealth(1000);
            // trigger death anim
        }


            if (collision.gameObject.tag == "healthpickup")
            {
                manager.gainHealth(1);
                playerController.knockBack(15f, 5f);
                Destroy(collision.gameObject);
            }
        }





    // Update is called once per frame
    void Update()
    {

    }
}

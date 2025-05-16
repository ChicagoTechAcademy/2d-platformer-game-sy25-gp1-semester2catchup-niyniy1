using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
  private void OnTriggerEnter2D(Collider2D collision) 
{
    if(collision.gameObject.tag == "Trap")
    {
        Debug.Log("you hit a trap");
    }

    
}

    public void losehealth( int healthToLose)
    {
        
    }
}

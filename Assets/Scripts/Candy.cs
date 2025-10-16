using UnityEngine;

public class Candy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            collision.GetComponent<GameManager>().contador += 1;
            print("Le sirvo comida al cliente");
            Destroy(gameObject);
        }
    }

}

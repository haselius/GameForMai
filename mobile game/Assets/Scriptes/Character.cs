
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField]
    public static bool lose = false;
    public GameObject Player;
    public GameObject RestartMenu;
    public GameObject MainMenu;
    public static int points;
    public HealthBar hp;
    void Awake()
    {
        lose = false;
    }
    void Start()
    {
        hp.MaxHealth(Characteristics.life);
    }


    void Update()
    {
        if (global::Character.lose)
        {

            RestartMenu.SetActive(true);

        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            points += 1;
        }
        if (other.gameObject.CompareTag("block"))
        {
            Characteristics.life--;
            Destroy(other.gameObject);
            hp.CurrentHealth(Characteristics.life);
            Debug.Log("TRUE");
        }
        if (Characteristics.life == 0)
        {
            lose = true;
        }
    }
}


using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField]
    public static bool lose = false;
   //public Text coinAmount;
    public GameObject Player;
    public GameObject RestartMenu;
    public GameObject MainMenu;
    private int life = 3;
    public static int points;
    public HealthBar hp;
    void Awake()
    {
        lose = false;
    }
    void Start()
    {
        hp.MaxHealth(life);
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
            // coinAmount.text = wealth.ToString() + "x";

        }
        if (other.gameObject.CompareTag("block"))
        {
            life = life - 1 ;
            Destroy(other.gameObject);
            hp.CurrentHealth(life);
            Debug.Log("TRUE");
        }
        if (life == 0)
        {
            lose = true;
        }
    }
}

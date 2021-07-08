
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    void Start()
    {

    }

    public void OnMouseDown()
    {
        Characteristics.life = Characteristics.startHp;
        SceneManager.LoadScene("MENU");
    }

}
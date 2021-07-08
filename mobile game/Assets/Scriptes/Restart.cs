
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{

    void Start()
    {

    }

    public void OnMouseDown()
    {
        Characteristics.life = Characteristics.startHp;
        SceneManager.LoadScene("main");

    }

}
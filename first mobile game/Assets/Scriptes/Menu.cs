
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    void Start()
    {

    }

    void OnMouseDown()
    {
        SceneManager.LoadScene("main");
    }

}
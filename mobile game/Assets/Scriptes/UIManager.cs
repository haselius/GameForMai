using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void Hp1()
    {
        Characteristics.life = 1;
        Characteristics.startHp = 1;
    }
    public void Hp2()
    {
        Characteristics.life = 2;
        Characteristics.startHp = 2;
    }
    public void Hp3()
    {
        Characteristics.life = 3;
        Characteristics.startHp = 3;
    }
    public void SlowChar() => Characteristics.speedChar = 5f;
    public void MediumChar() => Characteristics.speedChar = 10f;
    public void FastChar() => Characteristics.speedChar = 20f;
    public void SlowBlock() => Characteristics.fallSpeed = 3f;
    public void MediumBlock() => Characteristics.fallSpeed = 5f;
    public void FastBlock() => Characteristics.fallSpeed = 10f;
}

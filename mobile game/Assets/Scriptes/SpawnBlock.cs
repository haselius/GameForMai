using System.Collections;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public GameObject block;
    public GameObject coin;
    [SerializeField]
    private float spawnspeed=0.2f;

    void Start()
    {

        
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        while (!global::Character.lose)
        {
            int chooser = Random.Range(1,10);
            if (chooser == 1)
                Instantiate(coin, new Vector2(Random.Range(-8.2f, 8.2f), 5.5f), Quaternion.identity);
            else
                Instantiate(block, new Vector2(Random.Range(-8.2f, 8.2f),5.5f),Quaternion.identity);
            yield return new WaitForSeconds(spawnspeed);

        }
    }
 
}

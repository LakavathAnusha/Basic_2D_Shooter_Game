using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Vector3 offset;
    float score;
    public GameObject enemyPrefab;
    float time;
    Stack<GameObject> bulletStack = new Stack<GameObject>();
    private static Bullet instance;
    //public static Bullet Instance
    //{
    //    get
    //    {
    //        if (instance == null)
    //        {
    //            instance = GameObject.FindObjectOfType<Bullet>();
    //        }
    //        return instance;
    //    }
    //}
    //public static Sp
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            bulletStack.Push(Instantiate(bulletPrefab));
            bulletPrefab.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CreateBullet();
            //Instantiate(bulletPrefab, transform.position+offset, Quaternion.identity);
        }
        time = time + Time.deltaTime;
        if (time >= 3f)
        {
            float x = Random.Range(-7f, 7f);
            float y = Random.Range(-4f, 4f);
            Instantiate(enemyPrefab, new Vector3(x, y, 0), Quaternion.identity);
            time = 0f;
        }
    }
    public void CreateBullet()       // Creating a bullet, by poping out from the bulletSatck
    {
        GameObject bullet = bulletStack.Pop();
        bullet.SetActive(true);
        bullet.transform.position = transform.position + offset;
    }
    public void BackToPool(GameObject obj) // Here, the bullet gets again into the pool.
    {
        obj.SetActive(false);
        bulletStack.Push(obj);

    }
}
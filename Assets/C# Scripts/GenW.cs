using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GenW : MonoBehaviour
{

    public GameObject[] GrassSprites;
    public GameObject[] GameObjects;

    public bool isWork = true;
    public Vector3 GameObject_position;

    public string GameObject_name;

    public GameObject Wall;
    public GameObject GameObject;


    void Update()
    {

        GrassSprites = GameObject.FindGameObjectsWithTag("Grass");
        GameObjects = GameObject.FindObjectsOfType<GameObject>();

        if (isWork)
        {
            for (int i = 0; i < GrassSprites.Length; i++)
            {
                GameObject = Instantiate(Wall, new Vector3(GrassSprites[i].transform.position.x + 4, GrassSprites[i].transform.position.y + 4, 1), Quaternion.identity);
                GameObject.name = GameObject_name;
                GameObject_position = GameObject.transform.position;


                for ( int j = 0; j < GameObjects.Length; j ++)
                {
                    if (GameObjects[j].transform.position.x == GameObject_position.y && GameObjects[j].transform.position.y == GameObject_position.y)
                    {
                        Destroy(GameObject);
                    }
                }



                GameObject = Instantiate(Wall, new Vector3(GrassSprites[i].transform.position.x + 4, GrassSprites[i].transform.position.y, 1),     Quaternion.identity);
                GameObject.name = GameObject_name;
                GameObject_position = GameObject.transform.position;


                for (int j = 0; j < GameObjects.Length; j++)
                {
                    if (GameObjects[j].transform.position.x == GameObject_position.y && GameObjects[j].transform.position.y == GameObject_position.y)
                    {
                        Destroy(GameObject);
                    }
                }



                GameObject = Instantiate(Wall, new Vector3(GrassSprites[i].transform.position.x + 4, GrassSprites[i].transform.position.y - 4, 1), Quaternion.identity);
                GameObject.name = GameObject_name;
                GameObject_position = GameObject.transform.position;


                for (int j = 0; j < GameObjects.Length; j++)
                {
                    if (GameObjects[j].transform.position.x == GameObject_position.y && GameObjects[j].transform.position.y == GameObject_position.y)
                    {
                        Destroy(GameObject);
                    }
                }



                GameObject = Instantiate(Wall, new Vector3(GrassSprites[i].transform.position.x,     GrassSprites[i].transform.position.y - 4, 1), Quaternion.identity);
                GameObject.name = GameObject_name;
                GameObject_position = GameObject.transform.position;


                for (int j = 0; j < GameObjects.Length; j++)
                {
                    if (GameObjects[j].transform.position.x == GameObject_position.y && GameObjects[j].transform.position.y == GameObject_position.y)
                    {
                        Destroy(GameObject);
                    }
                }



                GameObject = Instantiate(Wall, new Vector3(GrassSprites[i].transform.position.x - 4, GrassSprites[i].transform.position.y - 4, 1), Quaternion.identity);
                GameObject.name = GameObject_name;
                GameObject_position = GameObject.transform.position;


                for (int j = 0; j < GameObjects.Length; j++)
                {
                    if (GameObjects[j].transform.position.x == GameObject_position.y && GameObjects[j].transform.position.y == GameObject_position.y)
                    {
                        Destroy(GameObject);
                    }
                }



                GameObject = Instantiate(Wall, new Vector3(GrassSprites[i].transform.position.x - 4, GrassSprites[i].transform.position.y, 1),     Quaternion.identity);
                GameObject.name = GameObject_name;
                GameObject_position = GameObject.transform.position;


                for (int j = 0; j < GameObjects.Length; j++)
                {
                    if (GameObjects[j].transform.position.x == GameObject_position.y && GameObjects[j].transform.position.y == GameObject_position.y)
                    {
                        Destroy(GameObject);
                    }
                }



                GameObject = Instantiate(Wall, new Vector3(GrassSprites[i].transform.position.x - 4, GrassSprites[i].transform.position.y + 4, 1), Quaternion.identity);
                GameObject.name = GameObject_name;
                GameObject_position = GameObject.transform.position;

                for (int j = 0; j < GameObjects.Length; j++)
                {
                    if (GameObjects[j].transform.position.x == GameObject_position.y && GameObjects[j].transform.position.y == GameObject_position.y)
                    {
                        Destroy(GameObject);
                    }
                }



                GameObject = Instantiate(Wall, new Vector3(GrassSprites[i].transform.position.x,     GrassSprites[i].transform.position.y + 4, 1), Quaternion.identity);
                GameObject.name = GameObject_name;
                GameObject_position = GameObject.transform.position;


                for (int j = 0; j < GameObjects.Length; j++)
                {
                    if (GameObjects[j].transform.position.x == GameObject_position.y && GameObjects[j].transform.position.y == GameObject_position.y)
                    {
                        Destroy(GameObject);
                    }
                }


            }
        }
    }
}

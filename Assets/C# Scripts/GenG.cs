using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenG : MonoBehaviour
{

    public int GrassFrames;
    public int F = 4;
    public int X = 2;
    public int cnt = 0;
    public int prevGrassFrames;

    public GameObject Grass;

    public int asdasdasd = 0;

    public Vector3 GameObject_pos;
    public string GameObject_n;
    public Vector3 prev_GameObject_pos = new Vector3(0, 0, 0);
    public GameObject prev_GameObject_;
    public GameObject GameObject_;
    public GameObject[] GameObjects_;
    public int GSL;


    public GameObject[] RoadSprites;
    public GameObject[] GrassSprites;

    public bool isWork = true;

    void Awake()
    {
        GrassFrames = Random.Range(1, 2);

        
    }


    public void SetGrassCount()
    {
        GrassFrames = Random.Range(1, 2);
        
    }

    /*public void deleting()
    {
        for (int k = 0; k < GameObjects_.Length; k++)
        {
            if (prev_GameObject_pos.x == GameObject_pos.x && prev_GameObject_pos.y == GameObject_pos.y)
            {
                prev_GameObject_ = GameObject_;
                prev_GameObject_pos = GameObject_pos;
                Destroy(GameObject_);
            }
            GameObjects_ = GameObject.FindObjectsOfType<GameObject>();
        }
    }*/

    void Start()
    {
        if (isWork)
        {
            RoadSprites = GameObject.FindGameObjectsWithTag("Road");






            for (int j = 0; j < RoadSprites.Length; j ++)
            {
                prevGrassFrames = GrassFrames;
                SetGrassCount();
                cnt ++;

                if (cnt != 5)
                {
                    GrassFrames = prevGrassFrames;
                }

                else if (cnt == 5)
                {
                    cnt = 0;
                }


                for (int i = 0; i < GrassFrames; i ++)
                {

                    GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 4, RoadSprites[j].transform.position.y + 4, 1), Quaternion.identity);
                    GameObject_.transform.parent = RoadSprites[j].transform;
                    GameObject_.name = GameObject_n;
                    GameObject_pos = GameObject_.transform.position;


                    



                    GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 4, RoadSprites[j].transform.position.y, 1),     Quaternion.identity);
                    GameObject_.transform.parent = RoadSprites[j].transform;
                    GameObject_.name = GameObject_n;
                    GameObject_pos = GameObject_.transform.position;


                    



                    GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 4, RoadSprites[j].transform.position.y - 4, 1), Quaternion.identity);
                    GameObject_.transform.parent = RoadSprites[j].transform;
                    GameObject_.name = GameObject_n;
                    GameObject_pos = GameObject_.transform.position;


                    



                    GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x,     RoadSprites[j].transform.position.y - 4, 1), Quaternion.identity);
                    GameObject_.transform.parent = RoadSprites[j].transform;
                    GameObject_.name = GameObject_n;
                    GameObject_pos = GameObject_.transform.position;


                    



                    GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 4, RoadSprites[j].transform.position.y - 4, 1), Quaternion.identity);
                    GameObject_.transform.parent = RoadSprites[j].transform;
                    GameObject_.name = GameObject_n;
                    GameObject_pos = GameObject_.transform.position;


                    



                    GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 4, RoadSprites[j].transform.position.y, 1),     Quaternion.identity);
                    GameObject_.transform.parent = RoadSprites[j].transform;
                    GameObject_.name = GameObject_n;
                    GameObject_pos = GameObject_.transform.position;


                    



                    GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 4, RoadSprites[j].transform.position.y + 4, 1), Quaternion.identity);
                    GameObject_.transform.parent = RoadSprites[j].transform;
                    GameObject_.name = GameObject_n;
                    GameObject_pos = GameObject_.transform.position;


                    



                    GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x,     RoadSprites[j].transform.position.y + 4, 1), Quaternion.identity);
                    GameObject_.transform.parent = RoadSprites[j].transform;
                    GameObject_.name = GameObject_n;
                    GameObject_pos = GameObject_.transform.position;


                    



                    if (GrassFrames == 2)
                    {

                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 8, RoadSprites[j].transform.position.y + 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 8, RoadSprites[j].transform.position.y, 1),     Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 8, RoadSprites[j].transform.position.y - 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x,     RoadSprites[j].transform.position.y - 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 8, RoadSprites[j].transform.position.y - 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 8, RoadSprites[j].transform.position.y, 1),     Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 8, RoadSprites[j].transform.position.y + 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x,     RoadSprites[j].transform.position.y + 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        




                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 8, RoadSprites[j].transform.position.y + 4, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 8, RoadSprites[j].transform.position.y - 4, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 4, RoadSprites[j].transform.position.y - 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 4, RoadSprites[j].transform.position.y - 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        


                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 8, RoadSprites[j].transform.position.y - 4, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 8, RoadSprites[j].transform.position.y + 4, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        



                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x - 4, RoadSprites[j].transform.position.y + 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;





                        GameObject_ = Instantiate(Grass, new Vector3(RoadSprites[j].transform.position.x + 4, RoadSprites[j].transform.position.y + 8, 1), Quaternion.identity);
                        GameObject_.transform.parent = RoadSprites[j].transform;
                        GameObject_.name = GameObject_n;
                        GameObject_pos = GameObject_.transform.position;


                        




                    }
                }
                

            }
            RoadSprites = GameObject.FindGameObjectsWithTag("Road");
            GameObjects_ = GameObject.FindObjectsOfType<GameObject>();
            GrassSprites = GameObject.FindGameObjectsWithTag("Grass");
            GSL = GrassSprites.Length;

            for (int i = 0; i < GSL; i++)
            {
                if (GrassSprites[i].transform.position.x == GameObjects_[i].transform.position.x && GrassSprites[i].transform.position.y == GameObjects_[i].transform.position.y)
                {
                    GrassSprites[i].SetActive(false);
                    print(1);

                }
            }

            /*for (int i = 0; i < GSL; i++)
            {
                if (GrassSprites[i].activeSelf == false) 
                {
                    Destroy(GrassSprites[i]);
                    i++;
                }
            }*/
            isWork = false;
            

        }
    }

    
    


    


    
}

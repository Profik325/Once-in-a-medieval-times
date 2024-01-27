using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GenR : MonoBehaviour
{
    public static int MapSize;
    //public Vector2[] cellPosition;

   // public int dirCount = 3;

    public GameObject Road1;

    public int RandInt;

    public int Rr;

    public int DnF;
    public int DnS;

     List <Vector2> cellPosition = new List <Vector2>();

    public int Number = 0;

    public Direction prevDir;
    public Direction nextDir;

    public int RoadPosY = 0;
    public int RoadPosX = 0;

    public int PositionCoef = 4;

    void Awake()
    {
        MapSize = Random.Range(150, 300);
        //cellPosition = new Vector2[MapSize]; 


        moveORr();

        SpawnStartRoad();

        for (int i = 0; i < MapSize; i++)
        {
            print(Rr);

            moveORr();

            DirectionRotateN();
            Rotate();

            if (prevDir == Direction.Left && nextDir == Direction.Right) nextDir = GetNewDirection();
            if (prevDir == Direction.Right && nextDir == Direction.Left) nextDir = GetNewDirection();

            ScriptingGenerateRoad();


            //print(cellPosition[i] + prevDir.ToString() + nextDir.ToString());

        }

        SpawningRoad();

    }

    public enum Direction
    {
        Back,
        Left,
        Forward,
        Right

    }

    Direction GetNewDirection()
    {
        Direction newDir = Direction.Forward;
        int i = Random.Range(0, 2);
        if(prevDir == Direction.Left) newDir = i > 0? Direction.Forward : Direction.Left;
        if(prevDir == Direction.Right) newDir = i > 0? Direction.Forward : Direction.Right;
        
        return newDir;
    }

    void Start()
    {
        moveORr();

        SpawnStartRoad();
        
        for (int i = 0; i < MapSize; i++)
        {
            

            moveORr();

            DirectionRotateN();
            Rotate();

            if (prevDir == Direction.Left && nextDir == Direction.Right) nextDir = GetNewDirection();
            if (prevDir == Direction.Right && nextDir == Direction.Left) nextDir = GetNewDirection();

            ScriptingGenerateRoad();
            

            //print(cellPosition[i] + prevDir.ToString() + nextDir.ToString());

        }

        SpawningRoad();
        


        
            

    }

      

    public void moveORr()
    {
        Rr = Random.Range(6, 8);
        
    }

    public void DirectionRotateN()
    {
        DnF = Random.Range(0, 3);                // Direction number first
        //xStartCoroutine(ExampleCoroutine());
        
    }

    /*IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(0.05f);
        DnS = Random.Range(0, 2);               // Direction Number Second
    }*/

    public void Rotate()
    {
        switch(DnF)
        {
            case 0:
                nextDir = Direction.Left;
        
                break;

            case 1:
                nextDir = Direction.Forward;

                break;

            case 2:
                nextDir = Direction.Right;
                
                break;


        }
    
    }



      

    public void SpawningRoad()     
    {
        for (int i = 0; i < MapSize; i++)
        {
            Instantiate(Road1, new Vector3(cellPosition[i].x * PositionCoef, cellPosition[i].y * PositionCoef, 0), Quaternion.identity);
            
        }
    }


    public void SpawnStartRoad()     // first
    {
        
        
        Instantiate(Road1, new Vector3(0, 0, 0), Quaternion.identity); 
        
        
    }

    public void ScriptingGenerateRoad()     //forth
    {
        switch(nextDir)
        {   
            case Direction.Left:
                for (int i = 0; i < Rr; i ++)
                {
                    RoadPosY += 1;
                    cellPosition.Add(new Vector2(RoadPosX, RoadPosY));

                    Number++;
                }

                prevDir = Direction.Left;
                break;
                
            case Direction.Forward:
                for (int i = 0; i < Rr; i ++)
                {
                    RoadPosX += 1;
                    cellPosition.Add(new Vector2(RoadPosX, RoadPosY));
                    
                    Number++;
                }

                prevDir = Direction.Forward;
                break;

            case Direction.Right:
                for (int i = 0; i < Rr; i ++)
                {
                    RoadPosY -= 1;
                    cellPosition.Add(new Vector2(RoadPosX, RoadPosY));
                    
                    Number++;
                }

                prevDir = Direction.Right;
                break;

          

        }

        
        
    } 




}

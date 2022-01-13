using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBehavior : MonoBehaviour
{
    public float place = 0f;
    public int select = 0;
    public List<GameObject> objectsList;
    public List<GameObject> ennemisList;
    public List<GameObject> teamList;
    int objectIndex = 0;
    int ennemisIndex = 0;
    int teamIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        place = 0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (select == 0)
        {
            transform.position = objectsList[objectIndex].transform.position;
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                objectIndex = (objectIndex - 1);

                if (objectIndex < 0)
                {
                    objectIndex = objectsList.Count - 1;
                }


            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                objectIndex = (objectIndex + 1) % objectsList.Count;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (objectIndex == 0)
                {
                    Debug.Log("1");
                    select = 1;
                }

                if (objectIndex == 1)
                {
                    Debug.Log("2");
                    select = 2;
                }

                if (objectIndex == 2)
                {
                    Debug.Log("3");
                    select = 0;
                }

                if (objectIndex == 3)
                {
                    Debug.Log("4");
                    select = 2;
                }
     
            }
        }
        else if (select == 1)
            {
            transform.position = ennemisList[ennemisIndex].transform.position;
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                ennemisIndex = (ennemisIndex - 1);

                if (ennemisIndex < 0)
                    {
                        ennemisIndex = ennemisList.Count - 1;
                    }


                }

            if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    ennemisIndex = (ennemisIndex + 1) % ennemisList.Count;
                }

            if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (ennemisIndex == 0)
                    {
                        Debug.Log("1");
                        select = 0;
                    }

                    if (ennemisIndex == 1)
                    {
                        Debug.Log("2");
                        select = 0;
                    }

                }
            }

        else if (select == 2)
        {
            transform.position = teamList[teamIndex].transform.position;
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                teamIndex = (teamIndex - 1);

                if (teamIndex < 0)
                {
                    teamIndex = teamList.Count - 1;
                }

            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                teamIndex = (teamIndex + 1) % teamList.Count;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (teamIndex == 0)
                {
                    Debug.Log("1");
                    select = 0;
                }

                if (teamIndex == 1)
                {
                    Debug.Log("2");
                    select = 0;
                }

                if (teamIndex == 2)
                {
                    Debug.Log("3");
                    select = 0;
                }

            }
        }
    }
}


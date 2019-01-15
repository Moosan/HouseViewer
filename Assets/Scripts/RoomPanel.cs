using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class RoomPanel : MonoBehaviour , IPointerClickHandler
{
    //public Transform SetPos;
    //public Transform Player;
    //public GameObject roomObj;
    //public float offsety;
    //private static List<GameObject> objList = new List<GameObject>();
    public string sceneName;
    void Awake()
    {
        //objList.Add(roomObj);
    }
    void Start()
    {

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        MenuManager.menuManager.MenuClose();
        SceneManager.LoadSceneAsync(sceneName);


        /*Player.transform.SetPositionAndRotation(
            SetPos.transform.position+new Vector3(0,offsety,0),
            transform.rotation
            );*/
        //MenuManager.menuManager.MenuClose();
        /*
        foreach (var obj in objList)
        {
            obj.SetActive(false);
        }
        roomObj.SetActive(true);
        */
    }
}

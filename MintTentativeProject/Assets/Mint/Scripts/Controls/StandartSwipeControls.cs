using TMPro;
using UnityEngine;


public delegate void SwipeDetection();

public class StandartSwipeControls : MonoBehaviour
{
    [SerializeField]
    private GameObject controlledOdject;

    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    private Vector2 currentTouchPosition;

    private bool isTouchStopped = false;

    public float swipeRange;
    public float tapRange;

    [SerializeField]
    TextMeshProUGUI Log;


    void Update()
    {
        Swipe();
    }

    public void Swipe()
    {
        
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;

        }else

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currentTouchPosition = Input.GetTouch(0).position;
            
        }else
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            Vector2 distance = currentTouchPosition - startTouchPosition;
            if(!IsTapDetected()) DetectDirection(distance).ToString();
            
        }




    }

    public int DetectDirection(Vector2 distance)
    {

        if (distance.x < -swipeRange)
        {
           if(DataController.CurrentCardId < DataController.CustomerEntitiesLenght) DataController.CurrentCardId++;
            isTouchStopped = true;
        }
        else
        {

            if (distance.x > swipeRange)
            {
                if(DataController.CurrentCardId > 0) DataController.CurrentCardId--;
                isTouchStopped = true;
            }
        }

        return DataController.CurrentCardId;
             
    }



    private bool IsTapDetected()
    {
            endTouchPosition = Input.GetTouch(0).position;

            Vector2 distance = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(distance.x) < tapRange && Mathf.Abs(distance.y) < tapRange)
            {
                return true;
            }
        return false;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class gaze3 : MonoBehaviour {

    public float gazeTime = 2f;
    private float timer =0f;
    private bool gazedAt;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if(gazedAt)
        {
            timer += Time.deltaTime;
            
            if(timer >= gazeTime)
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
                SceneManager.LoadScene("4");
            }
        }
    }
    public void PointerEnter()
    {
        //Debug.Log("enter");
        gazedAt = true;
        transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);

    }

    public void PointerExit()
    {
        timer = 0f;
        gazedAt = false;
        transform.localScale -= new Vector3(0.01F, 0.01F, 0.01F);
    }
}


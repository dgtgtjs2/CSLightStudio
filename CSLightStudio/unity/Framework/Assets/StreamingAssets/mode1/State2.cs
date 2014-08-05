﻿
using System.Collections.Generic;
using UnityEngine;
using System.Text;

class State2: IState
{
    public StateMgr mgr
    {
        get;
        private set;
    }
    GameObject root = null;
    public void OnInit()
    {
        root = GameObject.CreatePrimitive(PrimitiveType.Cube);

        for (int i = 0; i < 10; i++)
        {
            GameObject sub = GameObject.CreatePrimitive(PrimitiveType.Cube);
            sub.transform.parent = root.transform;
            sub.transform.localPosition = new Vector3(i, 0, 0);
            sub.GetComponent("Transform");
        }
    }
    int clicktag = 1;
    public void OnExit()
    {
        Object.Destroy(root);
    }

    public void OnUpdate()
    {
        if (clicktag == 1)
        {

            root.transform.Rotate(Vector3.up, 15.0f);
        }
    }

    public void ClickEvent(int tag)
    {
        clicktag = tag;
    }
}

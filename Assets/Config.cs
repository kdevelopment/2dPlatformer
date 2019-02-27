using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Config : MonoBehaviour
{
    static public Config get() { return mSelf; }

    static private Config mSelf = null;

    public GameObject FireBallPreFab;
    public AudioSource FootSteps;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Assert(mSelf!=null);
        mSelf = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

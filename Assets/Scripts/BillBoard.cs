﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
    public class BillBoard : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            transform.LookAt(Camera.main.transform);
        }
    }
}


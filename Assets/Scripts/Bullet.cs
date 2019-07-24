﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace S3
{
    public class Bullet : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            GameObject hit = collision.gameObject;
            Health health = hit.GetComponent<Health>();

            if (health!=null )
            {
                health.TakeDamage(10);
            }
            Destroy(gameObject);
        }
    }
}


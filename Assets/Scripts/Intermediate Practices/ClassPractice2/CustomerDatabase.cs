using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    [SerializeField]
    public Customers[] customers;

    private void Start()
    {
        customers[0] = new Customers("Aral", 1, 24, "köle", 1, "seks kölesi");
        customers[1] = new Customers("Burak", 2, 25, "cariye", 2, "seks kölesinin iyisi");
        customers[2] = new Customers("Doğan", 3, 26, "porn star", 3, "seks kölesinin en iyisi");
    }
}

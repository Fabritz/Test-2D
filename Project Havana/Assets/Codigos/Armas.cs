using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armas : MonoBehaviour
{
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destruir());
    }

    // Update is called once per frame
    void Update()
    {
        atacar();
        
    }

    void atacar()
    {
        transform.RotateAround(transform.parent.position, new Vector3(0,0,1), velocidad * Time.deltaTime);
    }
    IEnumerator Destruir()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
        print("nooo");
    }
}

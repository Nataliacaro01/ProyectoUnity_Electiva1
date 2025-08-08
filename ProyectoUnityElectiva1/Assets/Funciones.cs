using UnityEngine;

public class Funciones : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject carro;

    public void RotateLeft(){

        carro.transform.Rotate(0.0f, 10.0f, 0.0f, Space.Self);

    }

    public void RotateRight(){

        carro.transform.Rotate(0.0f, -10.0f, 0.0f, Space.Self);

    }

    public void TranslateUp(){

        carro.transform.Translate(Vector3.up * Time.deltaTime * 10, Space.World);

    }

    public void TranslateDown(){

        carro.transform.Translate(Vector3.down * Time.deltaTime * 10, Space.World);

    }

    public void TranslateLeft(){

        carro.transform.Translate(Vector3.left * Time.deltaTime * 10, Space.World);

    }

    public void TranslateRight(){

        carro.transform.Translate(Vector3.right * Time.deltaTime * 10, Space.World);
        
    }

    public void Scale(float magnitud){

        Vector3 changerscale = new Vector3(magnitud, magnitud, magnitud);

        carro.transform.localScale += changerscale;

    }


}

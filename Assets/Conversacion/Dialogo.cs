using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{

    [System.Serializable]
    public struct Charla{
        public string nombre;
        public string comentario;
        public Sprite imagen;
    }

    [SerializeField] List<Charla> charla;

    [SerializeField] TextMeshProUGUI nombre;
    [SerializeField] TextMeshProUGUI comentario;
    [SerializeField] Image foto;

    int contador = 0;

    void actualizaDialogo(){
        nombre.text = charla[contador].nombre;
        comentario.text = charla[contador].comentario;
        foto.sprite = charla[contador].imagen;
    }
    void Start()
    {
        contador = 0;
        actualizaDialogo();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            contador++;
            contador%=charla.Count;
            actualizaDialogo();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuObject : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI priceText;
    [SerializeField] UnityEngine.UI.Image image;
    public Producto producto;
    void Start()
    {
        nameText.text = producto.Nombre;
        priceText.text = "$" + producto.Precio.ToString();
        image.sprite = producto.Image;
    }

    public void OnClick()
    {
        MenuManager.SetProducto(producto);
    }
}

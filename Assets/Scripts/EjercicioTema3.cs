using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioTema3 : MonoBehaviour
{
    public int diasEstadia;
    public string codigoAnimal;
    int AlimentoTotal, alimentoPorDia, costoAlimento;
    const int precioAlimento = 80;
    // Start is called before the first frame update
    void Start()
    {
        if(diasEstadia > 2 && (codigoAnimal == "PP" || codigoAnimal == "G" || codigoAnimal == "PG"))
        {
            switch (codigoAnimal)
            {
                case "PP": alimentoPorDia = 400; break;
                case "PG": alimentoPorDia = 700; break;
                case "G": alimentoPorDia = 300; break;
            }
            AlimentoTotal = alimentoPorDia * diasEstadia;
            costoAlimento = 80 * (AlimentoTotal / 100);
            Debug.Log("Para ese período se necesitan " + AlimentoTotal + "gramos de alimento, el costo de esa cantidad es $" + costoAlimento);
        }
        else
        {
            Debug.Log("Los datos ingresados no son validos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

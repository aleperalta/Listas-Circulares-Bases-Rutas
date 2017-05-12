using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ape_rutas
{
    class Ruta
    {
        Base primero, ultimo, temp, encontrado;

        public Ruta()
        {
            primero = null;
        }

        public void agregar(Base nuevaB)
        {
            if (primero == null)
            {
                primero = nuevaB;
                ultimo = nuevaB;
            } else
            {
                ultimo.siguiente = nuevaB;
                nuevaB.anterior = ultimo;
                nuevaB.siguiente = primero;
                ultimo = nuevaB;
                primero.anterior = ultimo;
            }
        }

        public void agregarEnInicio(Base agregarEnInicioB)
        {
            if (primero == null)
            {
                primero = agregarEnInicioB;
                ultimo = agregarEnInicioB;
            }
            else
            {
                primero.anterior = agregarEnInicioB;
                ultimo.siguiente = agregarEnInicioB;
                agregarEnInicioB.siguiente = primero;
                agregarEnInicioB.anterior = ultimo;
                primero = agregarEnInicioB;
            }
        }

        public Base buscar(string nombreB)
        {
            temp = primero;
            encontrado = null;

            if (ultimo.nombre == nombreB)
                encontrado = ultimo;
            else
                while (encontrado == null && temp != primero.anterior)
                    if (temp.nombre == nombreB)
                        encontrado = temp;
                    else
                        temp = temp.siguiente;

            return encontrado;
        }

        public bool eliminar(string nombreB)
        {
            if (buscar(nombreB) != null)
            {
                if (encontrado == primero)
                    eliminarPrimero();
                else if (encontrado == ultimo)
                    eliminarUltimo();
                else
                {
                    encontrado.anterior.siguiente = encontrado.siguiente;
                    encontrado.siguiente.anterior = encontrado.anterior;
                }

                return true;
            }
            else
                return false;
        }

        public bool eliminarPrimero()
        {
            if (primero == null)
                return false;
            else
            {
                if (ultimo == primero)
                {
                    primero = null;
                    ultimo = null;
                }
                else
                {
                    primero = primero.siguiente;
                    primero.anterior = ultimo;
                    ultimo.siguiente = primero;
                }
                return true;
            }
        }

        public bool eliminarUltimo()
        {
            if (primero == null)
                return false;
            else
            {
                if (ultimo == primero)
                {
                    primero = null;
                    ultimo = null;
                } else { 
                    ultimo = ultimo.anterior;
                    ultimo.siguiente = primero;
                    primero.anterior = ultimo;
                }
                return true;
            }
        }

        public bool insertarDespuesDe(string nombreBAnt, Base nuevaB)
        {
            if (buscar(nombreBAnt) != null)
            {
                nuevaB.siguiente = encontrado.siguiente;
                nuevaB.anterior = encontrado;
                encontrado.siguiente.anterior = nuevaB;
                encontrado.siguiente = nuevaB;

                if (encontrado == ultimo)
                    ultimo = nuevaB;

                return true;
            }
            else
                return false;
        }

        public string recorrido(string nombreB, DateTime horaInicio, DateTime horaFin)
        {
            if (buscar(nombreB) == null)
                return "No se encontró la base";
            else
            {
                DateTime horaActual = horaInicio;
                string recorrido = "";
                temp = encontrado;

                while (temp.siguiente != encontrado)
                {
                    recorrido += temp.nombre.ToString() + "         ";
                    temp = temp.siguiente;
                }

                if (temp != null)
                    recorrido += temp.nombre.ToString() + Environment.NewLine;

                temp = encontrado;

                while (horaActual <= horaFin)
                {
                    temp = temp.siguiente;
                    recorrido += horaActual.Hour.ToString() + ":" + horaActual.Minute.ToString() + "        ";
                    horaActual = horaActual.AddMinutes(temp.minutos);

                    if (temp == encontrado)
                        recorrido += Environment.NewLine;
                }

                return recorrido;
            }
        }

        public string mostrar()
        {
            string vBase = "";
            temp = primero;

            while (temp != ultimo)
            {
                vBase += temp.ToString() + Environment.NewLine;
                temp = temp.siguiente;
            }

            if (temp != null)
                vBase += temp.ToString() + Environment.NewLine;

            return vBase;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_EDI.Models
{
    public class Ordenamiento
    {
        public List<Client> Lista;

        public Ordenamiento(List<Client> Clientlist)
        {
            Lista = Clientlist;
            selectionsort(Lista.Count);
        }


        void swap(Client a, Client b, int i, int medium)
        {

            Lista[i] = b;
            Lista[medium] = a;
        }

        void selectionsort(int size)
        {
            for (int i = 0; i < size - 1; i++)
            {
                int medium = i;
                for (int j = i + 1; j < size; j++)
                {
                    string Posicion_j = Lista[j].Name.ToLower();
                    string Posicion_medium = Lista[medium].Name.ToLower();
                    if (Convert.ToChar(Posicion_medium.Substring(0, 1)) > Convert.ToChar(Posicion_j.Substring(0, 1)))
                    {
                        medium = j;
                    }
                    else if((Convert.ToChar(Posicion_medium.Substring(0, 1)) == Convert.ToChar(Posicion_j.Substring(0, 1))) && Posicion_j != Posicion_medium)
                    {
                        int longitud;
                        if(Posicion_j.Length < Posicion_medium.Length)
                        {
                            longitud = Posicion_j.Length;
                        }
                        else
                        {
                            longitud = Posicion_medium.Length;
                        }
                        for (int k = 0; k  < longitud;k++)
                        {
                            if (Convert.ToChar(Posicion_medium.Substring(k, 1)) > Convert.ToChar(Posicion_j.Substring(k, 1)))
                            {
                                swap(Lista.ElementAt(i), Lista.ElementAt(j), i, j);
                                break;
                            }
                            else if(Convert.ToChar(Posicion_medium.Substring(k, 1)) < Convert.ToChar(Posicion_j.Substring(k, 1)))
                            {
                                break;
                            }
                        }
                    }
                }
                if(i != medium) 
                { 
                    swap(Lista.ElementAt(i), Lista.ElementAt(medium), i, medium);
                }
            }
        }

        static int Ascendente(string x, string y)
        {
            int value = string.Compare(x, y);
            return value;
        }

        public List<Client> retornar()
        {
            return Lista;
        }
    }
}

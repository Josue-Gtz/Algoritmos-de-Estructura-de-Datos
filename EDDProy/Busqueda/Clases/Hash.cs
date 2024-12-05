using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Busqueda.Clases
{
    public class Hash
    {
        private const int TAMANIO = 100; 
        private int[] claves;
        private string[] valores;

        public Hash()
        {
            claves = new int[TAMANIO];
            valores = new string[TAMANIO];
            for (int i = 0; i < TAMANIO; i++)
            {
                claves[i] = -1; 
            }
        }

        
        private int FuncionHash(int clave, int tamanioTabla)
        {
            return clave % tamanioTabla;
        }

        
        public  int FuncionHashPolinomial(string clave, int tamanioTabla)
        {
            const int basePolinomial = 31; 
            int hash = 0;

            for (int i = 0; i < clave.Length; i++)
            {
                hash = (hash * basePolinomial + clave[i]) % tamanioTabla;
            }

            return Math.Abs(hash);
        }

        public long FuncionHashAvanzada(uint clave, int tamanioTabla)
        {
            const int primo = 31; 
            const uint mezclaBits = 0x9E3779B9; 

            uint hash = clave;

            
            hash ^= (hash >> 16);         
            hash *= mezclaBits;          
            hash ^= (hash >> 13);         
            hash *= primo;               
            hash ^= (hash >> 16);         

            return Math.Abs(hash) % tamanioTabla;
        }


        public void Insertar(string valor)
        {
            int clave = FuncionHashPolinomial(valor, TAMANIO);
            int indice = clave % TAMANIO;
            while (claves[indice] != -1) 
            {
                indice = (indice + 1) % TAMANIO;
            }
            claves[indice] = clave;
            valores[indice] = valor;
        }

        public string Buscar(int clave)
        {
            int indice = clave % TAMANIO;
            int inicio = indice;

            while (claves[indice] != -1)
            {
                if (claves[indice] == clave)
                {
                    return valores[indice];
                }
                indice = (indice + 1) % TAMANIO;

                if (indice == inicio)
                {
                    break;
                }
            }
            return null; 
        }
        public void LimpiarTabla()
        {
            for (int i = 0; i < TAMANIO; i++)
            {
                claves[i] = -1;
                valores[i] = null;
            }
        }
    }

}


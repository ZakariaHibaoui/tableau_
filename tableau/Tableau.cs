using System;
using System.Collections.Generic;
using System.Text;

namespace tableau
{
    class Tableau
    {
        public int dim;
        public int[] tabl1;
        public string[] tabl2;

        //constructeur
        public Tableau(int dim)
        {
            this.dim = dim;
            tabl1 = new int[dim];
            tabl2 = new string[dim];
        }

        //insertion

        public int Insertion (int index,int valeur)
        {
           if (index < dim)
            {
                tabl1[index] = valeur;
                return 1;
            }
           else
            {
                return 0;
            }
        }

        //recherche
        public int Recherche(ref int[]tabl1, int valeur)
        {
            int h = 0;
            for(int i = 0; i < dim ; i++)
            {
                if (tabl1[i]==valeur)
                {
                    h = 1;
                    break;

                }

            }
            return h;

        }

        //suppression
        public int Suppression(ref int[] tabl1,int index)
        {
            int v = 0;
            if(index < dim && index >= 0)
            {
                for (int i=index;i <tabl1.Length;i++)
                {
                    tabl1[i] = tabl1[i + 1];
                    v = 1;
                    break;
                }
                return v;
            }
            else
            {
                return v;
            }
        }

        //triage

        public int Triage(ref int[] tabl1)
        {
            int t,v;
            for(int i = 0; i < tabl1.Length; i++)
            {
                for(int j = 0; j < tabl1.Length; j++)
                {
                    if (tabl1[j] > tabl1[j + 1])
                    {
                        t = tabl1[j + 1];
                        tabl1[j + 1] = tabl1[j];
                        tabl1[j] = t;
                    }
                }

                      
            }
            v = 1;
            return v;

        }

        //symetrie
        public int Symetrie(ref int[] tabl1)
        {
            int i = 0;
            for (i = 0; i < dim / 2; i++) 
            {
                if (tabl1[i] != tabl1[i - 1 - i])
                {
                    return 0;

                }
            }
            return 1;
        }

        //concatenation
        public int Concatenation (ref int[] tabl1)
        {
            int[] tabl3 = { 1, 2, 3 };
            int taille_tableR = tabl1.Length + tabl3.Length;
            int[] tableR = new int[taille_tableR];
            int i = 0;
            foreach (int s in tabl1)
            {
                tableR[i] = s;
                i++;

            }
            foreach(int s in tabl3)
            {
                tableR[i] = s;
                i++;

            }
            return tableR[i];

        }

        //fusion

        public int Fusionner(ref int[] tabl1)
        {
            int[] tabl3 = { 1, 2, 3 };
            int i1 = 0, i2 = 0, i = 0;
            int z;
            int[] tableR = new int[z];
            for (; i1 < tabl1.Length && i2 < tabl3.Length; ++i)
                if (tabl1[i1] < tabl3[i2])
                {
                    tableR[i] = tabl1[i1];
                    ++i1;
                }
                else
                {
                    tableR[i] = tabl3[i2];
                    ++i2;
                }
            for (; i1 < tabl1.Length; ++i, ++i1)
                tableR[i] = tabl1[i1];
            for (; i2 < tabl3.Length; ++i, ++i2)
            {
                tableR[i] = tabl3[i2];
            }

            return tableR[z];
        }


            //affichage
            public void affichage()
        {
            foreach(int n in tabl1)
            {
                Console.WriteLine(n);
            }
        }





    }
}

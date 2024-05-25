class Program{
    public static void merge(int[] A,int deb,int mil,int fin){
        int n1= mil-deb+1;
        int n2= fin -mil;
        int[] left = new int[n1];
        int[] rigth = new int[n2];
        Array.Copy(A,deb,left,0,n1);//(tablau_origin ,index_debut_origin,destinataire,0,n1)
        Array.Copy(A,mil+1,rigth,0,n2);
        int i=0;
        int j=0;
        int k=deb;
        while(i<n1 && j<n2){
            if(left[i]<=rigth[j]){
                A[k]=left[i];
                i++;
            }else{
                A[k]=rigth[j];
                j++;
            }
            k++;
        }

        //elementy restant dans left
        while(i<n1){
            A[k]=left[i];
            i++;
            k++;
        }
        while(j<n2){
            A[k]=rigth[j];
            j++;
            k++;
        }

    }
    public static void mergeSort(int[] A,int deb,int fin){
        int milieu;
        if(deb<fin){
            milieu = (deb+fin)/2;
            mergeSort(A,deb,milieu);
            mergeSort(A,milieu+1,fin);
            merge(A,deb,milieu,fin);
        }
    }

    public static void PrintArray(int[] A){
        foreach(int itm in A){
            Console.Write(itm+" ");
        }
        Console.WriteLine();
    }
    public static void Main(string[] args){
        int[] table = {38,27,43,3,9,82,10};
        Console.WriteLine("Tableau original:\n");
        PrintArray(table);
        Console.WriteLine("Tableau apres tri:\n");
        mergeSort(table,0,table.Length-1);
        PrintArray(table);

    }
}
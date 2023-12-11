using System;
public class Program{
    static void Main(){
        int rotate = 3;
        int[] arr = new int[]{10,20,30,40,50};
        foreach(int i in arr){
            Console.Write(i+ " ");
        }
        Console.WriteLine();
        int n = arr.Length;
        for(int count = 0;count<1;count++ ){
            int temp = arr[0];
            for(int i=0;i<n;i++){
                if(i == n-1){
                    arr[i] = temp;
                }else{
                    arr[i] = arr[i+1];   
                }
            }
        }
        foreach(int i in arr){
            Console.Write(i+ " ");
        }
    }
}
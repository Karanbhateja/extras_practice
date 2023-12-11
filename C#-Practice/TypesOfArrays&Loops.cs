using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
        
// ------------------- Single Dimension Array -------------------------------
// 
        int[] arr = new int[3]; // Declaration
        arr[0] = 10; // Initialization
        arr[1] = 20;
        arr[2] = 30;
        
        int[] arr2 = new int[3]{1,2,3}; // Declaration and Initialisation at same time
        
        int[] arr3 = new int[] {4,5,6}; // Without sieze

    // FOR LOOP ---------------------------------------------- 
        for(int i=0; i<arr.Length; i++){
            Console.Write(arr[i]+ " ");
        }
        
        Console.WriteLine();
        
    // FOR WACH LOOP ------------------------------------------------
        foreach(int item in arr2){
            Console.Write(item+ " ");
        }
        
        Console.WriteLine();
        
    // WHILW LOOP -----------------------------------------------------------
        int j = 0;
        while(j<arr3.Length){
            Console.Write(arr3[j] + " ");
            j++;
        }
// ----------------------------------------------------------------------------------
        
        Console.WriteLine();
        
    // ----------------------- 2-Dimensional Array -------------------------
        
        int[,] twodarr = new int[2,2];
        twodarr[0,0] = 0;  //    | 0  1  |
        twodarr[0,1] = 1;  //    | 2  3  |
        twodarr[1,0] = 2;
        twodarr[1,1] = 3;
        
        int[,] arr2d = new int[3,3]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] arr2dwithoursize = new int[,]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        
        for(int x=0; x<twodarr.GetLength(0); x++){
            for(int y=0; y<twodarr.GetLength(1); y++){
                Console.Write(twodarr[x,y]+ " ");
            }
            Console.WriteLine();
        }
        
        // ------------------------------------------- JAGGED Arrays ----------------------------------------------
        int[][] jaggedarr = new int[2][];
        jaggedarr[0] = new int[] {1,2};
        jaggedarr[1] = new int[] {3,4,5};
        
        for(int h=0; h<jaggedarr.Length; h++){
            for(int k =0; k<jaggedarr[h].Length; k++){
                Console.Write(jaggedarr[h][k] + " ");
            }
            Console.WriteLine();
        }
    }
}

// 8. Concept to illustrate overloading an indexer

using System;
class test{
// Instances of a class Treated as Array
    int id;
    string name;
    string[] arr = new string[10];

// Parameterised Constructor
    public test(int id, string name){
        this.id = id;
        this.name = name;
    }

// Indexer 
    public string this[int index]{
        get { return arr[index]; }
        set { arr[index] = value; }
    }

// Indexer Overloading
    public object this[char c]{
        get{ 
            if (c == 'a'){ return (int)id; }
            else if (c == 'b'){ return name; }
            else{ return null; }
        }
        set{
            if (c == 'a'){ id = (int)value; }
            else if (c == 'b'){ name = (string)value; }
        }
    }

// Main
    public static void Main(){
        test t1 = new test(1, "world");
        t1[0] = "value1";
        t1[1] = "value2";
        Console.WriteLine(t1[0]);
        Console.WriteLine(t1[1]);
        
        t1['a'] = 2;
        t1['b'] = "hello";
        Console.WriteLine(t1['a']);
        Console.WriteLine(t1['b']);
    }
}


// using System;
// class test{
//     string[] arr =  new string[10];

//     public string this[int id]{
//         get{ return arr[id]; }
//         set{ arr[id] = value; }
//     }
//     public static void Main(){
//         test t1 = new test();
//         t1[0] = "value1";
//         t1[1] = "value2";
//         Console.WriteLine(t1[0]);
//         Console.WriteLine(t1[1]);
//     }
// }

using System;

class Program{

    static void Main(string [] args){

        int i = 1;
        while(i <= 3){
            int j = 1;
            while(j <= 3){
                System.Console.WriteLine(i + " " + j);
                j++;
            }
            i++;
        }

    }
}

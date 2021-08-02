/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_day1_inputoutput;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_day1_InputOutput {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        System.out.println("Hello world!");
        
        
        // int - vesels skaitlis
        // double, float - skaitlis ar komatu
        // String - simbolu virkne
        // char - simbols
        // boolean - true vai false
        
        int a = 10;
        int b = 12;
        int c = a + b + 12;
        
        System.out.println(a);
        a = 33;
        System.out.println(a+b);
        String virkne = "Parauga teksts";
        String summetais = virkne + ", cits parauga teksts";
        System.out.println(virkne);
        System.out.println(summetais);
        
        Scanner sc = new Scanner (System.in);
        System.out.println("Ievadi vardu!");
        String input = sc.nextLine ();
        System.out.println(input);
        
        Scanner sc2 = new Scanner (System.in);
        System.out.println ("Ievadi uzvardu!");
        String input2 = sc.nextLine ();
        System.out.println(input2);
        
        Scanner sc3 = new Scanner (System.in);
        System.out.println("Cik Tev gadu?");
        int vecums = sc.nextInt ();
        System.out.println(input + " " + input2 + " ," + vecums + " gadi");
        
        // sout and spiezam tab = System.out.println
    }
    
}

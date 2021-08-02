/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_faktorialis_20_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Faktorialis_20_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        Faktorialis();
        
        Faktorialis2();

    }

    static void Faktorialis() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi jebkuru veselo skaitli un tiks aprekinats si skaitla faktorialis");

        int F = sc.nextInt();

        int x = 1;

        for (int i = 1; i <= F; i++) {

            x = x * i;

        }
        
        System.out.println(x);
        
    }

    static void Faktorialis2() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi jebkuru veselo skaitli un tiks aprekinats si skaitla faktorialis");

        int F = sc.nextInt();

        int n = 1;

        for (int i = 1; i <= F && n>=1; i++) {

            n = n * (F-(i-1));

        }
        
        System.out.println(n);
        
    }
    
}

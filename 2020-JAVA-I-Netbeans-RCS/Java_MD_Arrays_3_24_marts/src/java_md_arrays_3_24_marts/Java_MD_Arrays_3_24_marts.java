/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_arrays_3_24_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Arrays_3_24_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        ArrayCHANGE();

    }

    static void ArraySUM() {

        Scanner sc = new Scanner(System.in);

        int[] a = new int[4];

        int sum = 0;

        for (int i = 0; i < a.length; i++) {

            System.out.println("Ievadi veselo skaitli!");

            a[i] = sc.nextInt();

            sum = sum + a[i];

        }

        System.out.println("Tevis ievadito skaitlu summa ir " + sum);

    }

    static void ArrayCHANGE() {

        Scanner sc = new Scanner(System.in);

        int[] a = new int[4];

        for (int i = 0; i < a.length; i++) {

            System.out.println("Ievadi veselo skaitli!");

            a[i] = sc.nextInt();

        }

        int[] b = new int[a.length];

        for (int i = 0; i < b.length; i++) {

            b[i] = a[a.length - 1 - i];

             System.out.print(b[i] + " ");

        }

    }

}

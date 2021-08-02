/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_for_restites_20_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_FOR_Restites_20_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        Restites2();

    }

    static void Restites() {

        System.out.println("Ievadi, cik restites tu velies, lai tiek izvaditas");

        Scanner sc = new Scanner(System.in);

        int a = sc.nextInt();

        String R = "";

        if (a > 0) {

            for (int i = 1; i <= a; i++) {

                R = R + "#";

            }

            System.out.println(R);

        } else {

            System.out.println("Tu ievadiji skaitli vienadu ar 0 vai negativu");

        }

    }

    static void Restites2() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi, cik restites tu velies, lai tiek izvaditas");

        int b = sc.nextInt();

        System.out.println("Ievadi, cik kolonnas ar restitem tu velies, lai tiek izvaditas");

        int c = sc.nextInt();

        String R = "";

        if (b > 0) {

            for (int i = 1; i <= b; i++) {

                R = R + "#";

            }
        } else {
            System.out.println("Tu ievadiji skaitli vienadu ar 0 vai negativu");
        }

        if (c > 0) {

            for (int j = 1; j <= c; j++) {

                System.out.println(R);
            }

        } else {

            System.out.println("Tu ievadiji skaitli vienadu ar 0 vai negativu");

        }

    }
}

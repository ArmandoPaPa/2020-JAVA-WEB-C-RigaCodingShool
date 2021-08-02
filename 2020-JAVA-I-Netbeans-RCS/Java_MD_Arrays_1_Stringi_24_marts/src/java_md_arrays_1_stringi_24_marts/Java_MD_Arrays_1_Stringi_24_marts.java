/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_arrays_1_stringi_24_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Arrays_1_Stringi_24_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        Arrays1();

    }

    static void Arrays1() {

        String[] a = new String[3];

        Scanner sc = new Scanner(System.in);

        for (int i = 0; i < a.length; i++) {

            System.out.println("Ievadi Stringu");
            a[i] = sc.next();

        }

        for (int i = 0; i < a.length; i++) {

            System.out.print(a[i] + " ");

        }
    }

}

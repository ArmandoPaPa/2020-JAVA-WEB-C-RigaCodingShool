/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_arrays_4_parask_26_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Arrays_4_ParaSk_26_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        ArraysParaSkaitli();

    }

    static void ArraysParaSkaitli() {

        Scanner sc = new Scanner(System.in);

        int[] a = new int[10];

        for (int i = 0; i < a.length; i++) {

            System.out.println("Ievadi masiva skaitli!");

            a[i] = sc.nextInt();

        }

        for (int i = 0; i < a.length; i++) {

            if (a[i] % 2 == 0) {

                System.out.print(a[i] + " ");
            }

        }

    }

}

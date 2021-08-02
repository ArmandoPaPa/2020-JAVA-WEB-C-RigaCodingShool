/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_arrays_6_parasumma_26_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Arrays_6_ParaSUMMA_26_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        SkaitluPARAsumma();

    }

    static void SkaitluPARAsumma() {

        Scanner sc = new Scanner(System.in);

        int[] a = new int[10];

        int summa = Integer.MIN_VALUE;

        int x = 0;
        int y = 0;

        for (int i = 0; i < a.length; i++) {

            System.out.println("Ievadi masiva skaitli!");

            a[i] = sc.nextInt();

        }

        for (int i = 0; i < a.length - 1; i++) {

            if (summa < a[i] + a[i + 1]) {
                summa = a[i] + a[i + 1];
                x = a[i];
                y = a[i + 1];

            }

            System.out.println("Lielaka summa ir " + summa);
            
            System.out.println("Skaitlu summu veido skaitli " + x + " un " + y);
            
        }

    }

}

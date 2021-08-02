/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_arrays_2_24_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Arrays_2_24_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        IntArrays();

    }

    static void IntArrays() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi Array /masiva/ garumu");

        int ML = sc.nextInt();
        
        if (ML < 1) {
            return;
        }
        
        int[] x = new int[ML];

        for (int i = 0; i < x.length; i++) {

            System.out.println("Ievadi veselo skaitli!");

            x[i] = sc.nextInt();

        }

        for (int i = 0; i < x.length; i++) {

            System.out.print(x[i] + " ");

        }

    }

}

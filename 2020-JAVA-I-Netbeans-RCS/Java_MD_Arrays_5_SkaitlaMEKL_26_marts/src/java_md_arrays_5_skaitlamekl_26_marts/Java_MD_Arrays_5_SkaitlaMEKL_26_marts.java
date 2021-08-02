/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_arrays_5_skaitlamekl_26_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Arrays_5_SkaitlaMEKL_26_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        ArraysSkaitlaMEKL();

    }

    static void ArraysSkaitlaMEKL() {

        Scanner sc = new Scanner(System.in);

        int[] a = new int[10];

        for (int i = 0; i < a.length; i++) {

            System.out.println("Ievadi masiva skaitli!");

            a[i] = sc.nextInt();

        }

        System.out.println("Kadu skaitli Tu velies atrast - mes izvadisim ta vietu masiva!");

        int meklejamais = sc.nextInt();
        
        System.out.println("Tevis mekletais skaitlis " + meklejamais 
                + " ir sekojosas pozicijas... ");

        for (int i = 0; i < a.length; i++) {

            if (a[i] == meklejamais) {

                System.out.print(i + " ");
            }

        }

    }

}

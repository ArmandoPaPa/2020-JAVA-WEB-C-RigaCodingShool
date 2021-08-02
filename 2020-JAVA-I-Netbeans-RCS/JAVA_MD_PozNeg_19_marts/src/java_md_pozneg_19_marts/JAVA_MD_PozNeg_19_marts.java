/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_pozneg_19_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class JAVA_MD_PozNeg_19_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        PozNeg();

    }

    static void PozNeg() {

        Scanner sc = new Scanner(System.in);

        int poz = 0;
        int neg = 0;
        int zero = 0;

        System.out.println("Tagat Tev vajadzes ievadit 10 jebkadus skaitlus");

        for (int i = 0; i < 10; i++) {

            System.out.println("Ievadi jebkuru skaitli");
            double a = sc.nextDouble();

            if (a > 0 && a != 0) {
                poz = poz + 1;
            } else if (a < 0 && a != 0) {
                neg = neg + 1;
            } else {
                zero = zero + 1;
            }

        }

        System.out.println("Tu esi ievadijis " + poz + " pozitivus skaitlus, "
                + neg + " negativus skaitlus, un nulli esi ievadijis " + zero + " reizes.");

    }

}

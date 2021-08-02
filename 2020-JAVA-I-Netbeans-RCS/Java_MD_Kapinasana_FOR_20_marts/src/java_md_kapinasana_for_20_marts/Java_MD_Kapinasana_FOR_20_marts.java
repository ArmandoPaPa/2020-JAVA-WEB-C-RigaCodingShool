/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_kapinasana_for_20_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Kapinasana_FOR_20_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi BAZI");
        int b = sc.nextInt();

        System.out.println("Ievadi KAPINATAJU");
        int k = sc.nextInt();

        System.out.println("Tevis ievadita skaitla - " + b + " kapinasana - " + k + " pakape ir = "
                + Kapinasana(b, k));

    }

    static int Kapinasana(int b, int k) {

        int rez = 1;

        for (int i = 1; i <= k; i++) {

            rez = rez * b;
        }

        return rez;

    }

}

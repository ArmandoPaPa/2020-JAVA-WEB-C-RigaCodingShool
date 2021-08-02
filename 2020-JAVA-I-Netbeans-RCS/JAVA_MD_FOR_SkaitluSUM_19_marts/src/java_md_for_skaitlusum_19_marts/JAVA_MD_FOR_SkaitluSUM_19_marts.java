/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_for_skaitlusum_19_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class JAVA_MD_FOR_SkaitluSUM_19_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        System.out.println("Nakosaja uzdevuma Tev vajadzes ievadit 5 jebkadus skaitlus");

        SUM();

    }

    static void SUM() {

        Scanner sc = new Scanner(System.in);
        double b = 0;

        for (int i = 0; i < 5; i++) {
            System.out.println("Ievadi skaitli");

            double a = sc.nextDouble();

            b = b + a;

        }

        System.out.println("Tevis ievadito 5 skaitlu summas ir " + b);
    }
}

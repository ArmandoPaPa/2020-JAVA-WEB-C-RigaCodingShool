/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_stringasummesana_16marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_StringaSummesana_16marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        System.out.println("MD - String summesana");

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi Stringu - 1");
        String a = sc.nextLine();

        System.out.println("Ievadi Stringu - 2");
        String b = sc.nextLine();

        System.out.println("Ievadi Stringu - 3");
        String c = sc.nextLine();

        String sum = Summesana(a, b, c);
        System.out.println(sum);

        String sum2 = Summesana(sum, sum, sum);
        System.out.println(sum2);

    }

    static String Summesana(String a, String b, String c) {

        return a + b + c;

    }

}

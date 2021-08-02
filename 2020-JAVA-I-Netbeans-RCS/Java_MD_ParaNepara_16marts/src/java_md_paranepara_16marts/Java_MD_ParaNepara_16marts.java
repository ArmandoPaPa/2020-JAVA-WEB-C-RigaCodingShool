/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_paranepara_16marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_ParaNepara_16marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        System.out.println("Parbaudisim, vai Tevis ievaditais skaitlis ir para vai nepara");

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi skaitli");
        Double a = sc.nextDouble();

        if (a % 2 == 0 && a != 0) {
            System.out.println("Tevis ievaditais skaitlis ir PARA");
        } else if (a == 0) {
            System.out.println("Tevis ievaditais skaitlis ir NULLE");
        } else {
            System.out.println("Tevis ievaditais skaitlis ir NEPARA");
        }

    }

}

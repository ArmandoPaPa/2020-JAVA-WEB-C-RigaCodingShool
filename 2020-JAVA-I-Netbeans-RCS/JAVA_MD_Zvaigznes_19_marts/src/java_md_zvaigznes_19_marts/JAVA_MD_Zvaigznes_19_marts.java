/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_zvaigznes_19_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class JAVA_MD_Zvaigznes_19_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        ZV();

    }

    static void ZV() {

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi Stringu");
        String a = sc.nextLine();
        String b = a;

        for (int i = 0; i < 4; i++) {

            a = b+a;

            System.out.println(a);

        }

    }

}

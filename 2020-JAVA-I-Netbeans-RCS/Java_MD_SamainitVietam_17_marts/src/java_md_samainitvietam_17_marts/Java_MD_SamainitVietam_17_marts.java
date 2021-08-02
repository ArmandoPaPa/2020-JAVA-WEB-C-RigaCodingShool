/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_samainitvietam_17_marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_SamainitVietam_17_marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        
        SamainitVietam ();

    }

    static void SamainitVietam() {

        System.out.println("Ievadi 2 Mainigos un tie tiks samainiti vietam!");

        Scanner sc = new Scanner(System.in);

        System.out.println("Ievadi 1.mainigo");
        String a = sc.nextLine();
        
        System.out.println("Ievadi 2.mainigo");
        String b = sc.nextLine();
        
        String c = a;
        a = b;
        
        System.out.println (a+c);
        
    }
}

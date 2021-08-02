/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jav_md_stringagarums_16marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Jav_MD_StringaGarums_16marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        System.out.println("Ievadi String - jebkuru vardu");

        Scanner sc = new Scanner(System.in);
        String a = sc.nextLine();

        StringGarums(a);

    }

    static void StringGarums(String a) {

        System.out.println("Tevis ievadita String - varda - garums ir ");
        int b = a.length();
        
        System.out.println(b);

    }

}

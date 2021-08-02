/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package java_md_perimetrs_16marts;

import java.util.Scanner;

/**
 *
 * @author blumb
 */
public class Java_MD_Perimetrs_16marts {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here

        System.out.println("Uzdevums - ievadit tris tristura malu garumus un tiks aprekinats perimetrs!");
        
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Ievadi 1.malas garumu");
        Double a = sc.nextDouble();
        
        System.out.println("Ievadi 2.malas garumu");
        Double b = sc.nextDouble();
        
        System.out.println("Ievadi 3.malas garumu");
        Double c = sc.nextDouble();
        
        Double PER = Perimetrs (a, b, c);
        
        System.out.println("Tristura perimetrs ir " + PER);
        
    }

    static Double Perimetrs(Double a, Double b, Double c) {

        return a + b + c;
    }

}

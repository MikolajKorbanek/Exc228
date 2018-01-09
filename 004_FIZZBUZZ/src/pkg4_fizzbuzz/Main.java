/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg4_fizzbuzz;

/**
 *
 * @author mixer
 */
public class Main {

    
    public static void main(String[] args) {
        for(int i=1;i<=100;i++){
            if(i%5==0 && i%3==0){
                System.out.println(i+". FIZZ-BUZZ");
            }else if(i%5==0){
                System.out.println(i+". BUZZ");
            }else if(i%3==0){
                System.out.println(i+". FIZZ");
            }else{
                System.out.println(""+i+".");
            } 
        }
    }  
}

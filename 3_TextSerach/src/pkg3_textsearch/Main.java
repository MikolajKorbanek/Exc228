/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pkg3_textsearch;
//21:20 28.11.2017 - 25min
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.JTextField;

/**
 *
 * @author mixer
 */
public class Main extends JFrame{
    static String TEXT ="",TEXT_TO_SEARCH="",LINE;
    static FileReader FR;
    static BufferedReader BR;
    JTextArea textArea;
    JButton search;
    JTextField textToFind;
    
    public Main(){
        super("SEARCH");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());
        textArea = new JTextArea(10, 50);
        search = new JButton("Search");
        textToFind = new JTextField(15);
        textArea.setLineWrap(true);
        JScrollPane sp = new JScrollPane(textArea);
        READ();
        textArea.setText(TEXT);
        search.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                TEXT_TO_SEARCH = textToFind.getText();
                System.out.println(""+countNumberOfsearchText());
            }
        });
        add(textToFind);
        add(search);
        add(sp);
        
        setSize(600,250);
        setVisible(true);
        
    }
    public static void main(String[] args) {
        new Main();
    }
    
    public static int countNumberOfsearchText(){
        int count = 0;
        
        for(int i =0; i < TEXT.length()-TEXT_TO_SEARCH.length();i++){
            if(TEXT.substring(i, i+TEXT_TO_SEARCH.length()).equalsIgnoreCase(TEXT_TO_SEARCH)){
                count++;
            }
        }
        return count;
    }
    
    public static void READ() {
        try{
            FR = new FileReader("text.txt");
            BR = new BufferedReader(FR);
            
            do{
                LINE = BR.readLine();
                TEXT += LINE;
            }while(LINE != null);
            
        } catch(IOException e){
            System.err.println(e.getMessage() + "ERROR File.READ");
        } finally { 
            try {
                if(BR != null)BR.close();
                if(FR != null)FR.close();
            }catch(IOException e){
               System.err.println(e.getMessage() + "ERROR File.READ"); 
            }
      } 
    }
}

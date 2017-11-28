package pkg2_slidepuzzle;

import java.awt.Color;
import java.awt.GridLayout;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.util.Random;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.SwingConstants;

public class gameField extends JPanel implements MouseListener{
    
    static JLabel[] puzzlePart = new JLabel[16];
    
    public gameField(){
        setLayout(new GridLayout(4,4,5,5));
        for(int i=0;i<16;i++){
            puzzlePart[i] = new JLabel(" ");
            puzzlePart[i].setName(""+(i+1));
            puzzlePart[i].setHorizontalAlignment(SwingConstants.CENTER);
            puzzlePart[i].setVerticalAlignment(SwingConstants.CENTER);
            puzzlePart[i].setOpaque(true);
            puzzlePart[i].setBackground(Color.BLACK);
            puzzlePart[i].setForeground(Color.WHITE);
            puzzlePart[i].addMouseListener(this);
            add(puzzlePart[i]);
        }
        
    }
    
    private static void CLEAR(){
        for(int i=0;i<16;i++){
            puzzlePart[i].setText(" ");
        }
    }
    
    public static void RANDOM(){
        CLEAR();
        Random generator = new Random();
        for(int i = 0; i<15;i++){
            String name = puzzlePart[i].getText();
            int value = generator.nextInt(15)+1;
            int j = 0;
            do{
                String nameIn = puzzlePart[j].getText();
                if(nameIn.equals(""+value)){
                    System.err.println("DZIAŁ "+i+"  "+j+"\t"+value);
                    value = generator.nextInt(15)+1;
                    j=-1;
                }
                j++;
            }while(j<16);      
            if(name.equals(" ")){
                puzzlePart[i].setText(value+"");
            }
        }
    }
    public int isMovePossible(String nameOfPuzzle){
        int position = Integer.parseInt(nameOfPuzzle);
        String checkedPos = " ";
        if(position >= 2 && !((position-1)%4==0)){
            position -= 2;
            checkedPos = puzzlePart[position].getText();
            if(checkedPos.equals(" ")) return position;
        }
        position = Integer.parseInt(nameOfPuzzle);
        if(position >= 5){
            position -= 5;
            checkedPos = puzzlePart[position].getText();
            if(checkedPos.equals(" ")) return position;
        }
        position = Integer.parseInt(nameOfPuzzle);
        if(position <= 12){
            position += 3;
            checkedPos = puzzlePart[position].getText();
            if(checkedPos.equals(" ")) return position;
        }
        position = Integer.parseInt(nameOfPuzzle);
        if(!(position%4==0)){
            checkedPos = puzzlePart[position].getText();
            if(checkedPos.equals(" ")) return position;
        }
        position = Integer.parseInt(nameOfPuzzle);
        return position-1;
    }
    
    public void movePuzzle(int currentPos,int destinationPos){
        if(currentPos != destinationPos){
        puzzlePart[destinationPos].setText(puzzlePart[currentPos].getText());
        puzzlePart[currentPos].setText(" ");
        }
    }

    public Boolean isGameWin(){
        int count=0;
        for(int i=0;i<16;i++){
            if(puzzlePart[i].getText().equals(""+(i+1))){
               count++;
            }
        }
        System.out.println(count);
        if(count == 15) return true;
        return false;
    }
    public void mouseClicked(MouseEvent event){
        Object source = event.getSource();
        for(int i =0; i < 16;i++){
            if(source == puzzlePart[i]){
                movePuzzle(i, isMovePossible(puzzlePart[i].getName()));   
            }
        }
    }
    public void mouseEntered(MouseEvent event){
    }
    public void mouseExited(MouseEvent event){
    }
    public void mousePressed(MouseEvent event){ 
    }
    public void mouseReleased(MouseEvent event){       
    }   
}
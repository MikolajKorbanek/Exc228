package pkg2_slidepuzzle;

import java.awt.BorderLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;

/**
 *
 * @author mixer
 */
public class Main extends JFrame{
    JButton newGame;
    gameField gF;
    
    public Main(){
        super("SlidePuzzleGame");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new BorderLayout());
        newGame = new JButton("New Game");
        newGame.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                gF.RANDOM();
            }
        });
        
        add(newGame,BorderLayout.NORTH);
        add(gF = new gameField(),BorderLayout.CENTER);
        
        
        setSize(400,400);
        setVisible(true);
    }
    
    public static void main(String[] args) {
        new Main();
    }
    
}

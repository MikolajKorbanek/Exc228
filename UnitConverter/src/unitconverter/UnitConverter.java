package unitconverter;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.math.BigDecimal;
import java.math.RoundingMode;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;

/**
 *
 * @author mixer
 */
public class UnitConverter extends JFrame{
    JTextField value,result;
    JButton convert;
    JComboBox types;
    JPanel holder;
    String[] typeOfConvert = {"cm/m","cm/km", "m/km", "m/cm", "km/cm", "km/m",
                             "cm2/m2", "m2/cm2", "m2/km2",
                             "kg/g"};
    String valueString="";
    public UnitConverter(){
        super("UnictConverter");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        holder = new JPanel();
        value = new JTextField(15);
        result = new JTextField(15);
        convert = new JButton("Convert");
        types = new JComboBox(typeOfConvert);
        
        convert.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                valueString = value.getText();
                
               switch(types.getSelectedIndex()){
                   case 0:
                       result.setText((Double.parseDouble(valueString)/100)+"");
                       break;
                   case 1:
                       result.setText(Double.parseDouble(valueString)/100_000+"");
                       break;
                   case 2:
                       result.setText(Double.parseDouble(valueString)/1000+"");
                       break;
                   case 3:
                       result.setText(Double.parseDouble(valueString)*100+"");
                       break;
                   case 4:
                       result.setText(Double.parseDouble(valueString)*100_000+"");
                       break;
                   case 5:
                       result.setText(Double.parseDouble(valueString)*1000+"");
                       break;
                   case 6:
                       result.setText(Double.parseDouble(valueString)/10_000+"");
                       break;
                   case 7:
                       result.setText(Double.parseDouble(valueString)*10_000+"");
                       break;
                   case 8:
                       result.setText(Double.parseDouble(valueString)/1_000_000+"");
                       break;
                   case 9:
                       result.setText(Double.parseDouble(valueString)/1000+"");
                   break;
               }
            }
        });
        
        
        holder.add(value);
        holder.add(types);
        holder.add(convert);
        holder.add(result);
        add(holder);
        pack();
        setVisible(true);
    }
    
    
    
    public static void main(String[] args) {
        new UnitConverter();
    }
    
}

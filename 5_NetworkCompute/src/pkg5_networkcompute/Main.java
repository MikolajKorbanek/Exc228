package pkg5_networkcompute;

import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.StringTokenizer;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;
//9:11 
//29-11-2017
/**
 *
 * @author mixer
 */
public class Main extends JFrame{
    
    JLabel addressJLabel, subnetLabel, netAddressLabel, broadcastLabel,firstHostLabel, lastHostLabel;
    JTextField ip4address, subnetMask, networkAddress, broadcast, firstHost, lastHost;
    JPanel addresPanel, subnetPanel, netPanel, broadcastPanel, firstHostPanel,lastHostPanel;
    JButton convert;
    String ipFromUser="", subnetFromUser="",broadCastForUser="",
            networkAddressForUser="",firstHostForUser="",lastHostForUser="";
    
    
    public Main(){
        super("Converter");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new GridLayout(7,1,2,2));
        
        ip4address = new JTextField(15);
        subnetMask = new JTextField(15);
        networkAddress = new JTextField(15);
        broadcast = new JTextField(15);
        firstHost = new JTextField(15);
        lastHost = new JTextField(15);
        
        convert = new JButton("Convert");
        addressJLabel = new JLabel("Address ip4");
        subnetLabel = new JLabel("Subnet");
        netAddressLabel = new JLabel("Network Address");
        broadcastLabel = new JLabel("Broadcast Address");
        firstHostLabel = new JLabel("First host:");
        lastHostLabel = new JLabel("Last host:");
        
        addresPanel = new JPanel(new GridLayout(1, 2));
        subnetPanel = new JPanel(new GridLayout(1, 2));
        netPanel = new JPanel(new GridLayout(1, 2));
        broadcastPanel = new JPanel(new GridLayout(1, 2));
        firstHostPanel = new JPanel(new GridLayout(1, 2));
        lastHostPanel = new JPanel(new GridLayout(1, 2));
        
        addresPanel.add(addressJLabel);
        addresPanel.add(ip4address);
        
        subnetPanel.add(subnetLabel);
        subnetPanel.add(subnetMask);
        
        netPanel.add(netAddressLabel);
        netPanel.add(networkAddress);
        
        broadcastPanel.add(broadcastLabel);
        broadcastPanel.add(broadcast);

        firstHostPanel.add(firstHostLabel);
        firstHostPanel.add(firstHost);
        
        lastHostPanel.add(lastHostLabel);
        lastHostPanel.add(lastHost);
        
        ipFromUser = ip4address.getText();
        subnetFromUser = subnetMask.getText();
        
        
        convert.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                calculateNetAddress(ip4address.getText(),subnetMask.getText());
            }
        });
        
        
        
        
        
        
        
        
        
        
        
        
        
        add(addresPanel);
        add(subnetPanel);
        add(convert);
        add(netPanel);
        add(broadcastPanel);
        add(firstHostPanel);
        add(lastHostPanel);
        
        
        
        setSize(400,400);
        setVisible(true);
    }
    
    public static void main(String[] args) {
        Main main = new Main();
//        main.calculateNetAddress("148.27.232.140","255.255.192.0");
    }
    
    public String convertToBinnary(String addressToConvert){
        int address = Integer.parseInt(addressToConvert);
        String addressToReturn = "";
        addressToReturn = Integer.toBinaryString(address);
        StringBuilder str = new StringBuilder(addressToReturn);
        
        while(str.length()<8){
            str.insert(0, "0");
        }
        
        
        addressToReturn = str.toString();
        
        
        return addressToReturn;
    }
    
    public void calculateNetAddress(String ip4Address, String subNetAddress){
        String AddressPart = "";
        String AddressPartB = "";
        String NetworkPart = "";
        String newPartAddress = "";
        String newPartBroadcast = "";
        int fromBinary = 0;
        networkAddressForUser = "";
        broadCastForUser = "";
        firstHostForUser="";
        lastHostForUser="";
        
        StringTokenizer stIP4 = new StringTokenizer(ip4Address, ".");
        StringTokenizer stNet = new StringTokenizer(subNetAddress, ".");
        
        while(stIP4.hasMoreTokens() && stNet.hasMoreTokens()){
            newPartAddress = "";
            newPartBroadcast = "";
            AddressPart = stIP4.nextToken();
            NetworkPart = stNet.nextToken();
            AddressPartB = AddressPart;
           if(Integer.parseInt(NetworkPart) != 255){
                AddressPart = convertToBinnary(AddressPart);
                NetworkPart = convertToBinnary(NetworkPart);

                for(int i=0;i<8;i++){
                    if(NetworkPart.charAt(i)=='1'){
                        newPartAddress += AddressPart.charAt(i);
                        newPartBroadcast += AddressPart.charAt(i);
                    }else{
                        newPartAddress += "0";
                        newPartBroadcast += "1";
                    }
                }
                fromBinary = Integer.parseInt(newPartAddress, 2);
                if(!(stIP4.hasMoreTokens() && stNet.hasMoreTokens())){
                   firstHostForUser += ""+(fromBinary+1);
                }
                AddressPart = ""+fromBinary;
                
                fromBinary = Integer.parseInt(newPartBroadcast, 2);
                if(!(stIP4.hasMoreTokens() && stNet.hasMoreTokens())){
                   lastHostForUser += "" + (fromBinary-1);
                }
                AddressPartB = ""+fromBinary;
                
           } 
            
            networkAddressForUser += AddressPart;
            broadCastForUser += AddressPartB;
            if(firstHostForUser.length()<9)firstHostForUser += AddressPart;
            if(lastHostForUser.length()<9)lastHostForUser += AddressPartB;
            if(networkAddressForUser.length()<12)networkAddressForUser +=".";
            if(broadCastForUser.length()<12)broadCastForUser +=".";
            if(firstHostForUser.length()<12)firstHostForUser +=".";
            if(lastHostForUser.length()<12)lastHostForUser +=".";
            
            networkAddress.setText(networkAddressForUser);
            broadcast.setText(broadCastForUser);
            firstHost.setText(firstHostForUser);
            lastHost.setText(lastHostForUser);
        }
        
 
    }
    
}

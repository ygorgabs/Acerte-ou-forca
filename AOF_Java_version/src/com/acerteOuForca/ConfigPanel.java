package com.acerteOuForca;

import javax.swing.*;

public class ConfigPanel {
    public static void configurar(JFrame frame, JPanel painel, int largura, int altura, String titulo){
        frame.setContentPane(painel);
        frame.setTitle(titulo);
        frame.setSize(largura,altura);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLocationRelativeTo(null);
    }
}

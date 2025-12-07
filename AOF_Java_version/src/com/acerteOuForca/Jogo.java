package com.acerteOuForca;

import javax.swing.*;

public class Jogo extends JFrame {
    private JPanel panelJogo;
    private JTextField textField1;
    private JButton verificarButton;
    private JButton outraPalavraButton;
    private JButton outroTemaButton;

    public Jogo() {
        ConfigPanel.configurar(this,panelJogo,600,380,"Acerte ou Forca");
    }
}
